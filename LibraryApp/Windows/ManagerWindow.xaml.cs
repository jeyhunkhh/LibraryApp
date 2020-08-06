using LibraryApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibraryApp.Windows
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        public ManagerWindow()
        {
            InitializeComponent();

            _libraryContext = new LibraryContext();

            DgManagersView.ItemsSource = _libraryContext.Managers.ToList();
        }

        
    }
}
