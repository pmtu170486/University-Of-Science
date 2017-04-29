using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoATM.Resources;

namespace demoATM
{
    public partial class MainPage : PhoneApplicationPage
    {

        public List<Bank> lst;
        public MainPage()
        {
            InitializeComponent();
            lst = new List<Bank>();
            Bank b1 = new Bank();
            b1.name = "Agribank";
            b1.lstATM = new List<ATM>();
            b1.lstATM.Add(new ATM{name="AMT AG1",address="nguyen trai",distance="2"});
            b1.lstATM.Add(new ATM{name="AMT AG2",address="tran hung dao",distance="1"});
            b1.lstATM.Add(new ATM { name = "AMT AG3", address = "Tran phu", distance = "4"});

            Bank b2 = new Bank();
            b2.name = "ACB";
            b2.lstATM = new List<ATM>();
            b2.lstATM.Add(new ATM { name = "AMT ACB1", address = "nguyen dinh chieu", distance = "5" });
            b2.lstATM.Add(new ATM { name = "AMT ACb2", address = "Canh mang thang 8", distance = "3" });
            b2.lstATM.Add(new ATM { name = "AMT Acb3", address = "Duong 3/2", distance = "10" });

            lst.Add(b1);
            lst.Add(b2);
            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            foreach(Bank b in lst)
            {
                if( b.name.Equals(txtName.Text))
                {
                    flag = true;
                    mylist.ItemsSource = b.lstATM;
                    break;
                }
            }
            if (flag == false)
                MessageBox.Show("Khong tim thay du lieu");
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