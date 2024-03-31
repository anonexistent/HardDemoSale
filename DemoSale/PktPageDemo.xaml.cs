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
using DemoSale.Data;
using Syncfusion.Windows.Shared;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для PktPageDemo.xaml
    /// </summary>
    public partial class PktPageDemo : Page
    {
        public DemoPkt currentPosition = new();

        public PktPageDemo()
        {
            InitializeComponent();

            InitItems();

            spTbs.DataContext = currentPosition;
        }

        private void InitItems()
        {
            var ss = FrameClass.db.Dealer.ToList();

            for (int i=0; i < ss.Count; i++)
            {
                cbDealer.Items.Add(new ComboBoxItem() { Content = ss[i].dealerName });
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new PktPageDemoMain());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
