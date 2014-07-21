using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVM.Base
{
    public class WorkspaceItem
    {
        public string Header { get; set; }
        public virtual ObservableCollection<WorkspaceItem> Items { get; set; }

        public WorkspaceItem()
        {
            Items = new ObservableCollection<WorkspaceItem>();
        }
    }
}
