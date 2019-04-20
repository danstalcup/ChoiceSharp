using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceSharp.Core
{
    public class Stat
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Category { get; internal set; }

        public object Value { get; internal set; }

        public T GetValue<T>()
        {
            try
            {
                return (T)Value;
            }
            catch (Exception)
            {
                return default(T);
            }
        }            

        public int ValueInt
        {
            get => GetValue<int>();
            internal set => Value = value;
        }

        public string ValueString
        {
            get => GetValue<string>();
            internal set => Value = value;
        }

        public bool ValueBool
        {
            get => GetValue<bool>();
            internal set => Value = value;
        }
    }
}
