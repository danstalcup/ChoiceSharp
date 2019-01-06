using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class StatsUpdater
    {
        private FairmathCalculator fairmathCalculator;

        public StatsUpdater()
        {
            fairmathCalculator = new FairmathCalculator();
        }

        public void UpdateStatsFromResponse(Stats stats, Response response)
        {
            if (response.Choice == null || response.Choice.StatChanges == null)
            {
                return;
            }
            foreach (var statChange in response.Choice.StatChanges)
            {
                var stat = stats[statChange.StatName];
                ApplyStatChange(stat, statChange);
            }
        }

        private void ApplyStatChange(Stat stat, StatChange statChange)
        {
            if (statChange.ResultBool != null)
            {
                stat.ValueBool = statChange.ResultBool.Value;
            }

            if (statChange.ResultString != null)
            {
                stat.ValueString = statChange.ResultString;
            }

            if (statChange.ResultIntSet != null)
            {
                stat.ValueInt = statChange.ResultIntSet.Value;
            }

            if (statChange.ResultIntChange != null)
            {
                stat.ValueInt += statChange.ResultIntChange.Value;
            }

            if (statChange.ResultIntFairmath != null)
            {
                stat.ValueInt = fairmathCalculator.ApplyFairmath(stat.ValueInt, statChange.ResultIntFairmath.Value);
            }

            if (statChange.ResultObject != null)
            {
                stat.Value = statChange.ResultObject;
            }
        }
    }
}
