using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeViewMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModels.MainWindowViewModel mwvm;
        public MainWindow()
        {
            InitializeComponent();

            mwvm = new ViewModels.MainWindowViewModel();
            this.DataContext = mwvm;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue != null)
            {
                mwvm.SelectedItem = e.NewValue;
            }
        }
        int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(i % 4 == 0)
            {
                mwvm.Workspaces.First().Items.Add(new Models.Device() { Header = "Device " + i });
            }
            else if (i % 2 == 0)
            {
                mwvm.Workspaces.First().Items.Add(new Models.Folder() { Header = "Folder " + i });
            }
            else if (i % 3 == 0)
            {
                mwvm.Workspaces.First().Items.Add(new Models.Hardware() { Header = "Hardware " + i });
            }
            mwvm.Workspaces.First().Items[0].Items.Add(new Models.Folder() { Header = "Folder " + i });
            i++;
        }
    }
}
