using LibraryApp.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly LibraryContext _libraryContext;

        public LoginWindow()
        {
            InitializeComponent();

            _libraryContext = new LibraryContext();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            //Admin login
            if(TxtEmail.Text == "admin" && TxtPassword.Password == "12345")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
                TxtEmail.Clear();
                TxtPassword.Clear();
                return;
            }

            //Manager login Database
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("E-poçt ünvani boş ola bilməz");
                return;
            }
            else if (!Regex.IsMatch(TxtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("E-poçt ünvani düzgün yazın");
                TxtEmail.Select(0, TxtEmail.Text.Length);
                TxtEmail.Focus();
                return;
            } 
            else if (string.IsNullOrEmpty(TxtPassword.Password))
            {
                MessageBox.Show("Şifrə boş ola bilməz");
                return;
            }

            var modelEmail = _libraryContext.Managers.FirstOrDefault(m => m.Email == TxtEmail.Text);
            
            
            if(modelEmail == null || modelEmail.Password != TxtPassword.Password)
            {
                MessageBox.Show("E-poçt ünvani və ya Şifrə yanlışdır");
                return;
            }
            else 
            {
                DashboardWindow dashboard = new DashboardWindow();
                dashboard.Show();
                this.Close();
            }
        }
    }
}
