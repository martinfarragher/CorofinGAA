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
    public partial class Teams : PhoneApplicationPage
    {
        public Teams()
        {
            InitializeComponent();
            List<product> p1 = new List<product>();
            p1.Add(new product() { ImagePath = "images/corofinteam1.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinteam2.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinteam3.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinteam5.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinteam7.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinteam8.jpg" });

            list1.DataContext = p1;
        }
    }
}