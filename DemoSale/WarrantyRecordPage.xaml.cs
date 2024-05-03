﻿using DemoSale.Data;
using DemoSale.QR;
using Newtonsoft.Json;
using NJsonSchema;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
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

namespace DemoSale
{
    public class MyClass
    {
        public int MyProperty { get; set; }
        public string MyProperty1 { get; set; }
        public DateTime MyProperty2 { get; set; }
        public string MyProperty3 { get; set; }

        public MyClass(int a, string b, DateTime c, string d)
        {
            MyProperty = a;
            MyProperty1 = b;
            MyProperty2 = c;
            MyProperty3 = d;
        }
    }
    /// <summary>
    /// Логика взаимодействия для WarrantyRecordPage.xaml
    /// </summary>
    public partial class WarrantyRecordPage : Page
    {
        public static int HowMuch = 2;

        public ObservableCollection<bool> isSselection { get; set; }

        public static List<MyClass> testListAboutPositions = new List<MyClass>() {
        new MyClass(0, "pktList", new DateTime(2001,01,01), "xxx"),
        new MyClass(1, "pktList", new DateTime(2001,01,01), "xxxx"),
        new MyClass(2, "pktList", new DateTime(2001,01,01), "xxxx"),
        new MyClass(3, "pktList", new DateTime(2001,01,01), "xxxx"),
        new MyClass(4, "pktList", new DateTime(2001,01,01), "xxxx"),
        new MyClass(5, "pktList", new DateTime(2001,01,01), "xxxx"),
        new MyClass(6, "pktList", new DateTime(2001,01,01), "xxxx"),
        new MyClass(7, "pktList", new DateTime(2001,01,01), "xxxx"),
        };

        private ObservableCollection<WarrantyRecord> _generalList;

        public ObservableCollection<WarrantyRecord> generalList
        {
            get { return _generalList; }
            set { _generalList = value; }
        }

        public WarrantyRecordPage()
        {

            InitializeComponent();
            //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //((Window)FrameClass.mainFrame.Parent).Background = new SolidColorBrush(Colors.OldLace);
            this.Background = new SolidColorBrush( Colors.OldLace);
            //dgMain.ItemsSource = testListAboutPositions; 

            generalList = new();

            InitData();
        }

        private void InitData()
        {
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                cbYearsRelease.Items.Add(i);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window win = new WindowAdd();

            win.ShowDialog();

            //dgMain.ItemsSource = null;
            //dgMain.ItemsSource = testListAboutPositions;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //dgMain.ItemsSource = null;
            //dgMain.ItemsSource = testListAboutPositions;

        }
        
        private ObservableCollection<bool> GettechnicalMaintenanceInfo(object sender)
        {
            isSselection = new() {
                false,
                false,
                false,
                false,
                false
            };

            switch (((WarrantyRecord)((ListBox)sender).SelectedItem).contract.technicalMaintenance)
            {
                case 30:
                    isSselection[0] = true;
                    break;
                case 250:
                    isSselection[0] = true;
                    isSselection[1] = true;
                    break;
                case 500:
                    isSselection[0] = true;
                    isSselection[1] = true;
                    isSselection[2] = true;
                    break;
                case 750:
                    isSselection[0] = true;
                    isSselection[1] = true;
                    isSselection[2] = true;
                    isSselection[3] = true;
                    break;
                case 1000:
                    isSselection[0] = true;
                    isSselection[1] = true;
                    isSselection[2] = true;
                    isSselection[3] = true;
                    isSselection[4] = true;
                    break;

                default:
                    break;
            }

            return isSselection;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            #region json schema +bd work

            //var schema = JsonSchema.FromType<List<WarrantyRecord>>();
            //var schemaJson = schema.ToJson();

            //FileStream temp = new FileStream("schemaListWar.json", FileMode.OpenOrCreate);
            //StreamWriter tempWriter = new StreamWriter(temp);
            //tempWriter.Write(schemaJson);
            //tempWriter.Close();

            //generalList.Add(new WarrantyRecord() { vin="X43g!4gbvr323", count=10, dateEndWarranty=new DateOnly(2020,1,1), dateServiceContract=new DateOnly(2022,10,18) });
            //generalList.Add(new WarrantyRecord() { dateRelease=new DateOnly(2009,10,10), engine="G38-1, 20291", regionDeFacto="124, Orenburg, 101,3 4f" });

            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testDataWar.json");
            //string newJson = JsonConvert.SerializeObject(generalList, Formatting.Indented);
            //var x = new StreamWriter(path);
            //x.Write(newJson);
            //x.Close();

            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testDataWar.json");
            //string s = new StreamReader(path).ReadToEnd();

            //generalList = JsonConvert.DeserializeObject<ObservableCollection<WarrantyRecord>>(s);

            //foreach (var item in generalList)
            //{
            //    if (string.IsNullOrEmpty(item.seller)) item.seller = "н/д";
            //    if (string.IsNullOrEmpty(item.vin)) item.vin = "н/д";
            //    if (string.IsNullOrEmpty(item.engine)) item.engine = "н/д";
            //    FrameClass.db.WarrantyRecord.Add(item);
            //}

            //FrameClass.db.SaveChanges();

            //QrCode inputDialog = new("Please enter your name:", "John Doe");
            //if (inputDialog.ShowDialog() == true) return;
            ////    lblName.Text = inputDialog.Answer;
            ///

            #endregion
        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new WarrantyRecordPageAdd());
        }

        private void lbMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GettechnicalMaintenanceInfo(sender);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FrameClass.db = new();

            var temp = FrameClass.db.WarrantyRecord.ToList();

            foreach (var item in temp)
            {
                generalList.Add(item);
            }

            lbMain.ItemsSource = generalList;
        }

        private void JokeAboutWarRecordsInDb()
        {
            //var schema = JsonSchema.FromType<List<WarrantyRecord>>();
            //var schemaJson = schema.ToJson();

            //FileStream tempSch = new FileStream("schemaListWar.json", FileMode.OpenOrCreate);
            //StreamWriter tempWriter = new StreamWriter(tempSch);
            //tempWriter.Write(schemaJson);
            //tempWriter.Close();

            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testDataWar.json");
            //string newJson = JsonConvert.SerializeObject(generalList, Formatting.Indented);
            //var x = new StreamWriter(path);
            //x.Write(newJson);
            //x.Close();

            string s = new StreamReader(path).ReadToEnd();

            var tempList = JsonConvert.DeserializeObject<ObservableCollection<WarrantyRecord>>(s);

            foreach (WarrantyRecord item in tempList)
            {
                FrameClass.db.WarrantyRecord.Add(item);
            }
            FrameClass.db.SaveChanges();

            var tempTest = FrameClass.db.WarrantyRecord.ToList();
            //generalList = JsonConvert.DeserializeObject<ObservableCollection<WarrantyRecord>>(s);
        }
    }
}
