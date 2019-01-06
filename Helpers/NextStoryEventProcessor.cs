using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

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
            if (response.StoryEventType == StoryEventType.TextOnly ||
                response.StoryEventType == StoryEventType.Input)
            {
                return lookup.FindEvent(story,response.StoryEvent.SimpleNextEventId);
            }

            if (response.Choice.Type == ChoiceType.InfoOnly)
            {
                return response.StoryEvent;
            }

            return lookup.FindEvent(story, response.Choice.SimpleNextEventId);
        }
    }
}
