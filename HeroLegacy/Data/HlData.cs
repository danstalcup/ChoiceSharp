using System;
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

                foreach (var stat in HlStats.StatMapping)
                {
                    result.Add(builder.BuildStat(stat.Item1, stat.Item2, stat.Item3));
                }

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

        public static Reference Reference
        {
            get
            {
                var reference = new Reference();

                // default entries go here

                return reference;
            }
        }
    }

    public class HlStats
    {
        public const string FullName = "FullName";
        public const string Name = "Name";
        public const string BackgroundRegion = "BackgroundRegion";
        public const string BackgroundWealth = "BackgroundWealth";
        public const string BackgroundUnusual = "BackgroundUnusual";

        public static (string, string, string)[] StatMapping => new[]
        {
            (FullName, HlStatCategory.Basic, HlStatDisplayName.FullName),
            (Name, HlStatCategory.Basic, HlStatDisplayName.Name),
            (BackgroundRegion, HlStatCategory.Background, HlStatDisplayName.BackgroundRegion),
            (BackgroundWealth, HlStatCategory.Background, HlStatDisplayName.BackgroundWealth),
            (BackgroundUnusual, HlStatCategory.Background, HlStatDisplayName.BackgroundUnusual),
        };

    }

    public class HlStatCategory
    {
        public const string Basic = "Basic";
        public const string Background = "Background";
    }

    public class HlStatDisplayName
    {
        public const string FullName = "Full Name";
        public const string Name = "Name";
        public const string BackgroundRegion = "Background - Region";
        public const string BackgroundWealth = "Background - Wealth";
        public const string BackgroundUnusual = "Background - Unusual Trait";
    }
}
