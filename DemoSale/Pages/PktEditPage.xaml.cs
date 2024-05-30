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
        }

        private void InitStaticFields()
        {
            cbDealer.ItemsSource = db.Dealer.ToList();
            InitCurrentItemForChange();

        }

        private void InitCurrentItemForChange()
        {
            tbKontr.Text = cifc.seller;
            tbGr.Text = cifc.sellerAgent;
            tbArea.Text = cifc.region;
            tbManager.Text = cifc.manager;

            cbDealer.SelectedItem = db.Dealer.Where(x=>x.dealerName== cifc.dealer).FirstOrDefault();
            tbMoneyZakup.Text = cifc.purchaseMoney.ToString();
            tbMoneyDealer.Text = cifc.paidMoney.ToString();
            tbMoneyDealerDebt.Text = cifc.deptMoney.ToString();
            dpPayTerm.SelectedDate = DateTime.Parse(cifc.paymentTerm.ToString());
            cbSpec.SelectedItem = cifc.specification;

            tbPriceSellerDep.Text = cifc.salesDepartmentMoney.ToString();
            tbPriceRealization.Text = cifc.realization.ToString();
            tbPriceGotten.Text = cifc.arrivedMoney.ToString();
            tbPriceDebt.Text = cifc.realizationDept.ToString();
            dpDateGiveMoney.SelectedDate = DateTime.Parse(cifc.paymentTermRealization.ToString());
            cbPaymentMethod.SelectedValue = cifc.paymentMethod;
            tbMarzh.Text = cifc.marginalProfit.ToString();
            tbTrans.Text = cifc.transportOther.ToString();
            tbTransNds.Text = cifc.transportOtherNds.ToString();
            tbLoading.Text = cifc.loadingUnloading.ToString();

            tbKv.Text = cifc.kvMoney.ToString();
            tbMoneyOther.Text = cifc.otherMoney.ToString();
            tbOtherWork.Text = cifc.dopPositionDescription;
            dpDeliveryTerm.SelectedDate = DateTime.Parse(cifc.deliveryDate.ToString());
            tbForeCalc.Text = cifc.forCalculation.ToString();
        }
    }
}
