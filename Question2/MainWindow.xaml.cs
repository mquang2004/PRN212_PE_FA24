using Question2.Models;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Reflection.Metadata.BlobBuilder;

namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PePrn24fallB1Context context = new PePrn24fallB1Context();
        public MainWindow()
        {
            InitializeComponent();
            LoadGridView();
        }

        public void LoadGridView()
        {
            var bookList = context.Books.Select(b => new
            {
                Id = b.BookId,
                Title = b.Title,
                Publisher = b.Publisher,
                PublicationYear = b.PublicationYear,
            }).ToList();
            BookDataGrid.ItemsSource = bookList;
        }

        private void BookDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = BookDataGrid.SelectedItem as dynamic;
            if (selectedItem != null)
            {
                tbBookId.Text = selectedItem.Id.ToString();
                tbTilte.Text = selectedItem.Title.ToString();
                tbPublisher.Text = selectedItem.Publisher.ToString();
                tbPubYear.Text = selectedItem.PublicationYear.ToString();
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            var editBook = context.Books.FirstOrDefault(s => s.BookId == int.Parse(tbBookId.Text));
            while (tbTilte.Text == null || tbPublisher.Text == null || tbPubYear.Text == null) {
                editBook.Title = tbTilte.Text;
                editBook.Publisher = tbPublisher.Text;
                editBook.PublicationYear = int.Parse(tbPubYear.Text);
            }

            context.SaveChanges();
            LoadGridView();
        }

        private void tbSearchTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            var searchTitle = tbSearchTitle.Text;
            var searchPublisher = tbSearchPublisher.Text;
            var bookList = context.Books.Select(b => new
            {
                Id = b.BookId,
                Title = b.Title,
                Publisher = b.Publisher,
                PublicationYear = b.PublicationYear,
            }).ToList().Where(b => b.Title.Contains(searchTitle) || b.Publisher.Contains(searchPublisher));
            BookDataGrid.ItemsSource = bookList;
        }
    }
}