using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Constants;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class StoryEventPreparer
    {
        private readonly ChoicePreparer ChoicePreparer;
        private readonly TextTransformer textTransformer;

        public StoryEventPreparer()
        {
            ChoicePreparer = new ChoicePreparer();       
            textTransformer = new TextTransformer();
        }

        public void PrepareStoryEvent(StoryEvent storyEvent, Stats stats)
        {
            storyEvent.DisplayText = string.Empty; 

            foreach (var append in storyEvent.AppendText)
            {                
                storyEvent.DisplayText += textTransformer.TransformText(append, stats);
                storyEvent.DisplayText += DisplayConstants.BreakBetweenInfoBlocks;
            }

            storyEvent.DisplayText += textTransformer.TransformText(storyEvent.RawText, stats);

            storyEvent.ButtonText = textTransformer.TransformText(storyEvent.RawButtonText, stats);

            if (string.IsNullOrEmpty(storyEvent.ButtonText))
            {
                storyEvent.ButtonText = DisplayConstants.DefaultButtonText(storyEvent.Type);
            }                        

            foreach (var choice in storyEvent.RawChoices)
            {
                ChoicePreparer.PrepareChoice(choice, stats);
            }            
        }
    }
}
