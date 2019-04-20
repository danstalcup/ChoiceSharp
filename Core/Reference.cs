using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class Reference
    {
        internal List<ReferenceEntry> RawEntries { get; set; } = new List<ReferenceEntry>();

        public List<ReferenceEntry> Entries => RawEntries.OrderBy(re => re.Order).ToList();
    }
}
