using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using World_of_Books_.Database;

namespace World_of_Books_.UI
{
    /// <summary>
    /// Логика взаимодействия для Page_Stock.xaml
    /// </summary>
    public partial class Page_Stock : Page
    {
        public Page_Stock()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var data = DB_WOB.GetContext();
            var inf_book = from book in data.Book
                           select new { book.Title, book.QuantityInStock };
            DGBook.ItemsSource = inf_book.ToList();
        }
        private void search_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            var data = DB_WOB.GetContext().Book.ToList();
            if (search_box.Text != null)
            {
                data = data.Where(currentName => currentName.Title.ToLower().Contains(search_box.Text.ToLower())).ToList();
            }
            if (data.Count > 0)
            {
                DGBook.ItemsSource = data;
                textBlock_NotFound.Visibility = Visibility.Collapsed;
            }
            else
            {
                DGBook.ItemsSource = null;
                textBlock_NotFound.Visibility = Visibility.Visible;
            }
        }

        private void inStock_Checked(object sender, RoutedEventArgs e)
        {
            var data = DB_WOB.GetContext().Book.ToList();
            var qty_inStock = data.Where(qty => qty.QuantityInStock != null);
            if (inStock.IsChecked == true)
            {
                data = qty_inStock.ToList();
            }
            if (data.Count > 0)
            { 
                DGBook.ItemsSource = data;
                textBlock_NotFound.Visibility = Visibility.Collapsed;
            }
            else
            {
                DGBook.ItemsSource = null;
                textBlock_NotFound.Visibility = Visibility.Visible;
            }
        }

        private void allBook_Checked(object sender, RoutedEventArgs e)
        {
            var data = DB_WOB.GetContext().Book.ToList();
            DGBook.ItemsSource = data;
        }
        public void RadioButton_Check()
        {
            var data = DB_WOB.GetContext();
            if(allBook.IsChecked == true)
            {
                DGBook.ItemsSource = data.Book.ToList();
            }
            else if(inStock.IsChecked == true)
            {
            }
        }
    }
}
