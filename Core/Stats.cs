using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class Stats: List<Stat>
    {                         
        public Stat this[string name] => this.SingleOrDefault(s => s.Name == name);
    }    
}
