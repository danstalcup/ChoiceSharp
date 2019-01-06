using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class Stat
    {
        public string Name { get; set; }

        public string Category { get; internal set; }

        public int ValueInt { get; internal set; }

        public string ValueString { get; internal set; }

        public bool ValueBool { get; internal set; }     
        
        public StatType Type { get; internal set; }
    }

    public enum StatType
    {
        Int, String, Bool
    }
}
