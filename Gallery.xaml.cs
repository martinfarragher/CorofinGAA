using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CorofinGAA
{
    public partial class Gallery : PhoneApplicationPage
    {
        public Gallery()
        {
            InitializeComponent();


        }
        private void corofinnew_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/All-Ireland2015.xaml", UriKind.Relative));
        }

        private void corofinold_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/All-Ireland1998.xaml", UriKind.Relative));
        }

        private void teams_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Teams.xaml", UriKind.Relative));

        }
    }
}