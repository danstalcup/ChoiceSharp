using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.StatEntities
{
    public class Gender
    {
        public GenderEnum GenderEnum { get; internal set; } = GenderEnum.Male;

        public bool IsMale => GenderEnum == GenderEnum.Male;

        public bool IsFemale => GenderEnum == GenderEnum.Female;

        public string HeShe => IsMale ? "he" : "she";

        public string HeSheCaps => IsMale ? "He" : "She";

        public Gender Male => new Gender {GenderEnum = GenderEnum.Male };
        public Gender Female => new Gender { GenderEnum = GenderEnum.Female };
    }

    public enum GenderEnum
    {
        Male, Female
    }
}
