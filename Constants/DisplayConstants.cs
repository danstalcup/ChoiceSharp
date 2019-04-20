using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.Constants
{
    public class DisplayConstants
    {
        public const string BreakBetweenInfoBlocks = "<p>----------</p>";

        public const string ReferenceItemCreatedSuffix = "was added to your Reference.";

        public const string ReferenceItemUpdatedSuffix = "was updated in your Reference.";

        public static string DefaultButtonText(StoryEventType storyEventType)
        {
            switch (storyEventType)
            {
                case StoryEventType.TextOnly:
                    return "Continue";
                case StoryEventType.Choice:
                    return "Select";
                case StoryEventType.Input:
                    return "Submit";
                case StoryEventType.Error:
                    return "Error";
                default:
                    throw new Exception("Invalid Event Type");
            }
        }

        public static StoryEvent ErrorMessage(string message)
        {
            return new StoryEvent
            {
                RawText = $"<h3>Error</h3><p>{message}</p>",
                Type = StoryEventType.Error
            };
        }
    }
}
