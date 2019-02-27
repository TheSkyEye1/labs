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
using System.Windows.Shapes;

namespace NormalWpfApp
{
   
    public partial class Timing : Window
    {

        

        System.Windows.Threading.DispatcherTimer Timer;
        int sec = 0;
        int min = 0;
        int hou = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        public Timing()
        {
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            InitializeComponent();
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Starter.Content = "Start";
            Stoper.Content = "Stop";
            Reseter.Content = "Reset";
            Secer.Content = "Second";
            Miner.Content = "Minute";
            Houer.Content = "Hour";
            Backer.Content = "Back";
        }

        private void Starter_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }

        private void Stoper_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void Reseter_Click(object sender, RoutedEventArgs e)
        {
            sec = 0;
            min = 0;
            hou = 0;
            secoti.Content = "00";
            minuti.Content = "00";
            hourti.Content = "00";
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {


            sec++;
            min += sec / 60;
            hou += min / 60;
            if (secbox.IsChecked == true && minbox.IsChecked == true && houbox.IsChecked == true)
            {
                if (sec < 10)
                {
                    secoti.Content = "0" + sec.ToString();
                }
                else
                {
                    secoti.Content = sec.ToString();
                }
                if (min < 10)
                {
                    minuti.Content = "0" + min.ToString();
                }
                else
                {
                    minuti.Content = min.ToString();
                }
                if (hou < 10)
                {
                    hourti.Content = "0" + hou.ToString();
                }
                else
                {
                    hourti.Content = hou.ToString();
                }
                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == true && minbox.IsChecked == true && houbox.IsChecked == false)
            {
                if (sec < 10)
                {
                    secoti.Content = "0" + sec.ToString();
                }
                else
                {
                    secoti.Content = sec.ToString();
                }
                if (min < 10)
                {
                    minuti.Content = "0" + min.ToString();
                }
                else
                {
                    minuti.Content = min.ToString();
                }

                hourti.Content = "--";


                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == true && minbox.IsChecked == false && houbox.IsChecked == false)
            {
                if (sec < 10)
                {
                    secoti.Content = "0" + sec.ToString();
                }
                else
                {
                    secoti.Content = sec.ToString();
                }

                minuti.Content = "--";



                hourti.Content = "--";

                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == true && minbox.IsChecked == false && houbox.IsChecked == true)
            {
                if (sec < 10)
                {
                    secoti.Content = "0" + sec.ToString();
                }
                else
                {
                    secoti.Content = sec.ToString();
                }

                minuti.Content = "--";

                if (hou < 10)
                {
                    hourti.Content = "0" + hou.ToString();
                }
                else
                {
                    hourti.Content = hou.ToString();
                }
                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == false && minbox.IsChecked == true && houbox.IsChecked == false)
            {

                secoti.Content = "--";

                if (min < 10)
                {
                    minuti.Content = "0" + min.ToString();
                }
                else
                {
                    minuti.Content = min.ToString();
                }

                hourti.Content = "--";

                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == true && minbox.IsChecked == true && houbox.IsChecked == false)
            {
                if (sec < 10)
                {
                    secoti.Content = "0" + sec.ToString();
                }
                else
                {
                    secoti.Content = sec.ToString();
                }
                if (min < 10)
                {
                    minuti.Content = "0" + min.ToString();
                }
                else
                {
                    minuti.Content = min.ToString();
                }

                hourti.Content = "--";

                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == false && minbox.IsChecked == true && houbox.IsChecked == true)
            {


                secoti.Content = "--";

                if (min < 10)
                {
                    minuti.Content = "0" + min.ToString();
                }
                else
                {
                    minuti.Content = min.ToString();
                }
                if (hou < 10)
                {
                    hourti.Content = "0" + hou.ToString();
                }
                else
                {
                    hourti.Content = hou.ToString();
                }
                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == false && minbox.IsChecked == false && houbox.IsChecked == true)
            {

                secoti.Content = "--";



                minuti.Content = "--";

                if (hou < 10)
                {
                    hourti.Content = "0" + hou.ToString();
                }
                else
                {
                    hourti.Content = hou.ToString();
                }
                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
             if (secbox.IsChecked == true && minbox.IsChecked == false && houbox.IsChecked == true)
            {
                if (sec < 10)
                {
                    secoti.Content = "0" + sec.ToString();
                }
                else
                {
                    secoti.Content = sec.ToString();
                }


                minuti.Content = "--";

                if (hou < 10)
                {
                    hourti.Content = "0" + hou.ToString();
                }
                else
                {
                    hourti.Content = hou.ToString();
                }
                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == false && minbox.IsChecked == true && houbox.IsChecked == true)
            {

                secoti.Content = "--";

                if (min < 10)
                {
                    minuti.Content = "0" + min.ToString();
                }
                else
                {
                    minuti.Content = min.ToString();
                }
                if (hou < 10)
                {
                    hourti.Content = "0" + hou.ToString();
                }
                else
                {
                    hourti.Content = hou.ToString();
                }
                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;
                }
            }
            else
            if (secbox.IsChecked == false && minbox.IsChecked == false && houbox.IsChecked == false)
            {

                secoti.Content = "--";






                minuti.Content = "--";


                hourti.Content = "--";

                if (sec == 60)
                {
                    sec = 0;
                }
                if (min == 60)
                {
                    min = 0;
                }
                if (hou == 99)
                {
                    hou = 0;


                }
            }
        }

                private void Backer_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void Secer_Click(object sender, RoutedEventArgs e)
        {
            if (secbox.IsChecked == true)
            {
                secbox.IsChecked = false;
                seclb.Content = "Off";
            }

            else
            {
                secbox.IsChecked = true;
                seclb.Content = "On";
            }
        }

        private void Miner_Click(object sender, RoutedEventArgs e)
        {
            if (minbox.IsChecked == true)
            {
                minbox.IsChecked = false;
                minlb.Content = "Off";
            }

            else
            { minbox.IsChecked = true;
                minlb.Content = "On";
                    }
        }


        private void Houer_Click(object sender, RoutedEventArgs e)
        {
            if (houbox.IsChecked == true)
            {
                houbox.IsChecked = false;
                houlb.Content = "Off";
            }
            else
            {
                houbox.IsChecked = true;
                houlb.Content = "On";
            }
        }

        private void Ruscktim_Checked(object sender, RoutedEventArgs e)
        {
            if(ruscktim.IsChecked == true)
            {
                Starter.Content = "Старт";
                Stoper.Content = "Стоп";
                Reseter.Content = "Сброс";
                Secer.Content = "Секунды";
                Miner.Content = "Минуты";
                Houer.Content = "Часы";
                Backer.Content = "Назад";
            }
        }

        private void Starter_MouseEnter(object sender, MouseEventArgs e)
        {
            Starter.Foreground = Brushes.White;
        }

        private void Starter_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Starter.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }

        private void Stoper_MouseEnter(object sender, MouseEventArgs e)
        {
            Stoper.Foreground = Brushes.White;
        }

        private void Stoper_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Stoper.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }

        private void Reseter_MouseEnter(object sender, MouseEventArgs e)
        {
            Reseter.Foreground = Brushes.White;
        }

        private void Reseter_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            Reseter.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }

        private void Backer_MouseEnter(object sender, MouseEventArgs e)
        {
            Backer.Height = 117;
            Backer.Width = 400;
        }

        private void Backer_MouseLeave(object sender, MouseEventArgs e)
        {
            Backer.Height = 108;
            Backer.Width = 384;
        }
    }
}
