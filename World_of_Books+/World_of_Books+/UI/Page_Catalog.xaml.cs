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
using World_of_Books_.Class;
using World_of_Books_.Database;


namespace World_of_Books_.UI
{
    /// <summary>
    /// Логика взаимодействия для Page_Catalog.xaml
    /// </summary>
    public partial class Page_Catalog : Page
    {
        public Page_Catalog()
        {
            InitializeComponent();
            var data = DB_WOB.GetContext();

            List<UserControl_Catalog> catalogs = new List<UserControl_Catalog>();
            data.Book.ToList().ForEach(item => catalogs.Add(new UserControl_Catalog()));
            bookList.ItemsSource = catalogs;

            List<string> authors = new List<string>();
            authors.Add("Все");
            data.Author.ToList().ForEach(item => authors.Add(item.Name));
            comboBoxAuthor.ItemsSource = authors;
            comboBoxAuthor.SelectedItem = "Все";

            List<string> categories = new List<string>();
            categories.Add("Все");
            data.Category.ToList().ForEach(item => categories.Add(item.Category1));
            comboBoxCategory.ItemsSource = categories;
            comboBoxCategory.SelectedItem = "Все";
        }
        private void textBoxYearOfPublishing_TextChanged(object sender, TextChangedEventArgs e)
        {
            var data = DB_WOB.GetContext().Book.ToList();
            if (textBoxYearOfPublishing.Text == "")
            {
                bookList.ItemsSource = data;
            }
            else
            {
                var book_year = from book in data
                                where book.YearOfPublishing.Year.ToString() == textBoxYearOfPublishing.Text
                                select book;
                data = book_year.ToList();
                if (data.Count > 0)
                {
                    bookList.ItemsSource = data;
                    textBlock_NotFound.Visibility = Visibility.Collapsed;
                }
                else
                {
                    bookList.ItemsSource = null;
                    textBlock_NotFound.Visibility = Visibility.Visible;
                    data.Clear();
                }
            }
        }

        private void comboBoxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var data = DB_WOB.GetContext().Book.ToList();
            if (comboBoxCategory.SelectedItem.ToString() == "Все")
            {
                bookList.ItemsSource = data;
            }
            else
            {
                var book_category = from book in data
                                    where book.Category.Category1 == comboBoxCategory.SelectedItem.ToString()
                                    select book;
                data = book_category.ToList();
                if (data.Count > 0)
                {
                    bookList.ItemsSource = data;
                    textBlock_NotFound.Visibility = Visibility.Collapsed;
                }
                else
                {
                    bookList.ItemsSource = null;
                    textBlock_NotFound.Visibility = Visibility.Visible;
                    data.Clear();
                }
            }
        }

        private void comboBoxAuthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var data = DB_WOB.GetContext().Book.ToList();
            if (comboBoxAuthor.SelectedItem.ToString() == "Все")
            {
                bookList.ItemsSource = data;
            }
            else if(comboBoxAuthor.SelectedIndex > 0)
            {
                var book_author = from book in data
                                  where book.Author.Name == comboBoxAuthor.SelectedItem.ToString()
                                  select book;
                data = book_author.ToList();
                if (data.Count > 0)
                {
                    bookList.ItemsSource = data;
                    textBlock_NotFound.Visibility = Visibility.Collapsed;
                }
                else
                {
                    bookList.ItemsSource = null;
                    textBlock_NotFound.Visibility = Visibility.Visible;
                    data.Clear();
                }
            }
             
        }

        private void search_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            var data = DB_WOB.GetContext().Book.ToList();
            if (search_box.Text != null)
            {
                data = data.Where(currentTitle => currentTitle.Title.ToLower().Contains(search_box.Text.ToLower())).ToList();
            }
            if (data.Count > 0)
            {
                bookList.ItemsSource = data;
                textBlock_NotFound.Visibility = Visibility.Collapsed;
            }
            else
            {
                bookList.ItemsSource = null;
                textBlock_NotFound.Visibility = Visibility.Visible;
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_AddEditBook(null));
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            //var booksForRemoving = bookList.SelectedItems.Cast<Book>().ToList();

            //if (MessageBox.Show($"Вы точно хотите удалить следующие {booksForRemoving.Count()} элементов?", "Внимание",
            //    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    try
            //    {
            //        DB_WOB.GetContext().Book.RemoveRange(booksForRemoving);
            //        DB_WOB.GetContext().SaveChanges();
            //        MessageBox.Show("Данные удалены!");

            //        List<UserControl_Catalog> catalogs = new List<UserControl_Catalog>();
            //        DB_WOB.GetContext().Book.ToList().ForEach(item => catalogs.Add(new UserControl_Catalog(item)));
            //        bookList.ItemsSource = catalogs;

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString());
            //    }
            MessageBox.Show("Приносим свои извинения! Данная функция находится в разработке...");       
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            bookList.ItemsSource = DB_WOB.GetContext().Book.ToList();
        }
    }
}
