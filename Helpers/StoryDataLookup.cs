using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Constants;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class StoryDataLookup
    {
        public StoryEvent FindEvent(Story story, string storyEventId)
        {
            return story.AllEvents.SingleOrDefault(se => se.Id == storyEventId) ?? DisplayConstants.ErrorMessage($"Story event with ID \"<i>{storyEventId}</i>\" not found");
        }
    }
}
