﻿using System;
using System.Collections.Generic;
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
        public LoginWindow()
        {
            InitializeComponent();
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

            //Manager login
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
            else
            {
                DashboardWindow dashboard = new DashboardWindow();
                dashboard.Show();
                this.Close();
            }
        }
    }
}