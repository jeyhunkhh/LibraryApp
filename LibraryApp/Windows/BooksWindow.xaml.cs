using LibraryApp.Data;
using LibraryApp.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LibraryApp.Windows
{
    /// <summary>
    /// Interaction logic for BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        private readonly LibraryContext _libraryContext;
        private Book _selectedBook;
        public BooksWindow()
        {
            InitializeComponent();

            _libraryContext = new LibraryContext();

            FillBooks();
        }

        // Selecred Book CRUD
        private void DgBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DgBooks.SelectedItem == null) return;

            _selectedBook = (Book)DgBooks.SelectedItem;

            TxtBookName.Text = _selectedBook.Name;
            TxtBookAuthor.Text = _selectedBook.Author;
            TxtBookPrice.Text = Convert.ToString(_selectedBook.WeekPrice);
            TxtBookCount.Text = Convert.ToString(_selectedBook.Count);
            TxtBookShelf.Text = Convert.ToString(_selectedBook.BookShelf);

            BtnBookCreate.Visibility = Visibility.Hidden;
            BtnBookUpdate.Visibility = Visibility.Visible;
            BtnBookDelete.Visibility = Visibility.Visible;
        }

        private void BtnBookCreate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation()) return;
            
            Book book = new Book
            {
                Name = TxtBookName.Text,
                Author = TxtBookAuthor.Text,
                WeekPrice = Convert.ToDecimal(TxtBookPrice.Text),
                Count = Convert.ToInt32(TxtBookCount.Text),
                BookShelf = Convert.ToInt32(TxtBookShelf.Text)
            };

            _libraryContext.Books.Add(book);

            _libraryContext.SaveChanges();

            Reset();

            MessageBox.Show("Kitab əlavə olundu");
        }

        private void BtnBookDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Silməyə əminsiniz?", _selectedBook.ToString(), MessageBoxButton.OKCancel);

            if (r == MessageBoxResult.OK)
            {
                _libraryContext.Books.Remove(_selectedBook);
                _libraryContext.SaveChanges();

                Reset();

                MessageBox.Show("Kitab silindi");
            }
        }

        private void BtnBookUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation()) return;

            _selectedBook.Name = TxtBookName.Text;
            _selectedBook.Author = TxtBookAuthor.Text;
            _selectedBook.WeekPrice = Convert.ToDecimal(TxtBookPrice.Text);
            _selectedBook.Count = Convert.ToInt32(TxtBookCount.Text);
            _selectedBook.BookShelf = Convert.ToInt32(TxtBookShelf.Text);

            _libraryContext.SaveChanges();

            Reset();

            MessageBox.Show("Kitab məlumatı yeniləndi");

        }


        //Veiw Books in Datagrids
        private void FillBooks()
        {
            DgBooks.ItemsSource = _libraryContext.Books.ToList();
        }

        // TextBox Reset
        private void Reset()
        {
            TxtBookName.Clear();
            TxtBookAuthor.Clear();
            TxtBookCount.Clear();
            TxtBookPrice.Clear();
            TxtBookShelf.Clear();

            BtnBookCreate.Visibility = Visibility.Visible;
            BtnBookDelete.Visibility = Visibility.Hidden;
            BtnBookUpdate.Visibility = Visibility.Hidden;

            FillBooks();
        }

        // Checking the values that come from textbox
        private bool FormValidation()
        {
            bool hasError = false;
            if (string.IsNullOrEmpty(TxtBookName.Text) || string.IsNullOrEmpty(TxtBookAuthor.Text) || string.IsNullOrEmpty(TxtBookPrice.Text) || string.IsNullOrEmpty(TxtBookCount.Text) || string.IsNullOrEmpty(TxtBookShelf.Text))
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun");
                hasError = true;
            }
            else if (!decimal.TryParse(TxtBookPrice.Text.ToString(), out _))
            {
                MessageBox.Show("Qiyməti düzgün yazın");
                hasError = true;
            }
            else if (!int.TryParse(TxtBookCount.Text.ToString(), out _))
            {
                MessageBox.Show("Kitab sayını düzgün yazın");
                hasError = true;
            }
            else if (!int.TryParse(TxtBookShelf.Text.ToString(), out _))
            {
                MessageBox.Show("Dolabın nömrəsini düzgün yazın");
                hasError = true;
            }
            
            return hasError;
        }

    }
}
