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
    /// Логика взаимодействия для Page_Users.xaml
    /// </summary>
    public partial class Page_Users : Page
    {
        public Page_Users()
        {
            InitializeComponent();
        }
        private void search_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            var data = DB_WOB.GetContext().User.ToList();
            if(search_box.Text != null)
            {
                data = data.Where(currentName => currentName.Name.ToLower().Contains(search_box.Text.ToLower())).ToList();
            }
            if(data.Count > 0)
            {
                userList.ItemsSource = data;
                textBlock_NotFound.Visibility = Visibility.Collapsed;
            }
            else
            {
                userList.ItemsSource = null;
                textBlock_NotFound.Visibility = Visibility.Visible;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            userList.ItemsSource = DB_WOB.GetContext().User.ToList();
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_AddEditUser(null));
        }

        private void deleteUser_Click(object sender, RoutedEventArgs e)
        {
            var data = DB_WOB.GetContext();
            var usersForRemoving = userList.SelectedItems.Cast<User>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {usersForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    data.User.RemoveRange(usersForRemoving);
                    data.SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    userList.ItemsSource = data.User.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
