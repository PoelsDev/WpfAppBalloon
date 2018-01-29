﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppBalloon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>    
    public partial class MainWindow : Window
    {
        private Balloon balloon1;

        public MainWindow()
        {
            InitializeComponent();

            balloon1 = new Balloon();
            balloon1.DisplayOn(mijnCanvas);

        }

        private void mijnKnop1_Click(object sender, RoutedEventArgs e)
        {
            balloon1.MoveRight(10);
        }

        private void mijnKnop2_Click(object sender, RoutedEventArgs e)
        {

            balloon1.ChangeSize(10);
        }

        private void mijnKnop3_Click(object sender, RoutedEventArgs e)
        {
            balloon1.MoveUp(10);
        }

        private void mijnKnop4_Click(object sender, RoutedEventArgs e)
        {
            balloon1.ChangeColor();
        }
    }
}
