using LibraryApp.Data;
using System.Linq;
using System.Windows;

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

            //Veiw Managers in Datagrids
            DgManagersView.ItemsSource = _libraryContext.Managers.ToList();
        }

        
    }
}
