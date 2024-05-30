using DemoSale.Data;
using DemoSale.DataBaseCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            InitCurrentItemForChange(cifc);

        }

        private void InitStaticFields()
        {
            cbDealer.ItemsSource = db.Dealer.ToList();
            cbSpec.ItemsSource = db.Specification.ToList();
            cbPosTypes.ItemsSource = db.PositionType.ToList();

        }

        private void InitCurrentItemForChange(Pkt cifc)
        {
            tbKontr.Text                    = cifc.seller.ToString();
            tbGr.Text                       = cifc.sellerAgent;
            tbArea.Text                     = cifc.region;
            tbManager.Text                  = cifc.manager;
            cbPosTypes.SelectedItem         = db.PositionType.Where(x => x.positionName == cifc.positionType).FirstOrDefault();
            cbPosName.Text                  = cifc.positionName;
            tbCount.Text                    = cifc.count.ToString();

            cbDealer.SelectedItem           = db.Dealer.Where(x => x.dealerName == cifc.dealer).FirstOrDefault();
            tbMoneyZakup.Value              = (decimal?)cifc.purchaseMoney;
            tbMoneyDealer.Value             = (decimal?)cifc.paidMoney;
            tbMoneyDealerDebt.Value         = (decimal?)cifc.deptMoney;
            dpPayTerm.SelectedDate          = DateTime.Parse(cifc.paymentTerm.ToString());
            cbSpec.SelectedItem             = db.Specification.FirstOrDefault(x=>x.name==cifc.specification);

            tbPriceSellerDep.Value          = (decimal?)cifc.salesDepartmentMoney;
            tbPriceRealization.Value        = (decimal?)cifc.realization;
            tbPriceGotten.Value             = (decimal?)cifc.arrivedMoney;
            tbPriceDebt.Value               = (decimal?)cifc.realizationDept;
            dpDateGiveMoney.SelectedDate    = DateTime.Parse(cifc.paymentTermRealization.ToString());
            cbPaymentMethod.Text            = cifc.paymentMethod;
            tbMarzh.Value                   = (decimal?)cifc.marginalProfit;
            tbTrans.Value                   = (decimal?)cifc.transportOther;
            tbTransNds.Value                = (decimal?)cifc.transportOtherNds;
            tbLoading.Value                 = (decimal?)cifc.loadingUnloading;

            tbKv.Value                      = (decimal?)cifc.kvMoney;
            tbMoneyOther.Value              = (decimal?)cifc.otherMoney;
            tbOtherWork.Text                = cifc.dopPositionDescription;
            dpDeliveryTerm.SelectedDate     = DateTime.Parse(cifc.deliveryDate.ToString());
            tbForeCalc.Value                = (decimal?)cifc.forCalculation;
        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Все изменения будут утеряны","Уведомление", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (a != MessageBoxResult.OK) return;
            FrameClass.mainFrame.Navigate(new PktMainPage());
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            var newItem = GetNewPktFromForm();
            //  работа идет с определенны заранее документом
            newItem.pktId = cifc.pktId;
            //  отличиающиеся поля
            var listDiff = GetDifferencesFieldName(cifc, newItem);

            var formatedList = GetFormatedDifferencesFieldName(listDiff);
            string message = "Принять следующие изменения?\n" + formatedList;

            var a = MessageBox.Show(message, "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (a == MessageBoxResult.Yes)
            {
                cifc = newItem;
                db.Pkt.Update(cifc);
                db.SaveChanges();
                
            }
            FrameClass.mainFrame.Navigate(new PktMainPage());
        }

        private string GetFormatedDifferencesFieldName(object stringArray)
        {
            string result = String.Empty;

            for (int i = 0; i < ((List<string>)stringArray).Count; i++)
            {
                result += $"\n{i+1}. {((List<string>)stringArray)[i]}";

            }

            return result;
        }

        private List<string> GetDifferencesFieldName(Pkt original, Pkt newItem)
        {
            var result = new List<string>();

            Type tOrig = original.GetType();
            var propsOrig = tOrig.GetProperties();
            var tNew = newItem.GetType();
            var propsNew = tNew.GetProperties();

            foreach (var prop in propsOrig)
            {
                var tempOrig = prop.GetValue(original);
                var tempNew = prop.GetValue(newItem);
                if(tempNew.ToString() != tempOrig.ToString())
                {
                    result.Add(prop.Name);
                    //MessageBox.Show($"i found a difference:\n\n([{prop.Name}] {tempOrig} — {tempNew})","", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
            }

            //foreach (var item in props)
            //{
            //    MessageBox.Show(item.Name + "\t" + item.GetValue(original).ToString());
            //}

            return result;
        }

        private Pkt GetNewPktFromForm()
        {
            Pkt result = new()
            {
                seller = tbKontr.Text,
                sellerAgent = tbGr.Text,
                region = tbArea.Text,
                manager = tbManager.Text,
                positionType = (cbPosTypes.SelectedItem as PositionType).positionName,
                positionName = cbPosName.Text,
                count = int.Parse(tbCount.Text),

                dealer = (cbDealer.SelectedItem as Dealer).dealerName,
                purchaseMoney = (double)tbMoneyZakup.Value,
                paidMoney = (double)tbMoneyDealer.Value,
                deptMoney = (double)tbMoneyDealerDebt.Value,
                paymentTerm = DateOnly.Parse(dpPayTerm.SelectedDate.Value.ToShortDateString()),
                specification = (cbSpec.SelectedItem as Specification).name,

                salesDepartmentMoney = (double)tbPriceSellerDep.Value,
                realization = (double)tbPriceRealization.Value,
                arrivedMoney = (double)tbPriceGotten.Value,
                //result.realizationDept    =tbPriceDebt.Value           ;
                paymentTermRealization = DateOnly.Parse(dpDateGiveMoney.SelectedDate.Value.ToShortDateString()),
                paymentMethod = cbPaymentMethod.Text,
                marginalProfit = (double)tbMarzh.Value,
                transportOther = (double)tbTrans.Value,
                transportOtherNds = (double)tbTransNds.Value,
                loadingUnloading = (double)tbLoading.Value,

                kvMoney = (double)tbKv.Value,
                otherMoney = (double)tbMoneyOther.Value,
                dopPositionDescription = tbOtherWork.Text,
                deliveryDate = DateOnly.Parse(dpDeliveryTerm.SelectedDate.Value.ToShortDateString()),
                forCalculation = (double)tbForeCalc.Value
            };

            return result;
        }

        private void tbCount_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
