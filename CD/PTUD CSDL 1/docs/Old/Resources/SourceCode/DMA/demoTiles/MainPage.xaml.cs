using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using demoTiles.Resources;
using Microsoft.Phone.Scheduler;

namespace demoTiles
{
    public partial class MainPage : PhoneApplicationPage
    {
        ShellTileSchedule sell = new Microsoft.Phone.Shell.ShellTileSchedule();
        bool running = false;
        ShellToast toast = new ShellToast();
        public MainPage()
        {
            InitializeComponent();


        }

        private void buttonOneTime_Click(object sender, RoutedEventArgs e)
        {
            sell.Recurrence = Microsoft.Phone.Shell.UpdateRecurrence.Onetime;
            sell.StartTime = DateTime.Now;
            sell.RemoteImageUri = new Uri(@"http://www.weather.gov/forecasts/graphical/images/conus/MaxT1_conus.png");
            sell.Start();
            running = true;
        }

        private void buttonIndefinite_Click(object sender, RoutedEventArgs e)
        {
            sell.Recurrence = Microsoft.Phone.Shell.UpdateRecurrence.Interval;
            sell.Interval = UpdateInterval.EveryHour;
            sell.RemoteImageUri = new Uri(@"http://www.weather.gov/forecasts/graphical/images/conus/MaxT1_conus.png");
            sell.Start();
            running = true;
        }

        private void buttonDefined_Click(object sender, RoutedEventArgs e)
        {
            sell.Recurrence = Microsoft.Phone.Shell.UpdateRecurrence.Interval;
            sell.Interval = UpdateInterval.EveryHour;
            sell.MaxUpdateCount = 50;
            sell.RemoteImageUri = new Uri(@"http://www.weather.gov/forecasts/graphical/images/conus/MaxT1_conus.png");
            sell.Start();
            running = true;
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            if (running == true)
                sell.Stop();
            else
            {
                buttonIndefinite_Click(sender, e);
            }

        }

        

        private void btnToast_Click(object sender, RoutedEventArgs e)
        {
            Alarm alarm = new Alarm("aaa");
            alarm.Content = "Hello world";
            alarm.Sound = new Uri("/me.mp3", UriKind.Relative);
            alarm.BeginTime = DateTime.Now.AddSeconds(10);
            alarm.ExpirationTime=DateTime.Now.AddSeconds(15);
            alarm.RecurrenceType = RecurrenceInterval.None;
            ScheduledActionService.Add(alarm);
        }
            
 
    }
}