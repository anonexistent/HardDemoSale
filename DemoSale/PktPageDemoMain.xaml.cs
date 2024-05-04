﻿using DemoSale.Data;
using Newtonsoft.Json;
using NJsonSchema;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    
    record ShortlyInfo(string value1, string value2, string laue3, string value4);
    public partial class PktPageDemoMain : Page
    {
        private static ObservableCollection<Pkt> _pktList = new();
        public static ObservableCollection<Pkt> pktList
        {
            get { return _pktList; }
            set { _pktList = value; UpdateJson(); }
        }

        List<ShortlyInfo> ptkListShortView = new List<ShortlyInfo>();

        public PktPageDemoMain()
        {
            InitializeComponent();
        }

        private void ButtonAddClick(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new PktPageDemo());            
            //FrameClass.mainFrame.Navigate(new PktPage());
        }

        private void Button_Click_1_del(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалить элемент № ?", "Удаление", MessageBoxButton.OKCancel);
        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }

        private void Button_Click_reload(object sender, RoutedEventArgs e)
        {
            //#region json schema

            //var schema = JsonSchema.FromType<List<Pkt>>();
            //var schemaJson = schema.ToJson();

            //FileStream temp = new FileStream("schema.json", FileMode.OpenOrCreate);
            //StreamWriter tempWriter = new StreamWriter(temp);
            //tempWriter.Write(schemaJson);
            //tempWriter.Close();

            //#endregion

            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testData.json");
            //var reader = new StreamReader(path);
            //string s = reader.ReadToEnd();
            //reader.Close();

            //pktList = JsonConvert.DeserializeObject<ObservableCollection<Pkt>>(s);
            
            dgMain.ItemsSource = FrameClass.db.Pkt.ToList();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)((CheckBox)sender).IsChecked)
            {
                foreach (Pkt item in pktList)
                {
                    ShortlyInfo temp = new ShortlyInfo(item.positionType, item.positionName, 
                        item.deptMoney.ToString(), item.realization.ToString());
                    ptkListShortView.Add(temp);
                }

                dgMain.ItemsSource = ptkListShortView;
            }
            else
            {
                dgMain.ItemsSource = pktList;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //var schema = JsonSchema.FromType<List<Pkt>>();
            //var schemaJson = schema.ToJson();
            //
            //FileStream temp = new FileStream("schema.json", FileMode.OpenOrCreate);
            //StreamWriter tempWriter = new StreamWriter(temp);
            //tempWriter.Write(schemaJson);
            //tempWriter.Close();
            //
            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testData.json");
            //string s = new StreamReader(path).ReadToEnd();
            //
            //pktList = JsonConvert.DeserializeObject<ObservableCollection<Pkt>>(s);

            //dgMain.ItemsSource = pktList;
        }

        public static void UpdateJson()
        {
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testData.json");
            string newJson = JsonConvert.SerializeObject(pktList, Formatting.Indented);
            var x = new StreamWriter(path);
            x.Write(newJson);
            x.Close();
        }
    }
}
