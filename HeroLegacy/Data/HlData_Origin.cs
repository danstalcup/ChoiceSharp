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
                Origin_1_Town,
                Origin_2,
                Origin_3,
                Origin_4,
                Origin_5
            };
        public static StoryEvent Origin_1 => new StoryEvent
        {
            Id = Origin_1_Id,            
            RawText = @"<p><i>Three months earlier...</i></p>
                        <p>It's the day of your fifteenth birthday! You awake to sunbeams on your eyelids and hop up. You gaze out to the familiar sight of...</p>
                        <p><i>Choose your home region.</i></p>
                        <p><b>Dunnriver City</b> - The large, bustling capital city of Halia. Home the nobel council chamber and governor's house. Southwest of Greenthorn.</p>
                        <p><b>A small town</b> - One of the three small towns within a day's walking distance of Greenthorn Academy</p>
                        <p><b>Plains and farmland</b> - Large swaths of vibrant, grassy farmlands west of Greenthorn Academy</p>
                        <p><b>Woodlands</b> - The dense woods of Greenthorn Forest. Not far from the academy</p>",
            RawChoices = Origin_1_Choices,
            NextEventId = Origin_2_Id
        };

        public static List<Choice> Origin_1_Choices => new List<Choice>
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
                RawText = "Plains and farmland",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.Plains}
            },
            new Choice
            {
                RawText = "Woodlands",
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

        public static StoryEvent Origin_2 => new StoryEvent
        {
            Id = Origin_2_Id,
            RawText = @"<p>As you go about your morning on your fifteenth birthday, you can't help but think how much your life circumstances have impacted your personality. You've only ever known life as...</p>
                        <p><i>Choose your family's background.</i></p>
                        <p><b>Noble</b>: Aristocrat, politician, magnate</p>
                        <p><b>Humble</b>: Farmer, artisan, shopkeeper</p>
                        <p><b>Poor</b>: Beggar, nomad, laborer</p>",
            RawChoices = Origin_2_Choices,
            NextEventId = Origin_3_Id
        };

        public static List<Choice> Origin_2_Choices => new List<Choice>
        {
            new Choice
            {
                RawText = "Noble",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundWealth, ResultObject = BackgroundWealthEnum.Noble}
            },
            new Choice
            {
                RawText = "Humble",                
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundWealth, ResultObject = BackgroundWealthEnum.Humble}
            },
            new Choice
            {
                RawText = "Poor",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundWealth, ResultObject = BackgroundWealthEnum.Poor}
            }
        };
        public static StoryEvent Origin_3 => new StoryEvent
        {
            Id = Origin_3_Id,
            RawText = @"<p>Even among people of your hometown and social stratus, you've always stood out. That's because of your unusual trait...</p>
                        <p><i>Choose your family's background.</i></p>
                        <p><b>Orphan</b>: Your parents died when you were little, and you've been raised by the community (and your own wits)</p>
                        <p><b>Unusual Birthmark</b>: You have a strange mark on your face that has always felt ominous and meaningful</p>
                        <p><b>From Distant Lands</b>: You were born from a distant land across the Sunbeam Sea</p>
                        <p><b>Raised by Goblins</b>: You never knew your human parents; your family was a caring unit of goblins who raised you as their own</p>
                        <p><b>Gifted</b>: Your insight and knack for learning skills has always set you apart</p>",
            RawChoices = Origin_3_Choices,
            NextEventId = Origin_4_Id
        };
        public static List<Choice> Origin_3_Choices => new List<Choice>
        {
            new Choice
            {
                RawText = "Orphan",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundUnusual, ResultObject = BackgroundUnusualEnum.Orphan}
            },
            new Choice
            {
                RawText = "Unusual Birthmark",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundUnusual, ResultObject = BackgroundUnusualEnum.UnusualBirthmark}
            },
            new Choice
            {
                RawText = "From Distant Lands",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundUnusual, ResultObject = BackgroundUnusualEnum.DistantLands}
            },
            new Choice
            {
                RawText = "Raised by Goblins",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundUnusual, ResultObject = BackgroundUnusualEnum.RaisedByGoblins}
            },
            new Choice
            {
                RawText = "Gifted",
                StatChange = new StatChange
                    {StatName = HlStats.BackgroundUnusual, ResultObject = BackgroundUnusualEnum.Gifted}
            }
        };
        public static StoryEvent Origin_4 => new StoryEvent
        {
            Id = Origin_4_Id,
            RawText = @"<p>What is your character's full, formal name?</p>",
            Type = StoryEventType.Input,
            InputTargetStat = HlStats.FullName,
            NextEventId = Origin_5_Id
        };
        public static StoryEvent Origin_5 => new StoryEvent
        {
            Id = Origin_5_Id,
            RawText = @"<p>What name does your character usually go by?</p>",
            Type = StoryEventType.Input,
            InputTargetStat = HlStats.Name,
            NextEventId = "poop"
        };
        public const string Origin_1_Id = "origin_1";
        public const string Origin_1_Town_Id = "origin_1_town";
        public const string Origin_2_Id = "origin_2";
        public const string Origin_3_Id = "origin_3";
        public const string Origin_4_Id = "origin_4";
        public const string Origin_5_Id = "origin_5";
    }
}
