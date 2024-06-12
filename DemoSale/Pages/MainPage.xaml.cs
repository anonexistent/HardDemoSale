using DemoSale.Pages;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<Button> btns = new();
        public MainPage()
        {
            InitializeComponent();
            InitStaticFields();
        }

        private void InitStaticFields()
        {
            foreach (Button item in spMain.Children)
            {
                btns.Add(item);
            }
            btns.Add(btnStatistic);

            switch (FrameClass.role)
            {
                case 0:
                    MakeVisibleSection("");
                    break;

                case 1:
                    MakeVisibleSection("учет");
                    break;

                case 2:
                    MakeVisibleSection("стат");
                    break;

                case 3:
                    MakeVisibleSection("по");
                    break;
            }
        }

        void MakeVisibleSection(string name)
        {
            foreach (Button child in btns)
            {
                if (child.Content.ToString().ToLower().Contains(name))
                {
                    child.IsEnabled = true;
                }
            }
        }

        private void Button_Click_War(object sender, RoutedEventArgs e)
        {
            ////staff
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(0));

            FrameClass.mainFrame.Navigate(new WarrantyRecordPage());
        }

        private void Button_Click_Finances(object sender, RoutedEventArgs e)
        {
            ////store
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(1));
            FrameClass.mainFrame.Navigate(new FinanceReportMainPage());
        }

        private void Button_Click_Tatar(object sender, RoutedEventArgs e)
        {
            ////vehicle
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(2));
            FrameClass.mainFrame.Navigate(new TatarstanReportPage());
        }

        private void Button_Click_Pkt(object sender, RoutedEventArgs e)
        {
            //FrameClass.mainFrame.Navigate(new PktPageDemoMVVM());
            FrameClass.mainFrame.Navigate(new PktMainPage());

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void tnStatistic_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new StatisticMainPage());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Выполнить выход из учетной записи?", "Вы уверены?", 
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(a==MessageBoxResult.Yes) FrameClass.mainFrame.Navigate(new LoginPage());
            //System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            //Application.Current.Shutdown();
        }

        private void MenuItem_Click_AddItem(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В данной области не предусмотрено добавление элементов!", 
                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}