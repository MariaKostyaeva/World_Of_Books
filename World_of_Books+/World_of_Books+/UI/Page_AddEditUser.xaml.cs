using Microsoft.Win32;
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
    /// Логика взаимодействия для Page_AddEditUser.xaml
    /// </summary>
    public partial class Page_AddEditUser : Page
    {
        private User _currentUser = new User();
        public Page_AddEditUser(User selectedUser)
        {
            InitializeComponent();
            
            var data = DB_WOB.GetContext();
            if(selectedUser != null)
            {
                UserControl_User userRole = new UserControl_User();
                string user_position = userRole.GetText();               

                comboBoxRole.ItemsSource = user_position;
                _currentUser = selectedUser;
            }

            DataContext = _currentUser;
            comboBoxRole.ItemsSource = data.Position.ToList();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            var data = DB_WOB.GetContext();
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUser.Name))
                errors.AppendLine("Укажите имя пользователя");
            if (string.IsNullOrWhiteSpace(_currentUser.Surname))
                errors.AppendLine("Укажите фамилию пользователя");
            if (string.IsNullOrWhiteSpace(_currentUser.Address))
                errors.AppendLine("Укажите адрес проживания");
            if (comboBoxRole.SelectedIndex < 0)
                errors.AppendLine("Выберите роль");
            else
            {
                var role = from position in data.Position
                           where position.Position1 == comboBoxRole.Text
                           select position.IdPosition;

                _currentUser.IdPosition = role.Single();
            }
            if(_currentUser.Login == null)
                errors.AppendLine("Укажите логин");
            if (_currentUser.Password == null || _currentUser.Password.Length < 6)
                errors.AppendLine("Укажите пароль. Он должен содержать не менее 6 символов");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentUser.IdUser == 0)
                data.User.Add(_currentUser);

            try
            {
                data.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager.MainFrame.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void addUserPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                user_photo.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        private void deleteUserPhoto_Click(object sender, RoutedEventArgs e)
        {
            user_photo.Source = new BitmapImage(new Uri("/Resources/user.jpeg", UriKind.Relative)) { CreateOptions = BitmapCreateOptions.IgnoreImageCache };
        }
    }
}
