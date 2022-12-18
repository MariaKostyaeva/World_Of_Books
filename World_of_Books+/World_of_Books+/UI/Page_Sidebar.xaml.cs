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
    /// Логика взаимодействия для Page_Sidebar.xaml
    /// </summary>
    public partial class Page_Sidebar : Page
    {
        public Page_Sidebar(string role)
        {
            InitializeComponent();
            var data = DB_WOB.GetContext();

            textBlockRole.Text = "Добро пожаловать " + role + "!";

            var position = from user in data.User
                           where role == user.Login
                           select user.IdPosition;
            if(position.First() == 1)
            {
                users.Visibility = Visibility.Collapsed;
                orders.Visibility = Visibility.Collapsed;
            }
            else if(position.Single() == 2)
            {
                catalog.Visibility = Visibility.Collapsed;
            }
        }
        
        private void catalog_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Catalog());
        }

        private void statistics_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Statistics());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите выйти из подсистемы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void stock_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Stock());
        }

        private void users_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Users());
        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Orders());
        }
    }
}

