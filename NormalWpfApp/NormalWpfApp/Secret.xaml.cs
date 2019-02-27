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
    
    public partial class Secret : Window
    {
        int a = 0;
        int b = 0;
        int i = 0;
        int tim = 0;
        double suc = 0;
        Random rnd = new Random();
        System.Windows.Threading.DispatcherTimer Timer;
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\golov\OneDrive\Рабочий стол\project resource\NormalWpfApp\NormalWpfApp\Resources\oof.wav");
        public Secret()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            funbut.Content = "Click me";
            backb.Content = "Back";
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
        }

        

        private void Funbut_MouseEnter(object sender, MouseEventArgs e)
        {
            a = rnd.Next(-1500, 1500);
            b = rnd.Next(-900, 900);
            funbut.Margin = new Thickness(a, b, 0, 0);
            i++;
            if(i > 24)
            {
                backb.Visibility = Visibility.Visible;
                backb.IsEnabled = true;
            }
        }

        private void Backb_Click(object sender, RoutedEventArgs e)
        {
            funbut.Visibility = Visibility.Hidden;
            backb.Visibility = Visibility.Hidden;
            Timer.Start();
        }

        private void Ruscksc_Checked(object sender, RoutedEventArgs e)
        {
            if (ruscksc.IsChecked == true)
            {
                funbut.Content = "Нажми";
                backb.Content = "Назад";
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if(tim == 0)
            {
                sp.Play();
            }
            tim++;
            if(tim > 6)
            {
                udedb.Opacity = suc;
                suc += 0.1;
            }
            if(tim > 45)
            {
                Close();
            }
        }

        private void Funbut_Click(object sender, RoutedEventArgs e)
        {
            funbut.Visibility = Visibility.Hidden;
            backb.Visibility = Visibility.Hidden;
            Timer.Start();
        }

        private void Backb_MouseEnter(object sender, MouseEventArgs e)
        {
            backb.Foreground = Brushes.White;
        }

        private void Backb_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();

            backb.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }
    }
}
