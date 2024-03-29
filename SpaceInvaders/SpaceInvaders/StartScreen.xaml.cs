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
using System.Windows.Shapes;

namespace SpaceInvaders
{
    /// <summary>
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : Window
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow open = new MainWindow();
            open.Show();
            this.Close();
        }

        private void leaderBoardBtn_Click(object sender, RoutedEventArgs e)
        {
            LeaderBoard x = new LeaderBoard();
            x.Show();
            this.Close();
        }
    }
}
