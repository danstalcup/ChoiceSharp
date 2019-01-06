using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class StoryEventUpdaterFromResponse
    {
        public void UpdateStoryEventFromResponse(Response response)
        {            
            var storyEvent = response.StoryEvent;

            if (storyEvent.Type == StoryEventType.TextOnly ||
                storyEvent.Type == StoryEventType.Input)
            {
                return;
            }

            var choice = response.Choice;
            if (choice.Type == ChoiceType.InfoOnly)
            {
                storyEvent.AppendText.Insert(0, choice.InfoAppendToEventRaw);
                choice.IsVisible = false;
            }
        }
    }
}
