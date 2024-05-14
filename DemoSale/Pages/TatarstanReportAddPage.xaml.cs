using DemoSale.DataBaseCore;
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

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для TatarstanReportAddPage.xaml
    /// </summary>
    public partial class TatarstanReportAddPage : Page
    {
        public TatarstanReportAddPage()
        {
            InitializeComponent();

            InitComponents();
        }

        private void InitComponents()
        {
            //cbDealer
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.GoBack();
        }
    }
}
