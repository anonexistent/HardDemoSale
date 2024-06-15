using DemoSale.Data;
using DemoSale.DataBaseCore;
using LiveCharts;
using LiveCharts.Charts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Definitions.Series;
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
        public SeriesCollection SeriesCollection { get; set; }
        public List<string> Labels { get; set; }

        public StatisticMainPage()
        {
            InitializeComponent();
            InitStaticFields();

        }

        private void InitStaticFields()
        {
            var nowQuarter = DateTime.Now.AddMonths(-3);
            var convertedDate = DateOnly.Parse(nowQuarter.ToShortDateString());

            var tempValues = db.Pkt.Where(x => x.deliveryDate < convertedDate).GroupBy(x => x.dateShipment).Select(x => new { x.Key, Count = x.Count() }).ToList();

            var tempLines = new LineSeries
            {
                Title = tempValues.First().Key.ToString(),
                Values = new ChartValues<double> { }
            };

            foreach (var item in tempValues)
            {

                tempLines.Values.Add(double.Parse(item.Count.ToString()));
            }

            SeriesCollection = new SeriesCollection
            {
                tempLines
            };

            Labels = new List<string>
            {
                "Значение1", "Значение2", "Значение3", "Значение4", "Значение5",
                "Значение6", "Значение7", "Значение8", "Значение9", "Значение10"
            };

            DataContext = this;
            ccCount.Series = SeriesCollection;

            PcMonthInit();
            PcQuarterInit();

        }

        private void PcQuarterInit()
        {
            var nowQuarter = DateTime.Now.AddMonths(-3);
            var convertedDate = DateOnly.Parse(nowQuarter.ToShortDateString());
            var salesData = db.Pkt.Where(x=>x.deliveryDate<convertedDate).GroupBy(x => x.sellerAgent).Select(x => new { x.Key, Count = x.Count() }).ToList();

            SeriesCollection = new SeriesCollection();
            foreach (var data in salesData)
            {
                SeriesCollection.Add(new PieSeries
                {
                    Title = data.Key,
                    Values = new ChartValues<int> { data.Count },
                    DataLabels = true
                });
            }
            pcMonth.Series = SeriesCollection;
        }

        void PcMonthInit()
        {
            var fakeRation = Math.Round(new Random().NextDouble() * 10, 1);

            var nowQuarter = DateTime.Now.AddMonths(-3);
            var convertedDate = DateOnly.Parse(nowQuarter.ToShortDateString());
            var salesData = db.Pkt.Where(x => x.deliveryDate < convertedDate).GroupBy(x => x.sellerAgent)
                .Select(x => new { x.Key, Count = x.Count()*fakeRation }).ToList();

            SeriesCollection = new SeriesCollection();
            foreach (var data in salesData)
            {
                SeriesCollection.Add(new PieSeries
                {
                    Title = data.Key,
                    Values = new ChartValues<int> { (int)data.Count },
                    DataLabels = true
                });
            }
            pcQuarter.Series = SeriesCollection;
        }

        private void old_PcMonthInit()
        {
            //var salesData = db.Pkt.GroupBy(x => x.sellerAgent).Select(x=>new { x.Key, Count = x.Count() }).ToList();

            //SeriesCollection = new SeriesCollection();
            //foreach (var data in salesData)
            //{
            //    SeriesCollection.Add(new PieSeries
            //    {
            //        Title = data.Key,
            //        Values = new ChartValues<int> { data.Count },
            //        DataLabels = true
            //    });
            //}
            //pcMonth.Series= SeriesCollection;
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }
    }
}
