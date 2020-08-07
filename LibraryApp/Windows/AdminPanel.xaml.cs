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
        private Manager _selectedManager;

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
            if (CheckUniqueMail(manager.Email))
            {
                MessageBox.Show("E-poçt ünvani ilə hesab mövcuddur");
                return;
            };
            _libraryContext.Managers.Add(manager);
            _libraryContext.SaveChanges();

            Reset();

            MessageBox.Show("İdarəçi əlavə olundu");
        }
        
        private void DgManagers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgManagers.SelectedItem == null) return;

            _selectedManager = (Manager)DgManagers.SelectedItem;

            TxtName.Text = _selectedManager.Name;
            TxtSurname.Text = _selectedManager.Surname;
            TxtEmail.Text = _selectedManager.Email;
            TxtPassword.Text = _selectedManager.Password;
            TxtPhoneNumber.Text = _selectedManager.PhoneNumber;

            BtnCreate.Visibility = Visibility.Hidden;
            BtnUpdate.Visibility = Visibility.Visible;
            BtnDelete.Visibility = Visibility.Visible;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz?", _selectedManager.ToString(), MessageBoxButton.OKCancel);

            if (r == MessageBoxResult.OK)
            {
                _libraryContext.Managers.Remove(_selectedManager);
                _libraryContext.SaveChanges();

                Reset();

                MessageBox.Show("İdarəçi silindi");
            }
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                return;
            }

            _selectedManager.Name = TxtName.Text;
            _selectedManager.Surname = TxtSurname.Text;
            _selectedManager.Email = TxtEmail.Text;
            _selectedManager.Password = TxtPassword.Text;
            _selectedManager.PhoneNumber = TxtPhoneNumber.Text;

            _libraryContext.SaveChanges();

            Reset();

            MessageBox.Show("İdarəçi məlumatları yeniləndi");
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

            BtnCreate.Visibility = Visibility.Visible;
            BtnUpdate.Visibility = Visibility.Hidden;
            BtnDelete.Visibility = Visibility.Hidden;


            FillManagers();
        }

        //Veiw Managers in Datagrids
        private void FillManagers()
        {
            DgManagers.ItemsSource = _libraryContext.Managers.ToList();
        }
        
        // Cheac Unique Mail
        private bool CheckUniqueMail(string email)
        {
            var model = _libraryContext.Managers.FirstOrDefault(m => m.Email == email);
            if (model != null)
            {
                return true;
            }
            return false;
        }
        
    }
}
