using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;
using Exception = System.Exception;

namespace ChoiceSharp.Helpers
{
    public class NextStoryEventProcessor
    {
        private readonly StoryDataLookup lookup;

        public NextStoryEventProcessor()
        {
            lookup = new StoryDataLookup();
        }

        public StoryEvent GetNextStoryEvent(Response response, Story story)
        {
            if (response.Choice.Type == ChoiceType.InfoOnly)
            {
                return response.StoryEvent;
            }

            if (response.Choice != null &&
                !string.IsNullOrEmpty(response.Choice.NextEventId))
            {
                return lookup.FindEvent(story, response.Choice.NextEventId);
            }

            if(!string.IsNullOrEmpty(response.StoryEvent.NextEventId))
            { 
                return lookup.FindEvent(story, response.StoryEvent.NextEventId);
            }

            throw new Exception("Could not determine next event -- ID might be missing on event or choice");
        }
    }
}
