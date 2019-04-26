using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mp3pl
{ 
    /// <summary> 
    /// Логика взаимодействия для MainWindow.xaml 
    /// </summary> 
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer Timer;
        
        MediaPlayer player = new MediaPlayer();
        bool playing = false;
        bool playlooping = false;
        bool playline = true;
        int indnum;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            player.Volume = volumeline.Value;
            player.MediaOpened += Player_MediaOpened;
            Timer = new System.Windows.Threading.DispatcherTimer();
            player.MediaEnded += Player_MediaEnded;
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
            timeall.Content = "00:00";
            timenow.Content = "00:00";
            
        }

        private void adder_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            player.Open(new Uri(dlg.FileName, UriKind.Relative));
            player.Pause();
            mp3box.Items.Add(dlg.FileName);
        }

        private void volumeline_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            player.Volume = volumeline.Value;
        }

        private void playpause_Click(object sender, RoutedEventArgs e)
        {
            if (mp3box.Items.Count != 0)
            {
                try
                {
                    if (playing == false)
                    {
                        player.Play();
                        playing = true;
                        playpause.Content = "Pause";
                    }
                    else
                    {
                        player.Pause();
                        playing = false;
                        playpause.Content = "Play";
                    }
                }
                catch
                {
                    
                }
            }
            else
            {
                MessageBox.Show("ты дебил музыку добавь");
            }
        }

        private void stoper_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            playpause.Content = "Play";
            playing = false;
        }

        private void Player_MediaOpened(object sender, EventArgs e)
        {
            Duration d = player.NaturalDuration;
            timeline.Maximum = Convert.ToInt32(d.TimeSpan.TotalSeconds);
            timeall.Content = d.TimeSpan.Minutes.ToString() + ':' + d.TimeSpan.Seconds.ToString();
        }

        private void timeline_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int timeis = Convert.ToInt32(timeline.Value);
            player.Position = new TimeSpan(0, 0, timeis);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            timenow.Content = player.Position.Minutes.ToString() + ':' + player.Position.Seconds.ToString();
            
            timeline.Value = Convert.ToInt32(player.Position.TotalSeconds);
        }

        private void mp3box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indnum = mp3box.SelectedIndex;
            player.Stop();
            player.Open(new Uri(mp3box.SelectedValue.ToString(), UriKind.Relative));
            player.Play();
        }

        private void looper_Click(object sender, RoutedEventArgs e)
        {
            if(playlooping == false)
            {
               
            }
        }

        private void randomizator_Click(object sender, RoutedEventArgs e)
        {
            if(playline == true)
            {
                randomizator.Content = "random";
                playline = false;


            }
            else
            {
                randomizator.Content = "line";
                playline = true;
            }
        }

        private void Player_MediaEnded(object sender, EventArgs e)
        {
           
            if (playline == true)
            {
                
                if (mp3box.Items.Count != 1)
                {
                    
                    if (mp3box.Items.Count > mp3box.SelectedIndex + 1)
                    {
                        mp3box.SelectedItem = mp3box.Items[indnum];
                        player.Open(new Uri(mp3box.SelectedValue.ToString(), UriKind.Relative));
                    }
                    else
                    {
                        indnum = 0;
                        mp3box.SelectedItem = mp3box.Items[indnum];
                        player.Open(new Uri(mp3box.SelectedValue.ToString(), UriKind.Relative));
                    }
                }
                else
                {
                    player.Stop();
                }
            }
            else
            if(playline == false)
            {
                for (int rand = indnum; rand == indnum;)
                {
                    rand = rnd.Next(0, mp3box.Items.Count);
                    if (rand == indnum)
                    {
                        
                    }
                    else
                    {
                        indnum = rand;
                        mp3box.SelectedItem = mp3box.Items[rand];
                        player.Open(new Uri(mp3box.SelectedValue.ToString(), UriKind.Relative));
                        player.Play();
                        break;
                    }
                }
            }
        }
    }


}