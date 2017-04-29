using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BaiTap.Resources;
using Microsoft.Phone.Tasks;

namespace BaiTap
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            load();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        public void load()
        {
            List<Contact> lst = new List<Contact>();
            lst.Add(new Contact { name = "Anh 6", phone = "094324324234" });
            lst.Add(new Contact { name = "Ba 6", phone = "095343434" });
            lst.Add(new Contact { name = "Chi 6", phone = "09123324324" });
            lst.Add(new Contact { name = "Thang 6", phone = "0909321323" });
            lst.Add(new Contact { name = "Con 6", phone = "09343242432" });
            mylist.ItemsSource = lst;
        }
        private void mylist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact ct=(Contact)mylist.SelectedItem;
            PhoneCallTask task = new PhoneCallTask();
            task.PhoneNumber = ct.phone;
            task.DisplayName = ct.name;
            task.Show();
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