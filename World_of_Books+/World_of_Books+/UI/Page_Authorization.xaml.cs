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
    /// Логика взаимодействия для Page_Authorization.xaml
    /// </summary>
    public partial class Page_Authorization : Page
    {
        public Page_Authorization()
        {
            InitializeComponent();
        }
        private void enter_Click(object sender, RoutedEventArgs e)
        {
            Authorization.AccsessCheck(login.Text, password.Text, passwordBox.Password);          
        }
        private void cbShowPassword_Click(object sender, RoutedEventArgs e)
        {
            if (cbShowPassword.IsChecked.Value)
            {
                password.Text = passwordBox.Password;
                passwordBox.Visibility = Visibility.Hidden;
                password.Visibility = Visibility.Visible;
            }
            else
            {
                passwordBox.Password = password.Text;
                passwordBox.Visibility = Visibility.Visible;
                password.Visibility = Visibility.Hidden;
            }
        }
    }
}

