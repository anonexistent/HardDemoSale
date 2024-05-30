namespace DemoSale.UI
{
    //public class PktViewModel
    //{
    //    public class PktData
    //    {
    //        string _selectedPay;

    //        private ObservableCollection<string> _pays = new() { "111", "222", "333" };
    //        public IEnumerable<string> Pays
    //        {
    //            get { return _pays; }
    //        }

    //        public string SelectedPay
    //        {
    //            get { return _selectedPay; }
    //            set
    //            {
    //                _selectedPay = value;
    //                OnPropertyChanged(nameof(SelectedPay));
    //            }
    //        }

    //        public string NewPay
    //        {
    //            set
    //            {
    //                if (SelectedPay != null)
    //                {
    //                    return;
    //                }
    //                if (!String.IsNullOrEmpty(value))
    //                {
    //                    _pays.Add(value);
    //                    SelectedPay = value;
    //                }
    //            }
    //        }


    //        public event PropertyChangedEventHandler? PropertyChanged;

    //        void OnPropertyChanged(string propName)
    //        {
    //            var handler = this.PropertyChanged;
    //            if (handler != null)
    //            {
    //                handler(this, new PropertyChangedEventArgs(propName));
    //            }
    //        }
    //    }

    //    public Data.Pkt currentPosition = new();

    //    public ApplicationContext db = new();

    //    private void InitItems()
    //    {
    //        //var ss = FrameClass.db.Dealer.ToList();

    //        //for (int i = 0; i < ss.Count; i++)
    //        //{
    //        //    cbDealer.Items.Add(new ComboBoxItem() { Content = ss[i].dealerName });
    //        //}
    //    }

    //    private void Button_Click_2(object sender, RoutedEventArgs e)
    //    {
    //        FrameClass.mainFrame.Navigate(new PktPageDemoMain());
    //    }

    //    private void Button_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (currentPosition.dealer.Contains("Татарстан"))
    //        {
    //            //MessageBox.Show("tatar is detected!!!!!!!!!");
    //            TatarstanAnnualReport temp = new()
    //            {
    //                id = -1,
    //                count = currentPosition.count,
    //                dateShipment = currentPosition.dateShipment,
    //                paymentMethod = currentPosition.paymentMethod,
    //                phone = "н/д",
    //                positionName = currentPosition.positionName,
    //                realization = currentPosition.realization,
    //                region = currentPosition.region,
    //                seller = currentPosition.seller,
    //                sellerAgent = currentPosition.sellerAgent
    //            };
    //            TatarstanReportPage.b.Add(temp);
    //        }

    //        MessageBox.Show("Запись создана");
    //        PktPageDemoMain.pktList.Add(currentPosition);
    //        PktPageDemoMain.UpdateJson();
    //        FrameClass.mainFrame.GoBack();
    //    }
    //}
}
