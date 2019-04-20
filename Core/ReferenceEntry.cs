using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class ReferenceEntry
    {
        public string Id { get; set; }

        internal string RawTitle { get; set; }

        internal string RawContents { get; set; }

        public string Title { get; set; }

        public string Contents { get; set; }

        public int Order { get; set; }

        internal bool WasUpdated { get; set; } = false;

        internal bool WasCreated { get; set; } = false;

        internal bool UseNotificationWhenUpdated { get; set; } = true;

        public override string ToString() => Title;
    }
}
