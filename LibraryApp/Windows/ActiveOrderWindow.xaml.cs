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
    /// Interaction logic for ActiveOrderWindow.xaml
    /// </summary>
    public partial class ActiveOrderWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        private Order _selectedOrder;

        public ActiveOrderWindow()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
            FillOrders();
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

            var model = _libraryContext.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            TbBooks.Text = string.Empty;

            foreach (var item in model)
            {
               TbBooks.Text += "Kitab adı : " + item.Book.Name + "  " + "Yazar : " + item.Book.Author + "  " + Environment.NewLine;
            }
            
        }
    }
}
