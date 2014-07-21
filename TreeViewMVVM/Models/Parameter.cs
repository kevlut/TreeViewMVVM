using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVM.Models
{
    public class Parameter
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string AdditionalInfo { get; set; }

        public Parameter(string name, int value, string additionalInfo)
        {
            Name = name;
            Value = value;
            AdditionalInfo = additionalInfo;
        }

        public override string ToString()
        {
            return "Name= " + Name + ", Value= " + Value + ", AdditionalInfo= " + AdditionalInfo;
        }
    }
}
