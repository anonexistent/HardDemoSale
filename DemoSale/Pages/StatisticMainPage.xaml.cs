using DemoSale.DataBaseCore;
using LiveCharts;
using LiveCharts.Charts;
using LiveCharts.Wpf;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoSale.Pages
{
    /// <summary>
    /// Логика взаимодействия для StatisticMainPage.xaml
    /// </summary>
    public partial class StatisticMainPage : Page
    {
        ApplicationContext db = new();
        LiveCharts.SeriesCollection x;


        public StatisticMainPage()
        {
            InitializeComponent();
            InitStaticFields();

        }

        private void InitStaticFields()
        {
            x = new LiveCharts.SeriesCollection();
            x.Add(new LineSeries()
            {
                Values = new ChartValues<int> { 2, 5, 4, 2, 6 },
                Name = "Income",
                Stroke = null
            });
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }
    }
}
