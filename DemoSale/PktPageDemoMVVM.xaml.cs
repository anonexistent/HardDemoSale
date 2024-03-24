﻿using DemoSale.Data;
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
    /// Логика взаимодействия для PktPageDemoMVVM.xaml
    /// </summary>
    
    record TestClass(string propName, string propValue);
    public partial class PktPageDemoMVVM : Page
    {
        List<TestClass> TextDescriptionCollection;
        public PktPageDemoMVVM()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            TextDescriptionCollection = new List<TestClass>();
            var temp = typeof(DemoPkt).GetProperties().Select(x => x.Name).ToList();
            for (int i = 0; i < temp.Count-1; i++) 
            {
                TextDescriptionCollection.Add(new TestClass(temp[i], string.Empty));
            }
            DataContext = this;
        }
    }
}
