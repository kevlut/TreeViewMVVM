using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVM.Models
{
    public class Device : Base.WorkspaceItem, Interfaces.IDevice
    {
        public Device()
        {
            Parameters = new List<Parameter>() { 
                new Parameter("A", 0, "A Stuff"),
                new Parameter("B", 1, "B Stuff"),
                new Parameter("C", 2, "C Stuff"),
                new Parameter("D", 3, "D Stuff"),
                new Parameter("E", 4, "E Stuff"),
                new Parameter("F", 5, "F Stuff")};
        }

        public List<Parameter> Parameters { get; set; }
    }
}
