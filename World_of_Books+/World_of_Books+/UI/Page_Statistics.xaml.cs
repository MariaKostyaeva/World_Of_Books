using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using World_of_Books_.Database;

namespace World_of_Books_.UI
{
    /// <summary>
    /// Логика взаимодействия для Page_Statistics.xaml
    /// </summary>
    public partial class Page_Statistics : Page
    {
        private DB_WOB _context = new DB_WOB();
        public Page_Statistics()
        {
            InitializeComponent();
            chartStatistics.ChartAreas.Add(new ChartArea("Main"));

            var currentSeries = new Series("Продажи")
            {
                IsValueShownAsLabel = true
            };
            chartStatistics.Series.Add(currentSeries);

            comboChartTypes.ItemsSource = Enum.GetValues(typeof(SeriesChartType));
        }

        /// <summary>
        /// Построение графика "Продажа книг"
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Содержит информацию о состоянии и данные события, связанные с перенаправленным событием</param>
        private void UpdateChart(object sender, SelectionChangedEventArgs e)
        {
            if(periodFrom != null && periodFor != null && comboChartTypes.SelectedItem is SeriesChartType currentType)
            {
                Series currentSeries = chartStatistics.Series.FirstOrDefault();
                currentSeries.ChartType = currentType;
                currentSeries.Points.Clear();

                var books = _context.Book.ToList();
                var orders = _context.Order;

                foreach(var book in books)
                {
                    decimal sum = 0;
                    foreach (Order order in orders.Where(order => order.Book.IdBook.Equals(book.IdBook)
                        && order.Date >= periodFrom.SelectedDate && order.Date <= periodFor.SelectedDate).ToList())
                    {
                        sum += order.TotalValue;
                    }
                    currentSeries.Points.AddXY(book.Title, sum);
                }
            }
        }
    }
}
