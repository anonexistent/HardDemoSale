using DemoSale.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для PktPageDemoMVVM.xaml
    /// </summary>

    record TestClass(string propName, string propValue);
    public partial class PktPageDemoMVVM : Page
    {
        List<TestClass> textDescriptionCollection;
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public PktPageDemoMVVM()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            textDescriptionCollection = new List<TestClass>();
            var temp = typeof(Pkt).GetProperties().Select(x => x.Name).ToList();
            for (int i = 0; i < temp.Count - 1; i++)
            {
                textDescriptionCollection.Add(new TestClass(temp[i], string.Empty));
            }
            this.DataContext = this;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            FrameClass.mainFrame.Navigate(new MainPage());
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }
    }
}
