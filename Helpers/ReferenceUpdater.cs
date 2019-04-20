using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class ReferenceUpdater
    {
        public void UpdateReference(Reference reference, List<ReferenceEntry> referenceItems, Stats stats)
        {
            var textTransformer = new TextTransformer();                     

            foreach (var inputReferenceItem in referenceItems)
            {
                var referenceEntryContents = textTransformer.TransformText(inputReferenceItem.RawContents, stats);
                var referenceEntryTitle = textTransformer.TransformText(inputReferenceItem.RawTitle, stats);

                var entryToAddOrUpdate = reference.RawEntries.SingleOrDefault(ri => ri.Id == inputReferenceItem.Id);
                
                if (entryToAddOrUpdate == null)
                {
                    entryToAddOrUpdate = inputReferenceItem;
                    entryToAddOrUpdate.Order = reference.RawEntries.Select(re => re.Order).DefaultIfEmpty().Max() + 1;                    
                    reference.RawEntries.Add(entryToAddOrUpdate);

                    inputReferenceItem.WasCreated = true;
                }
                else
                {
                    if (referenceEntryContents != entryToAddOrUpdate.Contents ||
                        referenceEntryTitle != entryToAddOrUpdate.Title)
                    {
                        inputReferenceItem.WasUpdated = true;
                    }
                }
                
                entryToAddOrUpdate.Contents = referenceEntryContents;
                entryToAddOrUpdate.Title = referenceEntryTitle;

                inputReferenceItem.Title = referenceEntryTitle;
                inputReferenceItem.Contents = referenceEntryContents;
            }            
        }
    }
}
