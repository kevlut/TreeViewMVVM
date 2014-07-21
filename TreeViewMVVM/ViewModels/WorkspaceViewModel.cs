using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVM.ViewModels
{
    public class WorkspaceViewModel : TVViewModel
    {
        private Models.Workspace _workspace;
        public WorkspaceViewModel(Models.Workspace workspace)
        {
            _workspace = workspace ?? new Models.Workspace(workspaceName: "default");

            Items = new ObservableCollection<Base.WorkspaceItem>(
                workspace.Devices.Cast<Base.WorkspaceItem>().Concat(
                workspace.Folders.Cast<Base.WorkspaceItem>().Concat(
                workspace.Hardwares.Cast<Base.WorkspaceItem>())));

            Items.CollectionChanged += Items_CollectionChanged;
        }

        public ObservableCollection<Base.WorkspaceItem> Items
        {
            get;
            private set;
        }

        public string Header
        {
            get
            {
                return _workspace.Header;
            }
            set
            {
                if (_workspace.Header != value)
                {
                    _workspace.Header = value;
                    NotifyPropertyChanged("Header");
                }
            }
        }

        void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    foreach (object item in e.NewItems)
                    {
                        if (item is Base.WorkspaceItem)
                        {
                            _workspace.Add(item as Base.WorkspaceItem);
                        }
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    foreach (object item in e.OldItems)
                    {
                        if (item is Base.WorkspaceItem)
                        {
                            _workspace.Remove(item as Base.WorkspaceItem);
                        }
                    }
                    break;
            }
        }
    }
}
