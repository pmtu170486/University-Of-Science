using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoMyTiles.Resources;
using Microsoft.Phone.Scheduler;
using System.Collections.ObjectModel;
namespace demoMyTiles
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
        private DB_Helper helper = new DB_Helper();
        private static int i = 10;
        public async void load()
        {
            await helper.onCreate();
            List<note> lst = helper.readnotes();
            if(lst.Count>0)
            {
                ObservableCollection<note> observer = 
                    new ObservableCollection<note>(lst);
                mylist.ItemsSource = observer;
            }

            foreach(note n in lst)
            {
               
                    Alarm al = new Alarm(new Guid().ToString()+(++i).ToString());
                    al.Content = n.content;
                    al.BeginTime = DateTime.Now.AddSeconds(n.date.Subtract(DateTime.Now).TotalSeconds);
                    al.ExpirationTime = DateTime.Now.AddSeconds(n.date.Subtract(DateTime.Now).TotalSeconds+25);
                    al.Sound = 
                        new Uri("/Assets/sound/sound.mp3",UriKind.Relative);
                    al.RecurrenceType = RecurrenceInterval.None;
                    ScheduledActionService.Add(al);
                
            }
        }


        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            load();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            load();
        }
        private void btnAddNote_Click(object sender, RoutedEventArgs e)
        {
            NavigationService
                .Navigate(new Uri("/AddPage.xaml", UriKind.Relative));
        }

       
    }
}