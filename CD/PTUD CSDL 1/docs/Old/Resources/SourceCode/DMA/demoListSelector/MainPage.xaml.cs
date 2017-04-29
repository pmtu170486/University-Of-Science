using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoListSelector.Resources;
using System.Collections.ObjectModel;

namespace demoListSelector
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
        private static ObservableCollection<Contact> lst = 
            new ObservableCollection<Contact>();
        

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Contact ct = new Contact { name = txtName.Text, phone = txtPhone.Text };
            lst.Add(ct);
            load();
        }
        public void load()
        {
            List<Contact> mylst = lst.OrderBy(x => x.name).ToList();
            mylist.ItemsSource = mylst;
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