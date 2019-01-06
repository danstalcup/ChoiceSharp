using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class StoryStateUpdater
    {
        public void SetNextStoryEvent(StoryState storyState, StoryEvent storyEvent)
        {
            storyState.CurrentEvent = storyEvent;
        }
    }
}
