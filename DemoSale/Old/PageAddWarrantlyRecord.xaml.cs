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
    /// Логика взаимодействия для PageAddWarrantlyRecord.xaml
    /// </summary>
    public partial class PageAddWarrantlyRecord : Page
    {
        public PageAddWarrantlyRecord()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = new MyClass(int.Parse( tb1.Text), tb2.Text, tb3.DisplayDate, tb4.Text);
            WarrantyRecordPage.testListAboutPositions.Add(a);

            ((Window)FrameClass.addFrame.Parent).Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((Window)FrameClass.addFrame.Parent).Close();

        }
    }
}
