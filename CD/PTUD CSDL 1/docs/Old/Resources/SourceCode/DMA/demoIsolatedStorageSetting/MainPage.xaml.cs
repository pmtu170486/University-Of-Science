using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoIsolatedStorageSetting.Resources;
using System.IO.IsolatedStorage;

namespace demoIsolatedStorageSetting
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            IsolatedStorageSettings iso = IsolatedStorageSettings.ApplicationSettings;
            if(iso.Contains("data")==true)
            {
                txtName.Text = 
                    IsolatedStorageSettings.ApplicationSettings["data"] as string;
            }
            else
            {
                txtName.Text = "no data";
            }
            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageSettings iso = IsolatedStorageSettings.ApplicationSettings;
            if(iso.Contains("data")==false)
            {
                iso.Add("data", txtName.Text);
            }
            else
            {
                iso["data"] = txtName.Text;
            }
            iso.Save();
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