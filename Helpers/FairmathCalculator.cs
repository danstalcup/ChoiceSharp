using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Helpers
{
    public class FairmathCalculator
    {
        public int ApplyFairmath(int current, int change)
        {            
            if (change == 0 ||
                current > 100 ||
                current < 0) return current;

            var diff = change > 0 ? 100 - current : current;            
            var netChange = diff * change / 100m;
            var result = (int)Math.Round(current + netChange, MidpointRounding.AwayFromZero);
            result = Math.Max(0, result);
            result = Math.Min(100, result);
            return result;
        }
    }
}
