using System;
using System.Collections.Generic;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        record Phone(string Title, string Company, long Price);

        List<string> forRandomImage;

        public Page3(byte windowCode)
        {
            InitializeComponent();

            Init(windowCode);
            InitResources();
        }

        private void InitResources()
        {
            forRandomImage = new List<string>() { "info0.jpg", "info1.jpg", "info2.jpg", "info3.jpg", "info4.jpg", };
        }

        private void Init(int a)
        {
            switch (a)
            {
                case 0:
                    //staff
                    g0.Visibility = Visibility.Visible;
                    g1.Visibility = Visibility.Collapsed;
                    g2.Visibility = Visibility.Collapsed;
                    break; 

                case 1:
                    //store
                    g0.Visibility = Visibility.Collapsed;
                    g1.Visibility = Visibility.Visible;
                    g2.Visibility = Visibility.Collapsed;

                    Init1();

                    break; 

                case 2:
                    //vehicle
                    g0.Visibility = Visibility.Collapsed;
                    g1.Visibility = Visibility.Collapsed;
                    g2.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void btnAddNewPhone_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new Page4demo());
        }

        private void lb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tb2.Visibility = Visibility.Collapsed;

            string templateUri = @"pack://application:,,,/DemoSale;component/Resources/";
            string resultUri = templateUri + forRandomImage[new Random().Next(0, forRandomImage.Count - 1)];
            imgSection1.Source = new BitmapImage(new Uri(resultUri));
        }

        private void Init1()
        {
            List<Phone> phonesList = new List<Phone>
            {
                new Phone("iPhone 6S","Apple", 54990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Lumia 950","Microsoft", 39990 ),
                new Phone("Nexus 5X", "Google", 29990 )
            };
            dg1.ItemsSource = phonesList;
        }
    }
}
