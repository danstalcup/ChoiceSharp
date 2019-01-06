using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class Story
    {
        public List<StoryEvent> AllEvents { get; internal set; } = new List<StoryEvent>();
    }
}
