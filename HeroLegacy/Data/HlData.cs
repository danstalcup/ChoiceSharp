using System.Collections.Generic;
using ChoiceSharp.Core;
using ChoiceSharp.Helpers;
using ChoiceSharp.HeroLegacy.HeroLegacyStatEntities;

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

                return result;
            }
        }      

        public static Story Story => new Story
        {
            AllEvents = new List<StoryEvent>()
            {
                Intro_1,
                Intro_2,
                Intro_3,
                Origin_1
            }
        };

        public static StoryEvent Intro_1 => new StoryEvent
        {
            Id = HlIds.Intro_1,
            RawText = @"<p>As you round the corner of cobbled path, you see a hand-carved wooden sign:</p>
            <h3>Greenthorn Academy</h3>
            <p>You've finally arrived. You've spent the past three months imagining this exact moment.</p
            <p>It's orientation day at the legendary academy of heroics in all of Halia. Each year, 24 teenagers from all walks of life are recruited by Greenthorn's esteemed headmaster, Sir Alton, to join the acaemy's rigorous, five-year hero training program.</p>
            <p>You received your note of admission earlier this year.</p>
            <p>You pass the sign and are greeted with an enthusiastic wave.It's an older student. He looks exactly like the knights from storybooks: A foot taller than you, a chiseled jawline, and bulging pecs. You can't imagine yourself looking this heroic ever.</p>
            <p>You walk over and pull your note of admission from your pocket.He glances at it, flashes his jarringly white teeth, and says…</p>            
            <p><b>""Welcome to Greenthorn!""</b></p>",
            NextEventId = HlIds.Intro_2
        };

        public static StoryEvent Intro_2 => new StoryEvent
        {
            Id = HlIds.Intro_2,
            Type = StoryEventType.Choice,
            RawText = @"<p>The Prince Charming-doppelganger introduces himself as a fifth-year student helping out with orientation. You're itching to go find your dorm and start exploring, but he hands you a small vellum pamphlet.</p>
                        <p>The cover of the booklet reads <i>Greenthorn Academy: Orientation Guide</i>. You flip it open.</p>",
            RawChoices = Intro_2_Choices
        };

        public static List<Choice> Intro_2_Choices => new List<Choice>
        {
            new Choice
            {
                RawText = "Stick the booklet in your pocket and walk to the dorms.",
                NextEventId = HlIds.Intro_3
            },
            new Choice
            {
                RawText = @"Read ""About Greenthorn Academy""",
                Type = ChoiceType.InfoOnly,
                InfoAppendToEventRaw = @"<h4>""About Greenthorn Academy""</h4>
                    <p>""Greenthorn Academy is a small school for exceptionally qualified young adults to learn the skills to serve and protect Halia, or wherever their future path might wind. Greenthorn embraces students poor and rich from all over Halia.</p>
                    <p>Located in the heart of Greenthorn Forest, dressed in the shadows of broadleaf trees, the academy was founded by current headmaster Sir Alton nearly fifty years ago. Sir Alton still serves as Greenthorn's chief recruiter, identifying and recruiting the most gifted youths across the land.</p>
                    <p>Greenthorn Academy employs a vibrant and skilled staff with expertise in various areas of heroics. The instructors double as the caretakers and counselors of the students.""</p>"
            },
            new Choice
            {
                RawText = @"Read ""About the region""",
                Type = ChoiceType.InfoOnly,
                InfoAppendToEventRaw = @"<h4>""About the region""</h4>
                    <p>""The academy is a day's walk, or few hours horse ride, from three small trading towns: Ashton to the west, Belltip to the east, and Crowbrook to the north.</p>
                    <p>To the southwest, a day's horse ride or several day hike away, is Dunnriver City, the capital of Halia.</p>
                    <p>Halia has for centuries been a peaceful haven for humans. Rough soil but a temperate climate has encouraged free-flowing trade and a comfortable but humble lifestyle.""</p>"
            },
            new Choice
            {
                RawText = @"Read ""About the school year""",
                Type = ChoiceType.InfoOnly,
                InfoAppendToEventRaw = @"<h4>""About the school year""</h4>                
                    <p>""Each year of training at Greenthorn is broken into four quarters to match the seasons: Fall, Winter, Spring, and Summer, each about three months long. At the end of each period are exams as well as a student Tournament.</p>
                    <p>Each quarter spans twelve weeks, followed by a week of vacation from classes.""</p>"
            },
            new Choice
            {
                RawText = @"Read ""About the tourney""",
                Type = ChoiceType.InfoOnly,
                InfoAppendToEventRaw = @"<h4>""About the tourney""</h4>                
                    <p>""qz Tourney info goes here""</p>"
            }
        };

        public static StoryEvent Intro_3 => new StoryEvent
        {
            Id = HlIds.Intro_3,
            RawText = @"<p>qz Intro to goblins</p>
                        <p>Goblins used to be a rare sight in Halia. Apart from the occasional roving gang, goblins have long kept to themselves in the southeast</p>
                        <p>qz Lead in to origin story</p>",
            RawButtonText = "Three months earlier...",
            NextEventId = HlIds.Origin_1
        };

        public static StoryEvent Origin_1 => new StoryEvent
        {
            Id = HlIds.Origin_1,
            Type = StoryEventType.Choice,
            RawText = @"<p>It's the day of your fifteenth birthday! You awake to sunbeams on your eyelids and hop up. You gaze out to the familiar sight of...</p>
                        <p><i>Choose your home region.</i></p>",
            RawChoices = OriginBackgroundChoices,
            NextEventId = HlIds.Origin_2
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
                NextEventId = HlIds.Origin_1_Town
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
            Id = HlIds.Origin_1_Town,
            RawText = @"<p><i>Choose what small town you grew up in.</i></p>
                        <p><b>Ashton</b>: West of Greenthorn. A crossroads town inhabited by merchants and loggers.</p>
                        <p><b>Belltip</b>: East of Greenthorn. On the coast of the Sunbeam Sea. A harbor and fishing village.</p>
                        <p><b>Crowbrook</p>: North of Greenthorn. Rocky mining town.</p>",
            RawChoices = Origin_1_Town_Choices,
            NextEventId = HlIds.Origin_2
        };

        public static List<Choice> Origin_1_Town_Choices => new List<Choice>
        {
            new Choice
            {
                Text = "Ashton",
                StatChange = new StatChange { StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.TownA }
            },
            new Choice
            {
                Text = "Belltip",
                StatChange = new StatChange { StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.TownB }
            },
            new Choice
            {
                Text = "Crowbrook",
                StatChange = new StatChange { StatName = HlStats.BackgroundRegion, ResultObject = BackgroundRegionEnum.TownC }
            }
        };

    }

    public class HlIds
    {
        public const string Intro_1 = "intro_1";
        public const string Intro_2 = "intro_2";
        public const string Intro_3 = "intro_3";

        public const string Origin_1 = "origin_1";
        public const string Origin_1_Town = "origin_1_town";
        public const string Origin_2 = "origin_2";
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
