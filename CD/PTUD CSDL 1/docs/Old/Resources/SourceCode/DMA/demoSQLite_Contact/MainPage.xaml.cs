using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoSQLite_Contact.Resources;
using System.Collections.ObjectModel;
namespace demoSQLite_Contact
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            load();
        
        }
        private DB_Helper helper;
        public string toUpper(string name)
        {
            char[] a = name.ToCharArray();
            a[0]=Char.ToUpper(a[0]);
            for(int i=1;i<a.Length;i++)
            {
                if(a[i]==' ')
                {
                    a[i + 1] = Char.ToUpper(a[i+1]);
                }
            }
            return new string(a);
        }
        public async void load()
        {
            helper = new DB_Helper();
            await helper.oncreate();
            List<Contact> lst = helper.readContact();
            foreach(Contact ct in lst)
            {
                ct.name=toUpper(ct.name);
            }
            ObservableCollection<Contact> source = 
                new ObservableCollection<Contact>(lst.OrderBy(x=>x.name));
            
            if(source.Count>0)
               mylist.ItemsSource = source;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Contact ct = 
                new Contact { name=txtName.Text,phone=txtPhone.Text};
            helper.insert(ct);
            load();

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