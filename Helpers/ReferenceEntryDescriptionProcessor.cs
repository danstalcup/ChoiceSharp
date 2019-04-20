using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Constants;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class ReferenceEntryDescriptionProcessor
    {
        public string ProcessDescriptionFromReferenceEntries(List<ReferenceEntry> referenceItems)
        {
            var result = new StringBuilder();
            foreach (var referenceItem in referenceItems)
            {
                if (referenceItem.WasCreated)
                {
                    result.Append($"<p><i><b>{referenceItem.Title}</b> {DisplayConstants.ReferenceItemCreatedSuffix}</i></p>");
                }
                else if (referenceItem.WasUpdated && referenceItem.UseNotificationWhenUpdated)
                {
                    result.Append($"<p><i><b>{referenceItem.Title}</b> {DisplayConstants.ReferenceItemUpdatedSuffix}</i></p>");
                }
            }
            return result.ToString();
        }
    }
}
