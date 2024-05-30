using DemoSale.Pages;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        UIElementCollection btns;
        public MainPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btns = spMain.Children;

            switch (FrameClass.role)
            {
                case 0:
                    MakeVisibleSection("");
                    break;

                case 1:
                    MakeVisibleSection("учет");
                    break;

                case 2:

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
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                if (child.Content.ToString().ToLower().Contains(name))
                {
                    child.IsEnabled = true;
                }
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new LoginPage());
            //System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            //Application.Current.Shutdown();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
