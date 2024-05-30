using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для WarrantyRecordPageAdd.xaml
    /// </summary>
    public partial class WarrantyRecordPageAdd : Page
    {
        public WarrantyRecordPageAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.GoBack();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }
    }
}
