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

        public StoryState StoryState { get; protected set; }

        public Stats Stats { get; protected set; }

        public Engine()
        {
            storyStateUpdater = new StoryStateUpdater();
            storyEventPreparer = new StoryEventPreparer();
            statsUpdater = new StatsUpdater();
            nextStoryEventProcessor = new NextStoryEventProcessor();
            storyEventUpdaterFromResponse = new StoryEventUpdaterFromResponse();

            var story = HlData.Story;
            StoryState = new StoryState(story, story.AllEvents[0]);
            Stats = HlData.Stats;
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
            storyEventUpdaterFromResponse.UpdateStoryEventFromResponse(response);
            var nextEvent = nextStoryEventProcessor.GetNextStoryEvent(response, StoryState.Story);
            storyStateUpdater.SetNextStoryEvent(StoryState, nextEvent);
        }
    }
}
