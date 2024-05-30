using System.Windows;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
            FrameClass.addFrame = fAdd;
            FrameClass.addFrame.Navigate(new PageAddWarrantlyRecord());
        }
    }
}
