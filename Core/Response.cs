using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class Response
    {
        public StoryEventType StoryEventType => StoryEvent.Type;

        public StoryEvent StoryEvent { get; set; }

        public Choice Choice { get; set; }

        public string Input { get; set; }
    }
}
