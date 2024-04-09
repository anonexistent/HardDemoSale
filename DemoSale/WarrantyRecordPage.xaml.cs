using DemoSale.Data;
using DemoSale.QR;
using Newtonsoft.Json;
using NJsonSchema;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public static List<MyClass> ooooooooooo = new List<MyClass>() {
        new MyClass(0, "a", new DateTime(2001,01,01), "xxx"),
        new MyClass(1, "a", new DateTime(2001,01,01), "xxxx"),
        new MyClass(2, "a", new DateTime(2001,01,01), "xxxx"),
        new MyClass(3, "a", new DateTime(2001,01,01), "xxxx"),
        new MyClass(4, "a", new DateTime(2001,01,01), "xxxx"),
        new MyClass(5, "a", new DateTime(2001,01,01), "xxxx"),
        new MyClass(6, "a", new DateTime(2001,01,01), "xxxx"),
        new MyClass(7, "a", new DateTime(2001,01,01), "xxxx"),
        };

        private ObservableCollection<WarrantyRecord> _y;

        public ObservableCollection<WarrantyRecord> yyyyy
        {
            get { return _y; }
            set { _y = value; }
        }


        public WarrantyRecordPage()
        {
            InitializeComponent();
            //  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            ((Window)FrameClass.mainFrame.Parent).Background = new SolidColorBrush(Colors.OldLace);
            //dgMain.ItemsSource = ooooooooooo; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window win = new WindowAdd();

            win.ShowDialog();

            //dgMain.ItemsSource = null;
            //dgMain.ItemsSource = ooooooooooo;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //dgMain.ItemsSource = null;
            //dgMain.ItemsSource = ooooooooooo;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new WarrantyRecordPageAdd());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //var schema = JsonSchema.FromType<List<WarrantyRecord>>();
            //var schemaJson = schema.ToJson();

            //FileStream temp = new FileStream("schemaListWar.json", FileMode.OpenOrCreate);
            //StreamWriter tempWriter = new StreamWriter(temp);
            //tempWriter.Write(schemaJson);
            //tempWriter.Close();

            //yyyyy.Add(new WarrantyRecord() { vin="X43g!4gbvr323", count=10, dateEndWarranty=new DateOnly(2020,1,1), dateServiceContract=new DateOnly(2022,10,18) });
            //yyyyy.Add(new WarrantyRecord() { dateRelease=new DateOnly(2009,10,10), engine="G38-1, 20291", regionDeFacto="124, Orenburg, 101,3 4f" });

            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testDataWar.json");
            //string newJson = JsonConvert.SerializeObject(yyyyy, Formatting.Indented);
            //var x = new StreamWriter(path);
            //x.Write(newJson);
            //x.Close();

            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testDataWar.json");
            string s = new StreamReader(path).ReadToEnd();

            yyyyy = JsonConvert.DeserializeObject<ObservableCollection<WarrantyRecord>>(s);

            lbMain.ItemsSource = yyyyy;

            QrCode inputDialog = new("Please enter your name:", "John Doe");
            if (inputDialog.ShowDialog() == true) return;
            //    lblName.Text = inputDialog.Answer;
        }
    }
}
