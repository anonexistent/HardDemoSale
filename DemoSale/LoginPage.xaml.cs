using DemoSale.Data;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        ApplicationContext db = new();

        public LoginPage()
        {
            InitializeComponent();

            //MessageBox.Show(db.Dealer.ToList().Count.ToString());

            InitApplication();
        }

        private void InitApplication()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Window)FrameClass.mainFrame.Parent).Height = 800;
            ((Window)FrameClass.mainFrame.Parent).Width = 1200;

            FrameClass.role = User.users[$"{tbLogin.Text}"];

            FrameClass.mainFrame.Navigate(new MainPage());
        }
    }
}
