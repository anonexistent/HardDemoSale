using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для PktPage.xaml
    /// </summary>
    public partial class PktPage : Page
    {
        public int HowMuch { get; set; } = 250;

        public PktPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        public void AddCloudsToCanvas()
        {

        }
    }
}
