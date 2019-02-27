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

namespace NormalWpfApp
{

    
    
    public partial class MainWindow : Window
    {
        int a = 0;
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
       

        
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;

            sp.SoundLocation = @"C:\Users\golov\OneDrive\Рабочий стол\project resource\NormalWpfApp\NormalWpfApp\Resources\backmus.wav";
            sp.Load();


        }



        private void Mus23_Click(object sender, RoutedEventArgs e)
        {
            sp.Stop();
            
            mus23.Visibility = Visibility.Hidden;
            mus32.Visibility = Visibility.Visible;
        }

        private void Mus32_Click_1(object sender, RoutedEventArgs e)
        {
            sp.PlayLooping();
            
            mus23.Visibility = 0;
            mus32.Visibility = Visibility.Hidden;
        }

        private void Exitb_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Eng_Click(object sender, RoutedEventArgs e)
        {
            Eng.Opacity = 1;
            Rus.Opacity = 0.5;
            menub.Content = "Menu";
            exitb.Content = "Exit";
            create.Content = "Created by LeninskieDikari™";
            muslb.Content = "Music";
            muslb.FontSize = 16;
            a = 0;
        }

        private void Rus_Click(object sender, RoutedEventArgs e)
        {
            Eng.Opacity = 0.5;
            Rus.Opacity = 1;
            menub.Content = "Меню";
            exitb.Content = "Выход";
            create.Content = "Создано LeninskieDikari™";
            muslb.Content = "Музыка";
            muslb.FontSize = 12;
            a = 1;
        }

        private void Menub_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            if(a == 1)
            {
                w.rusck.IsChecked = true;
            }
            w.Show();
        }

        private void Menub_MouseEnter(object sender, MouseEventArgs e)
        {
            menub.Height = 117;
            menub.Width = 412;
        }

        private void Menub_MouseLeave(object sender, MouseEventArgs e)
        {
            menub.Height = 108;
            menub.Width = 384;
        }

        private void Exitb_MouseEnter(object sender, MouseEventArgs e)
        {
            exitb.Height = 117;
            exitb.Width = 412;
        }

        private void Exitb_MouseLeave(object sender, MouseEventArgs e)
        {
            exitb.Height = 108;
            exitb.Width = 384;
        }
    }
}
