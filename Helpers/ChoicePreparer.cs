using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoiceSharp.Core;

namespace ChoiceSharp.Helpers
{
    public class ChoicePreparer
    {
        private readonly TextTransformer textTransformer;

        public ChoicePreparer()
        {
            textTransformer = new TextTransformer();
        }
        public void PrepareChoice(Choice choice, Stats stats)
        {
            choice.Text = textTransformer.TransformText(choice.RawText, stats);
        }
    }
}
