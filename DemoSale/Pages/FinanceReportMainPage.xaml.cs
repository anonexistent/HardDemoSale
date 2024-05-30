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

namespace DemoSale.Pages
{
    /// <summary>
    /// Логика взаимодействия для FinanceReportMainPage.xaml
    /// </summary>
    public partial class FinanceReportMainPage : Page
    {
        public FinanceReportMainPage()
        {
            InitializeComponent();

            InitStaticFields();
        }

        private void InitStaticFields()
        {

        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new MainPage());
        }
    }
}
