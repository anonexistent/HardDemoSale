﻿using System;
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
            FrameClass.mainFrame.GoBack();
        }
    }
}