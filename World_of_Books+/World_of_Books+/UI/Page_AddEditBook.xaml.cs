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
    /// Логика взаимодействия для Page_AddEdit.xaml
    /// </summary>
    public partial class Page_AddEditBook : Page
    {
        private Book _currentBook = new Book();
        public Page_AddEditBook(Book selectedBook)
        {
            InitializeComponent();
            var data = DB_WOB.GetContext();

            if (selectedBook != null)
            {
                _currentBook = selectedBook;
            }

            DataContext = _currentBook;
            comboBoxCover.ItemsSource = data.Cover.ToList();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            var data = DB_WOB.GetContext();
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentBook.Title))
                errors.AppendLine("Укажите название книги");
            if (string.IsNullOrWhiteSpace(textBoxAuthor.Text))
            {
                errors.AppendLine("Укажите автора");
            }
            else
            {
                var current_author = from author in data.Author
                                     where author.Name == textBoxAuthor.Text
                                     select author.IdAuthor;

                _currentBook.IdAuthor = current_author.Single();
            }
            if (string.IsNullOrWhiteSpace(textBoxCategory.Text))
            {
                errors.AppendLine("Укажите категорию");
            }
            else
            {
                var current_category = from category in data.Category
                                     where category.Category1 == textBoxCategory.Text
                                     select category.IdCategory;

                _currentBook.IdCategory = current_category.Single();
            }
            if (string.IsNullOrWhiteSpace(textBoxSubcategory.Text))
            {
                errors.AppendLine("Укажите подкатегорию");
            }
            else
            {
                var current_subcategory = from subcategory in data.Subcategory
                                       where subcategory.Subcategory1 == textBoxSubcategory.Text
                                       select subcategory.IdSubcategory;

                _currentBook.IdSubcategory = current_subcategory.Single();
            }
            if (comboBoxCover.SelectedIndex < 0)
                errors.AppendLine("Выберите тип переплета");
            else
            {
                var current_cover = from cover in data.Cover
                           where cover.Cover1 == comboBoxCover.Text
                           select cover.IdCover;

                _currentBook.IdCover = current_cover.Single();
            }
            if (string.IsNullOrWhiteSpace(textBoxPublishingHouse.Text))
            {
                errors.AppendLine("Вы не ввели название издательства");
            }
            else
            {
                var current_publishingHouse = from publishingHouse in data.PublishingHouse
                                          where publishingHouse.PublishingHouse1 == textBoxPublishingHouse.Text
                                          select publishingHouse.IdPublishingHouse;

                _currentBook.IdPublishingHouse = current_publishingHouse.Single();
            }
            if (string.IsNullOrWhiteSpace(_currentBook.YearOfPublishing.Year.ToString()))
                errors.AppendLine("Укажите год издания");
            if (string.IsNullOrWhiteSpace(textBoxNumberOfPages.Text))
            {
                errors.AppendLine("Укажите количество страниц");
            }
            else
            {
                var numberOfPages = from pages in data.Book
                                    where pages.NumberOfPages.ToString() == textBoxNumberOfPages.Text
                                    select pages.NumberOfPages;

                _currentBook.NumberOfPages = numberOfPages.Single();
            }
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                errors.AppendLine("Укажите стоимость");
            }
            else
            {
                var priceOfBook = from price in data.Book
                                    where price.Price.ToString() == textBoxPrice.Text
                                    select price.Price;

                _currentBook.Price = priceOfBook.Single();
            }
            if (string.IsNullOrWhiteSpace(textBoxQuantityInStock.Text))
            {
                errors.AppendLine("Укажите количество книг на складе");
            }
            else
            {
                var qtyInStock = from qty in data.Book
                                 where qty.QuantityInStock.ToString() == textBoxNumberOfPages.Text
                                 select qty.QuantityInStock;

                _currentBook.QuantityInStock = qtyInStock.Single();
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentBook.IdBook == 0)
                DB_WOB.GetContext().Book.Add(_currentBook);

            try
            {
                DB_WOB.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
