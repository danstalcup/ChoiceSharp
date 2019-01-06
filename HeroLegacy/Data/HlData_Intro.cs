using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.HeroLegacy.Data
{
    class HlData_Intro
    {
        public static List<StoryEvent> Events =>
            new List<StoryEvent>
            {
                Intro_1,
                Intro_2,
                Intro_3
            };
        public static StoryEvent Intro_1 => new StoryEvent
        {
            Id = Intro_1_Id,
            Type = StoryEventType.TextOnly,
            RawText = @"<p>As you round the corner of cobbled path, you see a hand-carved wooden sign:</p>
            <h3>Greenthorn Academy</h3>
            <p>You've finally arrived. You've spent the past three months imagining this exact moment.</p
            <p>It's orientation day at the legendary academy of heroics in all of Halia. Each year, 24 teenagers from all walks of life are recruited by Greenthorn's esteemed headmaster, Sir Alton, to join the acaemy's rigorous, five-year hero training program.</p>
            <p>You received your note of admission earlier this year.</p>
            <p>You pass the sign and are greeted with an enthusiastic wave.It's an older student. He looks exactly like the knights from storybooks: A foot taller than you, a chiseled jawline, and bulging pecs. You can't imagine yourself looking this heroic ever.</p>
            <p>You walk over and pull your note of admission from your pocket.He glances at it, flashes his jarringly white teeth, and says…</p>            
            <p><b>""Welcome to Greenthorn!""</b></p>",
            NextEventId = Intro_2_Id
        };

        public static StoryEvent Intro_2 => new StoryEvent
        {
            Id = Intro_2_Id,            
            RawText = @"<p>The Prince Charming-doppelganger introduces himself as a fifth-year student helping out with orientation. You're itching to go find your dorm and start exploring, but he hands you a small vellum pamphlet.</p>
                        <p>The cover of the booklet reads <i>Greenthorn Academy: Orientation Guide</i>. You flip it open.</p>",
            RawChoices = Intro_2_Choices
        };

        public static List<Choice> Intro_2_Choices => new List<Choice>
        {
            new Choice
            {
                RawText = "Stick the booklet in your pocket and walk to the dorms.",
                NextEventId = Intro_3_Id
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
            Id = Intro_3_Id,
            Type = StoryEventType.TextOnly,
            RawText = @"<p>qz Intro to goblins</p>
                        <p>Goblins used to be a rare sight in Halia. Apart from the occasional roving gang, goblins have long kept to themselves in the southeast</p>
                        <p>qz Lead in to origin story</p>",
            RawButtonText = "Three months earlier...",
            NextEventId = HlData_Origin.Origin_1_Id
        };

        public const string Intro_1_Id = "intro_1";
        public const string Intro_2_Id = "intro_2";
        public const string Intro_3_Id = "intro_3";
    }
}
