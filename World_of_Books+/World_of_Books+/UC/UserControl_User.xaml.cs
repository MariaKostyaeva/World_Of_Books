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
    /// Логика взаимодействия для UserControl_User.xaml
    /// </summary>
    public partial class UserControl_User : UserControl
    {
        public UserControl_User()
        {
            InitializeComponent();
        }
        public UserControl_User(User user)
        {
            InitializeComponent();
            DataContext = user;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_AddEditUser((sender as Button).DataContext as User));
        }

        public string GetText()
        {
            return textBlockUserRole.ToString();
        }
    }
}
