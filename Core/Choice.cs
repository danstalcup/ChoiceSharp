using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class Choice
    {
        public ChoiceType Type { get; internal set; } = ChoiceType.NewScene;

        internal string InfoAppendToEventRaw { get; set; }        

        internal string RawText { get; set; }

        public string Text { get; internal set; }

        public string NextEventId { get; internal set; }

        public List<StatChange> StatChanges { get; internal set; } = new List<StatChange>();

        public StatChange StatChange
        {
            get => StatChanges.SingleOrDefault();
            set => StatChanges = new List<StatChange> {value};
        }

        public override string ToString() => Text;

        public bool IsVisible = true;
    }

    public enum ChoiceType
    {
        InfoOnly, NewScene
    }
}