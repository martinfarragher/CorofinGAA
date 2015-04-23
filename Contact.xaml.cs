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
    public partial class Contact : PhoneApplicationPage
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Facebook_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://www.facebook.com/Corofingaa?fref=ts");
        }

        private void ShowInBrowser(string url)
        {
           Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
           wbt.Uri = new Uri(url);
           wbt.Show();
        }

        private void Twitter_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://twitter.com/CorofinGAA?lang=en");
        }

    }  
}