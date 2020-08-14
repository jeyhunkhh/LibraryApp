using ClosedXML.Excel;
using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LibraryApp.Windows
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        private Order _selectedOrder;
        public ReportWindow()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();
        }

        //Veiw Orders in Datagrids
        private void FillOrder()
        {
            DgvFullOrders.ItemsSource = _libraryContext.Orders.Where(x => x.CreatedAt >= DtpStart.SelectedDate && x.Deadline <= DtpEnd.SelectedDate || (x.ReturnDate >=DtpStart.SelectedDate  && x.ReturnDate <= DtpEnd.SelectedDate)).Include(x=> x.Customer).ToList();
        }

        // Search Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DtpEnd.SelectedDate == null || DtpStart.SelectedDate == null)
            {
                MessageBox.Show("Tarix seçin");
            }
            FillOrder();
        }

        // Selected Order view Books in Order
        private void DgvFullOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgvFullOrders.SelectedItem == null) return;

            _selectedOrder = (Order)DgvFullOrders.SelectedItem;

            var model = _libraryContext.OrderItems.Where(x => x.OrderId == _selectedOrder.Id).Include(m => m.Book);

            TbBooks.Text = string.Empty;

            foreach (var item in model)
            {
                TbBooks.Text += "Kitab adı : " + item.Book.Name + "  " + "Yazar : " + item.Book.Author + "  " + Environment.NewLine;
            }
        }

        // Excele Export 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files|*.xlsx",
                Title = "Save an Excel File"
            };
            saveFileDialog.ShowDialog();

            List<Order> orders;

            orders = _libraryContext.Orders.Where(x => x.CreatedAt >= DtpStart.SelectedDate && x.Deadline <= DtpEnd.SelectedDate || (x.ReturnDate >= DtpStart.SelectedDate && x.ReturnDate <= DtpEnd.SelectedDate)).Include(x => x.Customer).ToList();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Contacts");

                worksheet.Cell("A1").SetValue("Id");
                worksheet.Cell("B1").SetValue("Ad Soyad");
                worksheet.Cell("C1").SetValue("Nömrə");
                worksheet.Cell("D1").SetValue("Başlama tarixi");
                worksheet.Cell("E1").SetValue("Bitmə tarixi");
                worksheet.Cell("F1").SetValue("Qaytarma tarixi");
                worksheet.Cell("G1").SetValue("Ödəniş");
                worksheet.Cell("H1").SetValue("Cərimə");

                worksheet.Cell("A1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("B1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("C1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("D1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("E1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("F1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("G1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));
                worksheet.Cell("H1").Style.Fill.SetBackgroundColor(XLColor.FromArgb(52, 168, 83));

                worksheet.Cell("A1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("B1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("C1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("D1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("E1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("F1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("G1").Style.Font.SetFontColor(XLColor.White);
                worksheet.Cell("H1").Style.Font.SetFontColor(XLColor.White);

                int row = 2;

                foreach (Order order in orders)
                {
                    worksheet.Cell("A" + row).Value = order.Id;
                    worksheet.Cell("B" + row).Value = order.Customer.FullName;
                    worksheet.Cell("C" + row).Value = order.Customer.PhoneNumber;
                    worksheet.Cell("D" + row).Value = order.CreatedAt;
                    worksheet.Cell("E" + row).Value = order.Deadline;
                    worksheet.Cell("F" + row).Value = order.ReturnDate;
                    worksheet.Cell("G" + row).Value = order.OrderPrice;
                    worksheet.Cell("H" + row).Value = order.FinePrice;

                    row++;
                }

                if (!String.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                }
                    

            }
            }
        }
}
