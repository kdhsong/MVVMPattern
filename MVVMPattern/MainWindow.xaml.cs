﻿using MVVMPattern.ViewModel;
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

namespace MVVMPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FotaViewModel viewContext = new FotaViewModel();
        public MainWindow()
        {
            this.DataContext = viewContext;
            InitializeComponent();
            this.nameTxt.Focus();
        }

        private void addPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            this.nameTxt.Focus();
        }
    }
}
