using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoEmailCompose.Resources;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace demoEmailCompose
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

        private void btnEmailCompose_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask email = new EmailComposeTask();
            email.Subject = "Hello World";
            email.To = "pmtu170486@gmail.com";
            email.Body = "This is a test email";
            email.Show();
        }

        private void btnSettingBluetooth_Click(object sender, RoutedEventArgs e)
        {
            ConnectionSettingsTask task = new ConnectionSettingsTask();
            task.ConnectionSettingsType = ConnectionSettingsType.Bluetooth;
            task.Show();
        }

        private void btnShowMap_Click(object sender, RoutedEventArgs e)
        {
            MapsDirectionsTask task = new MapsDirectionsTask();
            task.Start=
                new LabeledMapLocation("CNC Aptech",
                    new System.Device.Location.GeoCoordinate(10,106));
            task.End =
                new LabeledMapLocation("End",
                    new System.Device.Location.GeoCoordinate(11, 106));
            task.Show();

        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask task = new PhoneCallTask();
            task.PhoneNumber = "0943322343";
            task.DisplayName = "Anh";
            task.Show();
        }

        private void btnSMS_Click(object sender, RoutedEventArgs e)
        {
            SmsComposeTask task = new SmsComposeTask();
            task.To = "0943434343";
            task.Body = "this is a sms test";
            task.Show();
        }

        private void btnBrowser_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask task = new WebBrowserTask();
            task.Uri = new Uri("http://www.dantri.com", UriKind.Absolute);
            task.Show();
            
        }

        private void btnSaveContact_Click(object sender, RoutedEventArgs e)
        {
            SaveContactTask task = new SaveContactTask();
            task.Show();
        }

        private void btnCamera_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureTask task = new CameraCaptureTask();
            task.Completed += task_Completed;
            task.Show();
        }

        void task_Completed(object sender, PhotoResult e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.SetSource(e.ChosenPhoto);
            image.Source = bitmap;
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