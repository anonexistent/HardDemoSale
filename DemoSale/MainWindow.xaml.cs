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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var a = MessageBox.Show("Завершить работу системы?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (a == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
