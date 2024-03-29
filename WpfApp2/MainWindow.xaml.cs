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

namespace WpfApp2
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                Random r = new Random();
                Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                                  (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
                btn.Background = brush;
            }
            
        }



        private void btn1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button btn)
            {
              this.Title = btn.Content.ToString();
                int btn_content = int.Parse(btn.Content.ToString());
                MessageBox.Show($"you clickded button {btn_content}");
                
                if( btn_content>=1 && btn_content <= 3)
                {
                    stackpanel2.Children.Remove(btn);
                }
                else if (btn_content >= 4 && btn_content <= 6)
                {
                    stackpanel3.Children.Remove(btn);
                }
            }
                
        }
    }
}
