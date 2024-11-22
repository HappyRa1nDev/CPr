using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace CompLab3Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour % 12;
            int minute = currentTime.Minute;
            int second = currentTime.Second;

            double hourAngle = (hour + minute / 60.0) * 30;
            double minuteAngle = minute * 6;
            double secondAngle = second * 6;

            hourHand.RenderTransform = new RotateTransform(hourAngle, 100, 100);
            minuteHand.RenderTransform = new RotateTransform(minuteAngle, 100, 100);
            secondHand.RenderTransform = new RotateTransform(secondAngle, 100, 100);
        }
    }
}
