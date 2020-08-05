using LibraryApp.Data;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        private readonly LibraryContext _libraryContext;
        public AdminPanel()
        {
            InitializeComponent();

            _libraryContext = new LibraryContext();
            FillManagers();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                return;
            }

            Manager manager = new Manager
            {
                Email = TxtEmail.Text,
                Password = TxtPassword.Text,
                Name = TxtName.Text,
                Surname = TxtSurname.Text,
                PhoneNumber = TxtPhoneNumber.Text
            };

            _libraryContext.Managers.Add(manager);

            _libraryContext.SaveChanges();

            Reset();

            MessageBox.Show("İdarəçi əlavə olundu");
        }

        // Checking the values that come from textbox
        private bool FormValidation()
        {
            bool hasError = false;
            bool success = int.TryParse(TxtPhoneNumber.Text, out _);
            if (string.IsNullOrEmpty(TxtEmail.Text) || string.IsNullOrEmpty(TxtPassword.Text) || string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtSurname.Text) || string.IsNullOrEmpty(TxtPhoneNumber.Text))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun");
                hasError = true;
            }
            else if (!Regex.IsMatch(TxtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("E-poçt ünvani düzgün yazın");
                TxtEmail.Select(0, TxtEmail.Text.Length);
                TxtEmail.Focus();
                hasError = true;
            } 
            else if (!success)
            {
                MessageBox.Show("Nömrəni düzgün daxil edin");
                TxtPhoneNumber.Select(0, TxtPhoneNumber.Text.Length);
                TxtPhoneNumber.Focus();
                hasError = true;
            }

            return hasError;
        }
  
        // TextBox Reset
        private void Reset()
        {
            TxtEmail.Clear();
            TxtName.Clear();
            TxtPassword.Clear();
            TxtPhoneNumber.Clear();
            TxtSurname.Clear();

            FillManagers();
        }

        //Veiw Managers in Datagrids
        private void FillManagers()
        {
            DgManagers.ItemsSource = _libraryContext.Managers.ToList();
        }
    }
}
