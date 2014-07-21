using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewMVVM.Models
{
    // A Workspace can have Devices, Folders, and Products
    public class Workspace : Base.WorkspaceItem
    {
        public Workspace(string workspaceName,
                         IEnumerable<Interfaces.IDevice> devices = null,
                         IEnumerable<Interfaces.IFolder> folders = null,
                         IEnumerable<Interfaces.IHardware> hardwares = null)
        {
            Devices = new ObservableCollection<Interfaces.IDevice>(devices ?? Enumerable.Empty<Interfaces.IDevice>());
            Folders = new ObservableCollection<Interfaces.IFolder>(folders ?? Enumerable.Empty<Interfaces.IFolder>());
            Hardwares = new ObservableCollection<Interfaces.IHardware>(hardwares ?? Enumerable.Empty<Interfaces.IHardware>());

            Header = workspaceName;
        }

        public ObservableCollection<Interfaces.IDevice> Devices { get; private set; }
        public ObservableCollection<Interfaces.IFolder> Folders { get; private set; }
        public ObservableCollection<Interfaces.IHardware> Hardwares { get; private set; }

        public void Add(Base.WorkspaceItem item)
        {
            if (item is Interfaces.IDevice)
            {
                Devices.Add(item as Interfaces.IDevice);
            }
            else if (item is Interfaces.IFolder)
            {
                Folders.Add(item as Interfaces.IFolder);
            }
            else if (item is Interfaces.IHardware)
            {
                Hardwares.Add(item as Interfaces.IHardware);
            }
        }

        public void Remove(Base.WorkspaceItem item)
        {
            if (item is Interfaces.IDevice)
            {
                Devices.Remove(item as Interfaces.IDevice);
            }
            else if (item is Interfaces.IFolder)
            {
                Folders.Remove(item as Interfaces.IFolder);
            }
            else if (item is Interfaces.IHardware)
            {
                Hardwares.Remove(item as Interfaces.IHardware);
            }
        }
    }
}
