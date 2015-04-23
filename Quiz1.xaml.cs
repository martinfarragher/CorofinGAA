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
    public partial class Quiz1 : PhoneApplicationPage
    {
        public Quiz1()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Quiz2.xaml", UriKind.Relative));
        }

        private void Corofin_Click(object sender, RoutedEventArgs e)
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

        private void Cross_Click(object sender, RoutedEventArgs e)
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

        private void Crokes_Click(object sender, RoutedEventArgs e)
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