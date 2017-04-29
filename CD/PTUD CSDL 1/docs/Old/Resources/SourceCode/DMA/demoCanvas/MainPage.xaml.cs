using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoCanvas.Resources;
using System.Windows.Shapes;
using System.Windows.Media;

namespace demoCanvas
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void btnLine_Click(object sender, RoutedEventArgs e)
        {
            Line l = new Line();
            l.X1 = 20;
            l.Y1 = 30;
            l.X2 = 300;
            l.Y2 = 350;
            l.Stroke = new SolidColorBrush(Colors.Yellow);
            mycanvas.Children.Add(l);
        }

        private void btnRect_Click(object sender, RoutedEventArgs e)
        {
            
            Rectangle r = new Rectangle();
            r.RadiusX = 100;
            r.RadiusY = 200;
            r.Width = 100;
            r.Height = 100;
            r.Stroke = new SolidColorBrush(Colors.Blue);
            r.Fill = new SolidColorBrush(Colors.Black);
            mycanvas.Children.Add(r);
        }

        private void btnAny_Click(object sender, RoutedEventArgs e)
        {
            Polygon p = new Polygon();
            p.Points.Add(new Point(20, 20));
            p.Points.Add(new Point(50, 30));
            p.Points.Add(new Point(30, 100));
            p.Points.Add(new Point(50, 120));
            p.Points.Add(new Point(20, 20));
            p.Fill = new SolidColorBrush(Colors.Yellow);
            mycanvas.Children.Add(p);
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}