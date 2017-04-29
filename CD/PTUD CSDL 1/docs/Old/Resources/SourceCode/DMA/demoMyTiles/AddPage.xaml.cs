using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace demoMyTiles
{
    public partial class AddPage : PhoneApplicationPage
    {
        public AddPage()
        {
            InitializeComponent();
            helper = new DB_Helper();
            
        }

        private DB_Helper helper;

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            await helper.onCreate();
            note n = new note();
            n.title = txtTitle.Text;
            n.content = txtContent.Text;
            string date = txtdate.Value.Value.ToShortDateString() + 
                " "+ txttime.Value.Value.ToShortTimeString();
            n.date = DateTime.Parse(date);
            helper.insert(n);
            NavigationService.GoBack();
        }
    }
}