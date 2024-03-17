using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////staff
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(0));


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ////store
            FrameClass.mainFrame.Navigate(new DemoPagePosition(1));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ////vehicle
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(2));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
