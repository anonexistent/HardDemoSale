using DemoSale.DataBaseCore;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.GoBack();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        private void Button_Click_1_Add(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.Navigate(new TatarstanReportAddPage());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

        }

        private void Button_ClickRestore(object sender, RoutedEventArgs e)
        {
            //dgMain.ItemsSource = FrameClass.db.TatarstanReport.ToList();
        }
    }
}
