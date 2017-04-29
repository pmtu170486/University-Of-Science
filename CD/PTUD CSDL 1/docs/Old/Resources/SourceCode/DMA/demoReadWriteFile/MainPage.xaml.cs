using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoReadWriteFile.Resources;

using System.IO;
using Windows.Storage;
using System.IO.IsolatedStorage;

namespace demoReadWriteFile
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

        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isofile = 
                IsolatedStorageFile.GetUserStoreForApplication();
            // Kiem tra thu muc co ton tai hay khong?
            if(isofile.DirectoryExists(txtFolder.Text)==false)
            {
                // Neu khong ton tai thi tao thu muc moi
                isofile.CreateDirectory(txtFolder.Text);
            }
            // Neu ton tai thi tao file va luu trong thu muc
            StreamWriter writer =
                new StreamWriter(
                    new IsolatedStorageFileStream(
                        txtFolder.Text + "\\" + txtFile.Text, 
                        FileMode.OpenOrCreate, isofile));
            writer.WriteLine(txtText.Text);
            writer.Close();
            MessageBox.Show("Save successful");
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile isofile =
                IsolatedStorageFile.GetUserStoreForApplication();
            if (isofile.FileExists(txtFolder.Text + "\\" + txtFile.Text) == false)
                MessageBox.Show("File khong ton tai");
            else
            {
                StreamReader reader = 
                    new StreamReader(
                        new IsolatedStorageFileStream(txtFolder.Text+"\\"+txtFile.Text,
                            FileMode.Open,isofile));
                MessageBox.Show(reader.ReadToEnd());
                reader.Close();
            }
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