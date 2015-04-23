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
    public partial class All_Ireland2015 : PhoneApplicationPage
    {
        public All_Ireland2015()
        {
            InitializeComponent();
            List<product> p1 = new List<product>();
            p1.Add(new product() { ImagePath = "images/corofinwin1.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinwin2.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinwin3.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinwin4.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinwin5.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinwin6.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinwin7.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinwin8.jpg" });

            list1.DataContext = p1;
        }
    }
}