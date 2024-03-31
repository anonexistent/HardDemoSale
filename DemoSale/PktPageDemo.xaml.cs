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
using DemoSale.Data;
using DemoSale.DataBaseCore;
using Syncfusion.Windows.Shared;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для PktPageDemo.xaml
    /// </summary>
    public partial class PktPageDemo : Page
    {
        public ApplicationContext db;
        public DemoPkt currentPosition = new();

        public PktPageDemo()
        {
            InitializeComponent();

            InitItems();

            spTbs.DataContext = currentPosition;
        }

        private void InitItems()
        {
            var ss = FrameClass.db.Dealer.ToList();

            for (int i=0; i < ss.Count; i++)
            {
                cbDealer.Items.Add(new ComboBoxItem() { Content = ss[i].dealerName });
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new PktPageDemoMain());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (currentPosition.dealer.Contains("Татарстан"))
            {
                //MessageBox.Show("tatar is detected!!!!!!!!!");
                TatarstanAnnualReport temp = new() { id = -1, count = currentPosition.count, dateShipment = currentPosition.dateShipment,
                paymentMethod = currentPosition.paymentMethod, phone = "н/д", positionName = currentPosition.positionName,
                realization = currentPosition.realization, region = currentPosition.region, seller = currentPosition.seller, 
                    sellerAgent = currentPosition.sellerAgent};
                TatarstanReportPage.b.Add(temp);
            }

            MessageBox.Show("Запись создана");
            PktPageDemoMain.a.Add(currentPosition);
            PktPageDemoMain.UpdateJson();
            FrameClass.mainFrame.GoBack();
        }
    }
}
