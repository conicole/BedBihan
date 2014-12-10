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
using BedBihan;

namespace BedBihanGUI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void highlight(object sender, RoutedEventArgs e)
        {
            
        }

        private void generateClassicMap(object sender, RoutedEventArgs e)
        {
            mapView.generateClassic();
            mapView.InvalidateVisual();
        }

        private void generateSmallMap(object sender, RoutedEventArgs e)
        {
            mapView.generateSmall();
            mapView.InvalidateVisual();
        }

        private void generateDemoMap(object sender, RoutedEventArgs e)
        {
            mapView.generateDemo();
            mapView.InvalidateVisual();
        }

       
    }
}
