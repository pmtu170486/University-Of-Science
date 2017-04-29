using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace demoBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Contact> mylist = new List<Contact>();

        ObservableCollection<Contact> lst;
        public MainPage()
        {
            this.InitializeComponent();
            lst=new ObservableCollection<Contact>();
         
        }

        

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int count = lst.Count;
            Contact ct = new Contact
            {
                id=count+1,
                name=txtName.Text,
                phone=txtPhone.Text,
                email=txtEmail.Text
            };
            mylist.Add(ct);
            mylist= mylist.OrderBy(x=>x.name).ToList();
            lst = new ObservableCollection<Contact>(mylist);
            lstView.ItemsSource = lst;
        }

    }
}
