using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class StoryEvent
    {
        public string Id { get; internal set; }

        internal string RawText { get; set; }

        public string DisplayText { get; internal set; }

        public StoryEventType Type { get; internal set; } = StoryEventType.Choice;

        internal List<Choice> RawChoices { get; set; } = new List<Choice>();

        public List<Choice> Choices => RawChoices.Where(c => c.IsVisible).ToList();

        public string NextEventId { get; internal set; }

        public string DefaultInput { get; internal set; } = string.Empty;

        internal string RawButtonText { get; set; } = string.Empty;

        public string ButtonText { get; internal set; }

        internal List<string> AppendText { get; set; } = new List<string>();
    }

    public enum StoryEventType
    {
        TextOnly, Choice, Input, Error
    }
}
