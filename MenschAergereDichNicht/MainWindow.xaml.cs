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

namespace MenschAergereDichNicht
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

        private void btnSpielStarten_Click(object sender, RoutedEventArgs e)
        {
            NeuesSpiel neuesSpiel = new NeuesSpiel();
            neuesSpiel.ShowDialog();
        }

        private void btnRegeln_Click_1(object sender, RoutedEventArgs e)
        {
            Regeln regel = new Regeln();
            regel.ShowDialog();
        }

        private void btnSpielLaden_Click(object sender, RoutedEventArgs e)
        {
            NeuesSpiel laden = new NeuesSpiel();
            laden.ShowDialog();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
