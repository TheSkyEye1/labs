using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace videoplayer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;

        bool isplaying = false;

        public MainWindow()
        {
            InitializeComponent();
            vp.Volume = voice.Value;
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            vp.Source = new Uri(dlg.FileName, UriKind.Relative);
            vp.Pause();
           

        }

        private void vidlength_ValueChanged(object sender, DragCompletedEventArgs e)
        {
            int SliderValue = (int)vidlength.Value;
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            vp.Position = ts;
            timenow.Content = ts.Minutes.ToString() + ':' + ts.Seconds.ToString(); 
        }

        private void Voice_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            vp.Volume = voice.Value;
        }

        private void Playpause_Click(object sender, RoutedEventArgs e)
        {
            if (isplaying == false)
            {
                vp.Play();
                playpause.Content = "pause";
                isplaying = true;
                Timer.Start();
            }
            else
            {
                vp.Pause();
                playpause.Content = "play";
                isplaying = false;
                Timer.Stop();
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            vp.Stop();
        }

        private void Vp_MediaOpened(object sender, RoutedEventArgs e)
        {
            vidlength.Maximum = vp.NaturalDuration.TimeSpan.TotalMilliseconds;
            timeall.Content = vp.NaturalDuration.TimeSpan.Minutes.ToString() + ':' + vp.NaturalDuration.TimeSpan.Seconds.ToString();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            int SliderValue = (int)vidlength.Value;
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            vidlength.Value = Convert.ToInt32(vp.Position.TotalMilliseconds);
            timenow.Content = ts.Minutes.ToString() + ':' + ts.Seconds.ToString();
        }
    }
}
