using DemoSale.Data;
using Newtonsoft.Json;
using NJsonSchema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
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
    /// <summary>
    /// Логика взаимодействия для PktPageDemoMain.xaml
    /// </summary>
    public partial class PktPageDemoMain : Page
    {
        public PktPageDemoMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new PktPageDemo());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалить элемент № ?", "Удаление", MessageBoxButton.OKCancel);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var schema = JsonSchema.FromType<List<DemoPkt>>();
            var schemaJson = schema.ToJson();

            FileStream temp = new FileStream("schema.json", FileMode.OpenOrCreate);
            StreamWriter tempWriter = new StreamWriter(temp);
            tempWriter.Write(schemaJson);
            tempWriter.Close();

            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testData.json");
            string s = new StreamReader(path).ReadToEnd();

            List<DemoPkt> a = JsonConvert.DeserializeObject<List<DemoPkt>>(s);

            dgMain.ItemsSource = a;
        }
    }
}
