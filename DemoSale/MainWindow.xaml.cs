using System.Windows;

namespace DemoSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameClass.mainFrame = fMain;
            FrameClass.mainFrame.Navigate(new LoginPage());
        }
    }
}
