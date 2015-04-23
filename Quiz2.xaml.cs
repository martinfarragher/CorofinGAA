using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;

namespace CorofinGAA
{
    public partial class Quiz2 : PhoneApplicationPage
    {
        public Quiz2()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Quiz3.xaml", UriKind.Relative));
        }

         private void Fitz_Click(object sender, RoutedEventArgs e)
        {
            Button current = (Button)sender;

            if (current.IsEnabled == true)
            {
                NextBtn.Visibility = System.Windows.Visibility.Visible;
                NextBtn.IsEnabled = true;
            }
            else
            {
                NextBtn.Visibility = System.Windows.Visibility.Collapsed;
                NextBtn.IsEnabled = false;
            }
            Scoreboard.wrongAnswers++;

        }

        private void Mike_Click(object sender, RoutedEventArgs e)
        {
            Button current = (Button)sender;

            if (current.IsEnabled == true)
            {
                NextBtn.Visibility = System.Windows.Visibility.Visible;
                NextBtn.IsEnabled = true;
            }
            else
            {
                NextBtn.Visibility = System.Windows.Visibility.Collapsed;
                NextBtn.IsEnabled = false;
            }
            Scoreboard.correctAnswers++;
        }

        private void Ray_Click(object sender, RoutedEventArgs e)
        {
            Button current = (Button)sender;

            if (current.IsEnabled == true)
            {
                NextBtn.Visibility = System.Windows.Visibility.Visible;
                NextBtn.IsEnabled = true;
            }
            else
            {
                NextBtn.Visibility = System.Windows.Visibility.Collapsed;
                NextBtn.IsEnabled = false;
            }
            Scoreboard.wrongAnswers++;
        }

        
    }
}