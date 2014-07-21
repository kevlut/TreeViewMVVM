using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVM.ViewModels
{
    public class MainWindowViewModel : ViewModels.ViewModel
    {
        private object _selectedItem;
        public MainWindowViewModel()
        {
            Workspaces = new ObservableCollection<WorkspaceViewModel>();

            Workspaces.Add(new WorkspaceViewModel(new Models.Workspace(workspaceName: "Main Workspace")));
        }

        public ObservableCollection<WorkspaceViewModel> Workspaces { get; private set; }
        public object SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if(_selectedItem != value)
                {
                    _selectedItem = value;
                    NotifyPropertyChanged("SelectedItem");
                }
            }
        }
    }
}
