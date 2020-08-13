using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for ReturnBooksWindow.xaml
    /// </summary>
    public partial class ReturnBooksWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        private Order _selectedOrder;

        public ReturnBooksWindow()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
            FillOrders();
            FinePrice();
        }

        private void FillOrders()
        {
            DgvOrders.ItemsSource = _libraryContext.Orders.Where(x => x.Status == true).Include(x => x.Customer).ToList();
        }

        private void TxtCustomerSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var filtered = _libraryContext.Orders.Where(m => m.Customer.Name.StartsWith(TxtCustomerSearch.Text) && m.Status == true);

            DgvOrders.ItemsSource = filtered.ToList();
        }

        private void DgvOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvOrders.SelectedItem == null) return;

            _selectedOrder = (Order)DgvOrders.SelectedItem;

            var book = _libraryContext.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            TbBooks.Text = string.Empty;

            foreach (var item in book)
            {
                TbBooks.Text += "Kitab adı : " + item.Book.Name + "  " + "Yazar : " + item.Book.Author + "  " + Environment.NewLine;
            }
        }

        private void BtnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            var bookCount = _libraryContext.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            foreach (var item in bookCount)
            {
                item.Book.Count += 1;
            }

            _selectedOrder.Status = false;
            _selectedOrder.ReturnDate = DateTime.Now;

            _libraryContext.SaveChanges();

            FillOrders();

            if (_selectedOrder.FinePrice > 0)
            {
                MessageBox.Show("Kitab qaytarildi." + Environment.NewLine + $"Cərimə məbləgi : {_selectedOrder.FinePrice} manat");
            }
            else
            {
                MessageBox.Show("Kitab qaytarildi.");
            }
            
        }

        private void FinePrice()
        {
            var fine = _libraryContext.Orders.Where(x => x.Status == true);
            
            foreach (var item in fine)
            {
                var day = (item.Deadline - DateTime.Now).Days;
                if (day < 0)
                {
                    item.FinePrice =  (-day);
                }
                
            }
        }
    }
}
