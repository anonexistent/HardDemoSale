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
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public MainPage()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////staff
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(0));

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.Navigate(new WarrantyRecordPage());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ////store
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(1));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ////vehicle
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(2));
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.Navigate(new TatarstanReportPage());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //FrameClass.mainFrame.Navigate(new PktPageDemoMVVM());
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.Navigate(new PktMainPage());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

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
