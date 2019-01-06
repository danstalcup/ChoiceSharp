using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;
using ChoiceSharp.HeroLegacy.StatEntities;

namespace ChoiceSharp.HeroLegacy.Data
{
    class HlData_Origin
    {
        public static List<StoryEvent> Events =>
            new List<StoryEvent>
            {
                Origin_1,
                Origin_1_Town                
            };
        public static StoryEvent Origin_1 => new StoryEvent
        {
            Id = Origin_1_Id,            
            RawText = @"<p>It's the day of your fifteenth birthday! You awake to sunbeams on your eyelids and hop up. You gaze out to the familiar sight of...</p>
                        <p><i>Choose your home region.</i></p>",
            RawChoices = OriginBackgroundChoices,
            NextEventId = Origin_2_Id
        };

        public static List<Choice> OriginBackgroundChoices => new List<Choice>
        {
            new Choice
            {
                RawText = "Dunnriver City",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.City}
            },
            new Choice
            {
                RawText = "A small town",
                NextEventId = Origin_1_Town_Id
            },
            new Choice
            {
                RawText = "Vibrant plains and farmland",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.Plains}
            },
            new Choice
            {
                RawText = "Dense woodlands",
                StatChange = new StatChange { StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.Forest }
            }
        };

        public static StoryEvent Origin_1_Town => new StoryEvent
        {
            Id = Origin_1_Town_Id,            
            RawText = @"<p><i>Choose what small town you grew up in.</i></p>
                        <p><b>Ashton</b>: West of Greenthorn. A crossroads town inhabited by merchants and loggers.</p>
                        <p><b>Belltip</b>: East of Greenthorn. On the coast of the Sunbeam Sea. A harbor and fishing village.</p>
                        <p><b>Crowbrook</b>: North of Greenthorn. Rocky mining town.</p>",
            RawChoices = Origin_1_Town_Choices,
            NextEventId = Origin_2_Id
        };

        public static List<Choice> Origin_1_Town_Choices => new List<Choice>
            {
                new Choice
                {
                    RawText = "Ashton",
                    StatChange = new StatChange { StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.TownA }
                },
                new Choice
                {
                    RawText = "Belltip",
                    StatChange = new StatChange { StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.TownB }
                },
                new Choice
                {
                    RawText = "Crowbrook",
                    StatChange = new StatChange { StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.TownC }
                }
            };

        public const string Origin_1_Id = "origin_1";
        public const string Origin_1_Town_Id = "origin_1_town";
        public const string Origin_2_Id = "origin_2";
    }
}
