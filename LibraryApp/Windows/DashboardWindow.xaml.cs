using System.Windows;

namespace LibraryApp.Windows
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
        }

        private void BtnManager_Click(object sender, RoutedEventArgs e)
        {
            ManagerWindow managerWindow = new ManagerWindow();

            managerWindow.ShowDialog();
        }

        private void BtnBook_Click(object sender, RoutedEventArgs e)
        {
            BooksWindow booksWindow = new BooksWindow();
            booksWindow.ShowDialog();
        }

        private void BtnCustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomersWindow customersWindow = new CustomersWindow();
            customersWindow.ShowDialog();
        }

        private void BtnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.ShowDialog();
        }

        private void BtnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            ReturnBooksWindow returnBooksWindow = new ReturnBooksWindow();
            returnBooksWindow.ShowDialog();
        }

        private void BtnReturnBookFollow_Click(object sender, RoutedEventArgs e)
        {
            ViewReturnBookWindow viewReturnBookWindow = new ViewReturnBookWindow();
            viewReturnBookWindow.ShowDialog();
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.ShowDialog();
        }
    }
}
