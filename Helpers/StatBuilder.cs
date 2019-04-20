using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class StatBuilder
    {
        public Stat BuildStat(string name, string category, string displayName, object value = null) =>
            new Stat { Name = name, Category = category, DisplayName = displayName, Value = value ?? string.Empty };
    }
}
