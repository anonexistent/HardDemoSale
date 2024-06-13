using DemoSale.Data;
using DemoSale.DataBaseCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NJsonSchema;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        ApplicationContext db = new();

        public WarrantyRecordPage()
        {

            InitializeComponent();
            //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //((Window)FrameClass.mainFrame.Parent).Background = new SolidColorBrush(Colors.OldLace);
            this.Background = new SolidColorBrush(Colors.OldLace);
            //dgMain.ItemsSource = testListAboutPositions; 

            generalList = new();

            InitData();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lbMain.ItemsSource = db.WarrantyRecord.Include(x=>x.pktParent).Include(a=>a.warContract).Include(o=>o.warSub).ToList();
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

            var tempContractId = ((WarrantyRecord)((ListBox)sender).SelectedItem).contractId;
            var tempContract = db.WarrantyContract.Where(x => 
            x.serviceContract == tempContractId).FirstOrDefault();

            switch (tempContract.technicalMaintenance)
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

        //  old button 'R'
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
            spWarTechMainte.DataContext = ((WarrantyRecord)((ListBox)sender).SelectedItem).warContract;
            GettechnicalMaintenanceInfo(sender);
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

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            foreach (WarrantyRecord item in tempList)
            {
                FrameClass.db.WarrantyRecord.Add(item);
            }
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.db.SaveChanges();

            var tempTest = FrameClass.db.WarrantyRecord.ToList();
            //generalList = JsonConvert.DeserializeObject<ObservableCollection<WarrantyRecord>>(s);
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = MessageBox.Show($"Подтвердите снятие с гарантийного учета:\nдата:{((DatePicker)sender).SelectedDate}\nпричина: []", "Подтверждение", MessageBoxButton.YesNo);
        }

        private void btnSaveTechChanges_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecord = (WarrantyRecord)lbMain.SelectedItem;

            if(string.IsNullOrEmpty(tbContract.Text) |
                string.IsNullOrEmpty(tbEngine.Text) |
                string.IsNullOrEmpty(tbEngTech.Text) |
                string.IsNullOrEmpty(tbEvp.Text) |
                string.IsNullOrEmpty(tbFact.Text) |
                string.IsNullOrEmpty(tbVin.Text) )
            {
                MessageBox.Show("Есть незполненные поля", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            //selectedRecord.warSub.vin = tbVin.Text;
            selectedRecord.warSub.engine = tbEngine.Text;
            selectedRecord.warSub.evp = tbEvp.Text;
            selectedRecord.warSub.dateRelease = int.Parse(cbYearsRelease.SelectedValue.ToString());

            selectedRecord.warContract.engTecWorker = tbEngTech.Text;
            selectedRecord.warContract.regionDeFacto = tbFact.Text;

            db.Update(selectedRecord);
            db.SaveChanges();

            MessageBox.Show("Изменения были приняты", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
