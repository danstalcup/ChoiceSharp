using System.Text;
using ChoiceSharp.Core;
using ChoiceSharp.Helpers;
using ChoiceSharp.HeroLegacy;
using ChoiceSharp.HeroLegacy.Data;

namespace ChoiceSharp
{
    public class Engine
    {
        private readonly StoryStateUpdater storyStateUpdater;

        private readonly StoryEventPreparer storyEventPreparer;

        private readonly StoryEventUpdaterFromResponse storyEventUpdaterFromResponse;

        private readonly StatsUpdater statsUpdater;

        private readonly NextStoryEventProcessor nextStoryEventProcessor;

        private readonly ReferenceUpdater referenceUpdater;

        public StoryState StoryState { get; protected set; }

        public Stats Stats { get; protected set; }

        public Reference Reference { get; protected set; }

        public Engine()
        {            
            storyStateUpdater = new StoryStateUpdater();
            storyEventPreparer = new StoryEventPreparer();
            statsUpdater = new StatsUpdater();
            nextStoryEventProcessor = new NextStoryEventProcessor();
            storyEventUpdaterFromResponse = new StoryEventUpdaterFromResponse();
            referenceUpdater = new ReferenceUpdater();

            var story = HlData.Story;
            StoryState = new StoryState(story, story.AllEvents[0]);
            Stats = HlData.Stats;
            Reference = HlData.Reference;
        }

        public StoryEvent GetCurrentStoryEvent()
        {
            var storyEvent = StoryState.CurrentEvent;
            storyEventPreparer.PrepareStoryEvent(storyEvent, Stats);
            return storyEvent;
        }        

        public void ProcessResponse(Response response)
        {
            statsUpdater.UpdateStatsFromResponse(Stats, response);
            if (response.StoryEventType == StoryEventType.Input)
            {
                statsUpdater.UpdateStatsFromInput(Stats, response.StoryEvent.InputTargetStat, response.Input);
            }
            storyEventUpdaterFromResponse.UpdateStoryEventFromResponse(response);
            var nextEvent = nextStoryEventProcessor.GetNextStoryEvent(response, StoryState.Story);
            storyStateUpdater.SetNextStoryEvent(StoryState, nextEvent);
            referenceUpdater.UpdateReference(Reference, nextEvent.RawReferenceEntries, Stats);
        }

        public string RenderStats()
        {
            var result = new StringBuilder();
            foreach (var stat in Stats)
            {
                result.Append($"<p><i>{stat.DisplayName}</i>: {stat.Value}</p>");
            }

            return result.ToString();
        }
    }
}
