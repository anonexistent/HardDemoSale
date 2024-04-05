﻿using DemoSale.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для TatarstanReportPage.xaml
    /// </summary>
    public partial class TatarstanReportPage : Page
    {
        private static ObservableCollection<TatarstanAnnualReport> _b = new();
        public static ObservableCollection<TatarstanAnnualReport> b
        {
            get { return _b; }
            set { _b = value; }
        }
        public TatarstanReportPage()
        {
            InitializeComponent();

            dgMain.ItemsSource = b;
        }

        void A()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new TatarstanReportAddPage());

        }
    }
}