using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TImeTask
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer Timer = new DispatcherTimer();
        Stopwatch timerwatch = new Stopwatch();
        string elapsedTime;


        ObservableCollection<string> stopList = new ObservableCollection<string>();
        ObservableCollection<string> restartList = new ObservableCollection<string>();
        ObservableCollection<string> elapseList = new ObservableCollection<string>();
        //ObservableCollection<int> totalList = new ObservableCollection<int>();

        public MainPage()
        {
            this.InitializeComponent();
            CurrentTime();

        }



        public void CurrentTime()
        {
            DataContext = this;
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }


      

        // string s_time =  ""; 
        public void OnClickStop(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            timerwatch.Start();
            stopList.Add(Time.Text);
            StopTimes.ItemsSource = this.stopList;


        }

        public void OnClickRestart(object sender, RoutedEventArgs e)
        {
            timerwatch.Stop();

            elapsedTime = String.Format("{0}", timerwatch.ElapsedTicks / Stopwatch.Frequency);// convert the ticks to seconds
            elapseList.Add(elapsedTime);

            elapse.ItemsSource = this.elapseList;
            timerwatch.Reset();
            
            CurrentTime();
                                
            
            restartList.Add(DateTime.Now.ToString("HH:mm:ss tt"));
            RestartTimes.ItemsSource = this.restartList;

            
           


        }
       

    }
}

