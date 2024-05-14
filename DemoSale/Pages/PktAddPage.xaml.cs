using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public partial class PktAddPage : Page
    {
        public class PktData
        {
            string _selectedPay;

            private ObservableCollection<string> _pays = new() { "111", "222", "333" };
            public IEnumerable<string> Pays
            {
                get { return _pays; }
            }

            public string SelectedPay
            {
                get { return _selectedPay; }
                set
                {
                    _selectedPay = value;
                    OnPropertyChanged(nameof(SelectedPay));
                }
            }

            public string NewPay
            {
                set
                {
                    if (SelectedPay != null)
                    {
                        return;
                    }
                    if (!String.IsNullOrEmpty(value))
                    {
                        _pays.Add(value);
                        SelectedPay = value;
                    }
                }
            }


            public event PropertyChangedEventHandler? PropertyChanged;

            void OnPropertyChanged(string propName)
            {
                var handler = this.PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propName));
                }
            }
        }

        private Pkt _currentPosition = new();

        public Pkt currentPosition
        {
            get { return _currentPosition; }
            set { _currentPosition = value; }
        }

        ApplicationContext db = new();

        public PktAddPage()
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

            var sss = FrameClass.db.PositionType.ToList();
            foreach (var item in sss)
            {
                cbPosTypes.Items.Add(item);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new PktMainPage());
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
                db.TatarstanReport.Add(temp);
                db.SaveChanges();
            }

            WarrantySubject tempWarSub = new() { positionName = currentPosition.positionName.ToString()};
            WarrantyContract tempWarCon = new() { serviceContract = "01УТ-01" + (new Random().Next(0, ushort.MaxValue)).ToString() };

            //add to db this record
            FrameClass.db.Pkt.Add(currentPosition);
            FrameClass.db.WarrantySubject.Add(tempWarSub);
            FrameClass.db.WarrantyContract.Add(tempWarCon);

            FrameClass.db.SaveChanges();

            WarrantyRecord tempWar = new(tempWarCon.serviceContract.ToString(), tempWarSub.vin.ToString(), currentPosition.pktId);

            FrameClass.db.WarrantyRecord.Add(tempWar);
            //FrameClass.db.WarrantyRecord.Add(new WarrantyRecord() { subjectVin= "f69be430-fb25-480f-b9d2-816d31eafbe5", contractId= "01УТ-0150625", pktParentId=4  } );

            FrameClass.db.SaveChanges();

            //PktPageDemoMain.pktList.Add(currentPosition);
            MessageBox.Show("Запись создана");
            //PktPageDemoMain.UpdateJson();
            FrameClass.mainFrame.GoBack();
        }

        void CreateTatarstanRecord()
        {

        }

        void CreateWarranty()
        {

        }
    }
}
