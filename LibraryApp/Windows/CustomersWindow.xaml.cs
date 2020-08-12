using LibraryApp.Data;
using LibraryApp.Models;
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
    /// Interaction logic for CustomersWindow.xaml
    /// </summary>
    public partial class CustomersWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        private Customer _selectedCustomer;

        public CustomersWindow()
        {
            InitializeComponent();

            _libraryContext = new LibraryContext();

            FillCustomers();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation()) return;
            Customer customer = new Customer
            {
                Name = TxtCustomerName.Text,
                Surname = TxtCustomerSurname.Text,
                PhoneNumber = TxtCustomerPhone.Text,
                Birthday = (DateTime)DtpBirthday.SelectedDate
            };

            _libraryContext.Customers.Add(customer);
            _libraryContext.SaveChanges();

            Reset();

            MessageBox.Show("Müştəri əlavə olundu");
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation()) return;

            _selectedCustomer.Name = TxtCustomerName.Text;
            _selectedCustomer.Surname = TxtCustomerSurname.Text;
            _selectedCustomer.PhoneNumber = TxtCustomerPhone.Text;
            _selectedCustomer.Birthday = (DateTime) DtpBirthday.SelectedDate;

            _libraryContext.SaveChanges();

            Reset();

            MessageBox.Show("Müştərinin məlumatları yeniləndi");
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz?", _selectedCustomer.ToString(), MessageBoxButton.OKCancel);

            if (r == MessageBoxResult.OK) {

                _libraryContext.Customers.Remove(_selectedCustomer);
                _libraryContext.SaveChanges();

                Reset();

                MessageBox.Show("Müştəri silindi");
            }
        }

        private void DgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgCustomers.SelectedItem == null) return;

            _selectedCustomer = (Customer)DgCustomers.SelectedItem;

            TxtCustomerName.Text = _selectedCustomer.Name;
            TxtCustomerPhone.Text = _selectedCustomer.PhoneNumber;
            TxtCustomerSurname.Text = _selectedCustomer.Surname;
            DtpBirthday.SelectedDate = _selectedCustomer.Birthday;

            BtnCreate.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
        }

        private void FillCustomers()
        {
            DgCustomers.ItemsSource = _libraryContext.Customers.ToList();
        }

        // TextBox Reset
        private void Reset()
        {
            TxtCustomerName.Clear();
            TxtCustomerPhone.Clear();
            TxtCustomerSurname.Clear();
            DtpBirthday.SelectedDate = null;

            BtnCreate.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;

            FillCustomers();
        }

        // Checking the values that come from textbox
        private bool FormValidation()
        {
            bool hasError = false;

            bool success = int.TryParse(TxtCustomerPhone.Text, out _);
            if (string.IsNullOrEmpty(TxtCustomerName.Text) || string.IsNullOrEmpty(TxtCustomerPhone.Text) || string.IsNullOrEmpty(TxtCustomerSurname.Text) || DtpBirthday.SelectedDate == null)
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun");
                hasError = true;
            }
            else if (!success)
            {
                MessageBox.Show("Nömrəni düzgün daxil edin");
                TxtCustomerPhone.Select(0, TxtCustomerPhone.Text.Length);
                TxtCustomerPhone.Focus();
                hasError = true;
            }

            return hasError;
        }

        
    }
}
