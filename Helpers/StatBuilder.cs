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
        public Stat BuildIntStat(string name, string category, int value = 0) =>
            new Stat {Name = name, Category = category, ValueInt = value, Type = StatType.Int};

        public Stat BuildStringStat(string name, string category, string value = "") =>
            new Stat { Name = name, Category = category, ValueString = value, Type = StatType.String };

        public Stat BuildBoolStat(string name, string category, bool value = false) =>
            new Stat { Name = name, Category = category, ValueBool = value };
    }
}
