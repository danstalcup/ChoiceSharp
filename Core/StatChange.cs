using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class StatChange
    {
        public string StatName { get; set; }

        public bool? ResultBool { get; internal set; }

        public int? ResultIntSet { get; internal set; }

        public int? ResultIntChange { get; internal set; }

        public int? ResultIntFairmath { get; internal set; }

        public string ResultString { get; internal set; }
    }
}
