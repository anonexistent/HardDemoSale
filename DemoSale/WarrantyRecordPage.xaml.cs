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

        public WarrantyRecordPage()
        {
            InitializeComponent();

            dgMain.ItemsSource = ooooooooooo; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window win = new WindowAdd();

            win.ShowDialog();

            dgMain.ItemsSource = null;
            dgMain.ItemsSource = ooooooooooo;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dgMain.ItemsSource = null;
            dgMain.ItemsSource = ooooooooooo;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }
    }
}
