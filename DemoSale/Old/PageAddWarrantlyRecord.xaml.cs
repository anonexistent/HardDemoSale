using System.Windows;
using System.Windows.Controls;

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
            var a = new MyClass(int.Parse(tb1.Text), tb2.Text, tb3.DisplayDate, tb4.Text);
            WarrantyRecordPage.testListAboutPositions.Add(a);

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            ((Window)FrameClass.addFrame.Parent).Close();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            ((Window)FrameClass.addFrame.Parent).Close();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

        }
    }
}
