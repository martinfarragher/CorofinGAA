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
    public partial class All_Ireland1998 : PhoneApplicationPage
    {
        public All_Ireland1998()
        {
            InitializeComponent();
            List<product> p1 = new List<product>();
            p1.Add(new product() { ImagePath = "images/corofinold1.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinold2.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinold3.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinold4.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinold5.jpg" });
            p1.Add(new product() { ImagePath = "images/corofinold6.jpg" });

            list1.DataContext = p1;
        }
    }
}