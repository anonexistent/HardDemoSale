using DemoSale.DataBaseCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для TatarstanReportPage.xaml
    /// </summary>
    public partial class TatarstanReportPage : Page
    {
        ApplicationContext db = new();

        public TatarstanReportPage()
        {
            InitializeComponent();

            InitItems();
        }

        private void InitItems()
        {
            PreInitItems();

            var a = MessageBox.Show("Возможно, были загружены не все записи. Загрузить?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (a == MessageBoxResult.No)
            {
                return;
            }
            AddAllTatarstanFromPkt();
        }

        void PreInitItems()
        {
            //  from database
            var b = db.TatarstanReport.ToList();
            dgMain.ItemsSource = b;

        }

        private void AddAllTatarstanFromPkt()
        {
            MessageBox.Show("all entities from Pkt was benn loaded!");
        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.GoBack();
        }

        private void Button_Click_1_Add(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new TatarstanReportAddPage());

        }

        private void Button_ClickRestore(object sender, RoutedEventArgs e)
        {
            //dgMain.ItemsSource = FrameClass.db.TatarstanReport.ToList();
        }
    }
}
