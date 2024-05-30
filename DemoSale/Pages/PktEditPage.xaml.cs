using DemoSale.Data;
using DemoSale.DataBaseCore;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DemoSale.Pages
{
    /// <summary>
    /// Логика взаимодействия для PktEditPage.xaml
    /// </summary>
    public partial class PktEditPage : Page
    {
        ApplicationContext db = new();
        public Pkt cifc;

        public PktEditPage(Pkt item)
        {
            InitializeComponent();

            cifc = item;

            InitStaticFields();
            InitCurrentItemForChange(GetCifc());

        }

        private void InitStaticFields()
        {
            cbDealer.ItemsSource = db.Dealer.ToList();
            cbSpec.ItemsSource = db.Specification.ToList();
            cbPosTypes.ItemsSource = db.PositionType.ToList();

        }

        private Pkt GetCifc()
        {
            return cifc;
        }

        private void InitCurrentItemForChange(Pkt cifc)
        {

            tbKontr.Text = cifc.seller.ToString();
            tbGr.Text = cifc.sellerAgent;
            tbArea.Text = cifc.region;
            tbManager.Text = cifc.manager;
            cbPosTypes.SelectedItem = db.PositionType.Where(x => x.positionName == cifc.positionType).FirstOrDefault();
            cbPosName.Text = cifc.positionName;
            tbCount.Text = cifc.count.ToString();

            cbDealer.SelectedItem = db.Dealer.Where(x => x.dealerName == cifc.dealer).FirstOrDefault();
            tbMoneyZakup.Value = (decimal?)cifc.purchaseMoney;
            tbMoneyDealer.Value = (decimal?)cifc.paidMoney;
            tbMoneyDealerDebt.Value = (decimal?)cifc.deptMoney;
            dpPayTerm.SelectedDate = DateTime.Parse(cifc.paymentTerm.ToString());
            cbSpec.SelectedItem = db.Specification.FirstOrDefault(x=>x.name==cifc.specification);

            tbPriceSellerDep.Value = (decimal?)cifc.salesDepartmentMoney;
            tbPriceRealization.Value = (decimal?)cifc.realization;
            tbPriceGotten.Value = (decimal?)cifc.arrivedMoney;
            tbPriceGotten.Value = (decimal?)cifc.arrivedMoney;
            tbPriceDebt.Value = (decimal?)cifc.realizationDept;
            dpDateGiveMoney.SelectedDate = DateTime.Parse(cifc.paymentTermRealization.ToString());
            cbPaymentMethod.Text = cifc.paymentMethod;
            tbMarzh.Value = (decimal?)cifc.marginalProfit;
            tbTrans.Value = (decimal?)cifc.transportOther;
            tbTransNds.Value = (decimal?)cifc.transportOtherNds;
            tbLoading.Value = (decimal?)cifc.loadingUnloading;

            tbKv.Value = (decimal?)cifc.kvMoney;
            tbMoneyOther.Value = (decimal?)cifc.otherMoney;
            tbOtherWork.Text = cifc.dopPositionDescription;
            dpDeliveryTerm.SelectedDate = DateTime.Parse(cifc.deliveryDate.ToString());
            tbForeCalc.Value = (decimal?)cifc.forCalculation;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Все изменения будут утеряны","Уведомление", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (a != MessageBoxResult.OK) return;
            FrameClass.mainFrame.Navigate(new PktMainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Type t = cifc.GetType();
            var props = t.GetProperties();

            foreach (var item in props)
            {
                MessageBox.Show(item.Name +"\t" + item.GetValue(cifc).ToString());
            }

            string message = "Принять следующие изменения?" +
                "1. -" +
                "2. -" +
                "3. -";
            var a = MessageBox.Show(message, "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (a == MessageBoxResult.Yes)
            {

            }
            FrameClass.mainFrame.Navigate(new PktMainPage());
        }
    }
}
