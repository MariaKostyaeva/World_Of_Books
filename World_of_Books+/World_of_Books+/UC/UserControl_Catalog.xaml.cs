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
    /// Логика взаимодействия для UserControl_Catalog.xaml
    /// </summary>
    public partial class UserControl_Catalog : UserControl
    {
        public UserControl_Catalog()
        {
            InitializeComponent();
        }
        public UserControl_Catalog(Book book)
        {
            InitializeComponent();
            DataContext = book;
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приносим свои извинения! Данная функция находится в разработке...");
        }
    }
}
