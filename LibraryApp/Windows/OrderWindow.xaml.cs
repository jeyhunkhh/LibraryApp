using LibraryApp.Data;
using LibraryApp.Migrations;
using LibraryApp.Models;
using MaterialDesignThemes.Wpf;
using Microsoft.VisualBasic;
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
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        private Book _selectedBook;
        private Customer _selectedCustomer;
        public List<Book> books;
        
        public OrderWindow()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
            books = new List<Book>();
            FillBooks();
            FillCustomers();
        }

        private void FillBooks()
        {
            DgvBooks.ItemsSource = _libraryContext.Books.ToList();
        }

        private void FillCustomers()
        {
            DgvCustomers.ItemsSource = _libraryContext.Customers.ToList();
        }

        private void DgvBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvBooks.SelectedItem == null) return;

            _selectedBook = (Book)DgvBooks.SelectedItem;

            if (_selectedBook.Count == 0)
            {
                MessageBox.Show("Bu kitab hal hazirda bitib");
                return;
            }
            else
            {
                _selectedBook.Count -= 1;
                FillBooks();
            }

            var selected = (books.FirstOrDefault(x => x.Id == _selectedBook.Id));

            if (selected != null)
            {
                MessageBox.Show("Bir kitabdan yaniz 1 eded ala bilersiz");
                return;
            }

            books.Add(_selectedBook);
            TbSelectedBook.Text = string.Empty;

            foreach (var item in books)
            {
                TbSelectedBook.Text += "Kitab adı : " + item.Name + "  " + "Yazar : " + item.Author + "  " + Environment.NewLine;
            }


        }

        private void DgvCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvCustomers.SelectedItem == null) return;

            _selectedCustomer = (Customer)DgvCustomers.SelectedItem;

            TxtSearchCustomers.Text = _selectedCustomer.FullName;
        }

        // Search Box Book
        private void TxtBookSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var filtered = _libraryContext.Books.Where(m => m.Name.StartsWith(TxtBookSearch.Text));

            DgvBooks.ItemsSource = filtered.ToList();
        }

        // Search Box Book
        private void TxtSearchCustomers_KeyUp(object sender, KeyEventArgs e)
        {
            var filtered = _libraryContext.Customers.Where(m => m.Name.StartsWith(TxtSearchCustomers.Text));

            DgvCustomers.ItemsSource = filtered.ToList();
        }

        // Reset
        private void Reset()
        {
            TxtBookSearch.Clear();
            TxtSearchCustomers.Clear();
            DtpCreateDate.SelectedDate = null;
            DtpDeadline.SelectedDate = null;
            TbSelectedBook.Text = string.Empty;
            DgvCustomers.SelectedItem = null;
            DgvBooks.SelectedItem = null;
        }

        private void BtnOrderCreate_Click(object sender, RoutedEventArgs e)
        {
            if(DgvCustomers.SelectedItem == null)
            {
                MessageBox.Show("Müştəri seçin!");
                return;
            }
            else if (DgvBooks.SelectedItem == null)
            {
                MessageBox.Show("Kitab seçin!");
                return;
            }
            else if(DtpDeadline.SelectedDate == null)
            {
                MessageBox.Show("Kitabı qaytarma tarixini seçin");
                return;
            }
            else if (DtpCreateDate.SelectedDate == null)
            {
                DtpCreateDate.SelectedDate = DateTime.Now.Date;
            }

            double day = (((DateTime)DtpDeadline.SelectedDate - (DateTime)DtpCreateDate.SelectedDate).Days)/7.0;

            var week = Math.Ceiling(day);
            decimal price = 0;
            
            foreach (var item in books)
            {
                price += item.WeekPrice;
            }

            decimal orderPrice = Convert.ToDecimal(week) * price;

            Order order = new Order
            {
                CustomerId = _selectedCustomer.Id,
                CreatedAt = (DateTime)DtpCreateDate.SelectedDate,
                Deadline = (DateTime)DtpDeadline.SelectedDate,
                OrderPrice = orderPrice,
                Status = true
            };
            
            
            _libraryContext.Orders.Add(order);
            _libraryContext.SaveChanges();

            foreach (var item in books)
            {
                OrderItem orderItem = new OrderItem
                {
                    BookId = item.Id,
                    OrderId = order.Id
                };
                
                _libraryContext.OrderItems.Add(orderItem);
                _libraryContext.SaveChanges();
            }

            books.Clear();
            Reset();

            MessageBox.Show("Sifarış elavə olundu." + Environment.NewLine +
                "Toplam : " + orderPrice.ToString("0.00") + " manat");
        }

        private void BtnOrderView_Click(object sender, RoutedEventArgs e)
        {
            ActiveOrderWindow activeOrderWindow = new ActiveOrderWindow();
            activeOrderWindow.ShowDialog();
        }
    }
}
