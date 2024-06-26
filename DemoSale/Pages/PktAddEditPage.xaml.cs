﻿using DemoSale.Data;
using DemoSale.DataBaseCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для PktPageDemo.xaml
    /// </summary>
    public partial class PktAddEditPage : Page
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

        public PktAddEditPage()
        {
            InitializeComponent();

            InitItems();

            spTbs.DataContext = currentPosition;
        }

        private void InitItems()
        {
            var ss = FrameClass.db.Dealer.ToList();
            for (int i = 0; i < ss.Count; i++)
            {
                cbDealer.Items.Add(new ComboBoxItem() { Content = ss[i].dealerName });
            }

            var sss = FrameClass.db.PositionType.ToList();
            foreach (var item in sss)
            {
                cbPosTypes.Items.Add(new ComboBoxItem() { Content=item.positionName });
            }

            var ssss = FrameClass.db.Specification.ToList();
            while(ssss.Count>0)
            {
                cbSpec.Items.Add(new ComboBoxItem{ Content = ssss.FirstOrDefault().name });
                ssss.Remove(ssss[0]);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new PktMainPage());
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Добавить запись?\n\nПредупреждение: в случае отмены изменения не будут применены","Подтверждение действия", MessageBoxButton.YesNo);
            if (a == MessageBoxResult.No)
            {
                FrameClass.mainFrame.GoBack();
                return;
            }

            db.Pkt.Add(currentPosition);
            db.SaveChanges();

            if (currentPosition.dealer.Contains("Татарстан"))
            {
                //  гарантийное фиксирование
                TatarstanAnnualReport temp = new()
                {
                    pktId= currentPosition.pktId,
                    count = currentPosition.count,
                    dateShipment = currentPosition.dateShipment,
                    paymentMethod = currentPosition.paymentMethod,
                    phone = "н/д",
                    positionName = currentPosition.positionName,
                    realization = currentPosition.realization,
                    region = currentPosition.region,
                    seller = currentPosition.seller,
                    sellerAgent = currentPosition.sellerAgent
                };
                db.TatarstanReport.Add(temp);
                db.SaveChanges();
            }

            //add to db this record

            #region addOtherRecords

            WarrantySubject tempWarSub = new() { positionName = currentPosition.positionName.ToString() };
            WarrantyContract tempWarCon = new() { serviceContract = "01УТ-01" + (new Random().Next(0, ushort.MaxValue)).ToString(), technicalMaintenance = 0 };

            db.WarrantySubject.Add(tempWarSub);
            db.WarrantyContract.Add(tempWarCon);

            db.SaveChanges();

            WarrantyRecord tempWar = new(tempWarCon.serviceContract.ToString(), tempWarSub.vin.ToString(), currentPosition.pktId);

            db.WarrantyRecord.Add(tempWar);
            //db.WarrantyRecord.Add(new WarrantyRecord() { subjectVin= "f69be430-fb25-480f-b9d2-816d31eafbe5", contractId= "01УТ-0150625", pktParentId=4  } );

            db.SaveChanges();

            db.FinanceReport.Add(new FinanceReport() { pktId=currentPosition.pktId, agent=currentPosition.sellerAgent, 
                manager=currentPosition.manager, region=currentPosition.region, document="X", dateShipment=currentPosition.dateShipment,
            seller=currentPosition.seller, });
            db.SaveChanges();

            #endregion

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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сохранить изменения элемента № ? ", "Изменение", MessageBoxButton.YesNo);
        }
    }
}
