using System.Collections.Generic;
using ChoiceSharp.Core;
using ChoiceSharp.Helpers;
using ChoiceSharp.HeroLegacy.StatEntities;

namespace ChoiceSharp.HeroLegacy.Data
{
    public class HlData
    {
        public static Stats Stats
        {
            get
            {
                var result = new Stats();
                var builder = new StatBuilder();

                result.Add(builder.BuildStat(HlStats.FullName, HlStatCategory.Basic));
                result.Add(builder.BuildStat(HlStats.Name, HlStatCategory.Basic));

                result.Add(builder.BuildStat(HlStats.BackgroundRegion, HlStatCategory.Background));

                return result;
            }
        }      

        public static Story Story
        {
            get
            {
                var story = new Story();
                story.AllEvents.AddRange(HlData_Intro.Events);
                story.AllEvents.AddRange(HlData_Origin.Events);
                return story;
            }
        }
    }

    public class HlStats
    {
        public const string FullName = "FullName";
        public const string Name = "Name";
        public const string BackgroundRegion = "BackgroundRegion";
    }

    public class HlStatCategory
    {
        public const string Basic = "Basic";
        public const string Background = "Background";
    }
}
