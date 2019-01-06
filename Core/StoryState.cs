using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class StoryState
    {
        public StoryState(Story story, StoryEvent startingEvent)
        {
            this.Story = story;
            this.CurrentEvent = startingEvent;
        }
        public Story Story { get; internal set; }

        public StoryEvent CurrentEvent { get; internal set; }
    }
}
