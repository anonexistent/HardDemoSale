using DemoSale.Data;
using DemoSale.DataBaseCore;
using DemoSale.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для PktPageDemoMain.xaml
    /// </summary>

    record ShortlyInfo(string value1, string value2, string laue3, string value4);
    public partial class PktMainPage : Page
    {
        private static ObservableCollection<Pkt> _pktList = new();
        public static ObservableCollection<Pkt> pktList
        {
            get { return _pktList; }
            set { _pktList = value; UpdateJson(); }
        }

        List<ShortlyInfo> ptkListShortView = new List<ShortlyInfo>();
        ApplicationContext db = new();

        public PktMainPage()
        {
            InitializeComponent();
            
            InitStaticFileds();
        }

        private void InitStaticFileds()
        {
            try
            {
                dgMain.ItemsSource = db.Pkt.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void ButtonAddClick(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new PktAddEditPage());
        }

        private void Button_Click_1_del(object sender, RoutedEventArgs e)
        {
            var selectedItem = (dgMain as DataGrid).SelectedItem as Pkt;

            if(selectedItem!=null)
            {
                var a = MessageBox.Show($"Удалить элемент №{selectedItem.pktId} ?", "Удаление", 
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(a==MessageBoxResult.Yes)
                {
                    db.Pkt.Remove(selectedItem);
                    db.SaveChanges();

                    (dgMain as DataGrid).ItemsSource = db.Pkt.ToList();
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать элемент", "Ошибка");
                return;
            }

        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.Navigate(new MainPage());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        private void Button_Click_reload(object sender, RoutedEventArgs e)
        {
            try
            {
                #region json schema

                //var schema = JsonSchema.FromType<List<Pkt>>();
                //var schemaJson = schema.ToJson();

                //FileStream temp = new FileStream("schema.json", FileMode.OpenOrCreate);
                //StreamWriter tempWriter = new StreamWriter(temp);
                //tempWriter.Write(schemaJson);
                //tempWriter.Close();

                //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testData.json");
                //var reader = new StreamReader(path);
                //string s = reader.ReadToEnd();
                //reader.Close();                
                //pktList = JsonConvert.DeserializeObject<ObservableCollection<Pkt>>(s);

                #endregion

                dgMain.ItemsSource = db.Pkt.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //if ((bool)((CheckBox)sender).IsChecked)
            //{
            //    foreach (Pkt item in pktList)
            //    {
            //        ShortlyInfo temp = new ShortlyInfo(item.positionType, item.positionName,
            //            item.deptMoney.ToString(), item.realization.ToString());
            //        ptkListShortView.Add(temp);
            //    }

            //    dgMain.ItemsSource = ptkListShortView;
            //}
            //else
            //{
            //    dgMain.ItemsSource = pktList;
            //}
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
            //string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testData.json");
            //string newJson = JsonConvert.SerializeObject(pktList, Formatting.Indented);
            //var x = new StreamWriter(path);
            //x.Write(newJson);
            //x.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedRowInDataGrid = dgMain.SelectedItem as Pkt;
            if (selectedRowInDataGrid != null)
            {
                FrameClass.mainFrame.Navigate(new PktEditPage(selectedRowInDataGrid));
            }
            else
            {
                MessageBox.Show("Необходимо выбрать элемент", "Ошибка");
                return;
            }


        }
    }
}
