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

namespace MyTreeWpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var path =((sender as Button).DataContext as Folder)?.FullPath;
            MessageBox.Show(path.ToString());

            //var path1 = (sender as Button)?.Tag.ToString();
            //MessageBox.Show(path1);

           // var path1 = (sender as Button)?.Tag.ToString();
           ///MessageBox.Show(path1);
        }
    }
}
