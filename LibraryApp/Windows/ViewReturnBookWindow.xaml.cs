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
    /// Interaction logic for ViewReturnBookWindow.xaml
    /// </summary>
    public partial class ViewReturnBookWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        private Order _selectedOrder;
        
        public ViewReturnBookWindow()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
            FillToday();
            FillTomorrow();
            FillLate();
        }

        //Veiw Today Orders in Datagrids
        private void FillToday()
        {
            DgvTodayReturn.ItemsSource = _libraryContext.Orders.Where(x => x.Status == true && x.Deadline == DateTime.Today).Include(x => x.Customer).ToList();
        }

        // Selected Today Order view Books in Order
        private void DgvTodayReturn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvTodayReturn.SelectedItem == null) return;

            _selectedOrder = (Order)DgvTodayReturn.SelectedItem;

            var model = _libraryContext.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            TbTotayBooks.Text = string.Empty;

            foreach (var item in model)
            {
                TbTotayBooks.Text += "Kitab adı : " + item.Book.Name + "  " + "Yazar : " + item.Book.Author + "  " + Environment.NewLine;
            }
         }

        //Veiw Tomorrow Orders in Datagrids
        private void FillTomorrow()
        {
            DgvTomorrowReturn.ItemsSource = _libraryContext.Orders.Where(x => x.Status == true && x.Deadline == DateTime.Today.AddDays(1)).Include(x => x.Customer).ToList();
        }

        // Selected Tomorrow Order view Books in Order
        private void DgvTomorrowReturn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvTomorrowReturn.SelectedItem == null) return;

            _selectedOrder = (Order)DgvTomorrowReturn.SelectedItem;

            var model = _libraryContext.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            TbTomorrowBooks.Text = string.Empty;

            foreach (var item in model)
            {
                TbTomorrowBooks.Text += "Kitab adı : " + item.Book.Name + "  " + "Yazar : " + item.Book.Author + "  " + Environment.NewLine;
            }
        }

        //Veiw Late Orders in Datagrids
        private void FillLate()
        {
            DgvLateReturn.ItemsSource = _libraryContext.Orders.Where(x => x.Status == true && x.Deadline < DateTime.Today).Include(x => x.Customer).ToList();
        }

        // Selected Late Order view Books in Order
        private void DgvLateReturn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvLateReturn.SelectedItem == null) return;

            _selectedOrder = (Order)DgvLateReturn.SelectedItem;

            var model = _libraryContext.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            TbLaleBooks.Text = string.Empty;

            foreach (var item in model)
            {
                TbLaleBooks.Text += "Kitab adı : " + item.Book.Name + "  " + "Yazar : " + item.Book.Author + "  " + Environment.NewLine;
            }
        }

        private void BtnTodayReturn_Click(object sender, RoutedEventArgs e)
        {
            if (gridToday.Visibility == Visibility.Visible) return;

            gridToday.Visibility = Visibility.Visible;
            gridLate.Visibility = Visibility.Hidden;
            gridTomorrow.Visibility = Visibility.Hidden;
        }

        private void BtnTomorrowReturn_Click(object sender, RoutedEventArgs e)
        {
            if (gridTomorrow.Visibility == Visibility.Visible) return;

            gridTomorrow.Visibility = Visibility.Visible;
            gridLate.Visibility = Visibility.Hidden;
            gridToday.Visibility = Visibility.Hidden;
        }

        private void BtnLateReturn_Click(object sender, RoutedEventArgs e)
        {
            if (gridLate.Visibility == Visibility.Visible) return;

            gridLate.Visibility = Visibility.Visible;
            gridTomorrow.Visibility = Visibility.Hidden;
            gridToday.Visibility = Visibility.Hidden;
        }
    }
}
