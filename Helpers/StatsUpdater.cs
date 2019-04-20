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
                var stat = FindStat(stats, statChange.StatName);
                ApplyStatChange(stat, statChange);
            }
        }

        private static Stat FindStat(Stats stats, string statName)
        {
            return stats[statName];
        }

        private void ApplyStatChange(Stat stat, StatChange statChange)
        {
            if (statChange.ResultBool != null)
            {
                stat.ValueBool = statChange.ResultBool.Value;
            }

            if (statChange.ResultString != null)
            {
                UpdateString(stat, statChange.ResultString);
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

        private static void UpdateString(Stat stat, string statChangeString)
        {
            stat.ValueString = statChangeString;
        }

        public void UpdateStatsFromInput(Stats stats, string targetStat, string input)
        {
            UpdateString(FindStat(stats, targetStat), input);
        }
    }
}
