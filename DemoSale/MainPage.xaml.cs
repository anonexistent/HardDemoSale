using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DemoSale
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        UIElementCollection btns;
        public MainPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btns = spMain.Children;

            switch (FrameClass.role)
            {
                case 0:
                    MakeVisibleSection("");
                    break;

                case 1:
                    MakeVisibleSection("учет");
                    break; 

                case 2:

                    break;

                case 3:
                    MakeVisibleSection("по");
                    break;
            }
        }

        void MakeVisibleSection(string name)
        {
            foreach (Button child in btns)
            {
                if (child.Content.ToString().ToLower().Contains(name))
                {
                    child.IsEnabled = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////staff
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(0));

            FrameClass.mainFrame.Navigate(new WarrantyRecordPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ////store
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(1));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ////vehicle
            //FrameClass.mainFrame.Navigate(new DemoPagePosition(2));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {            
            //FrameClass.mainFrame.Navigate(new PktPageDemoMVVM());
            FrameClass.mainFrame.Navigate(new PktPageDemoMain());

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
