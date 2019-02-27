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
    
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            if (rusck.IsChecked == false)
            {
                First.Content = "Calculator";
                Second.Content = "Notebook";
                Third.Content = "Planetary";
                Forth.Content = "Timer";
                Fith.Content = "Work with Files";
                Sixth.Content = "Secret";
                BackB.Content = "Back";
            }
        }

        private void BackB_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Rusck_Checked(object sender, RoutedEventArgs e)
        {
            if (rusck.IsChecked == true)
            {
               
                First.Content = "Калькулятор";
                Second.Content = "Записная Книга";
                Third.Content = "Планетарий";
                Forth.Content = "Таймер";
                Fith.Content = "Работа с Файлами";
                Sixth.Content = "Секрет";
                BackB.Content = "Назад";
            }
            
        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            Calc a = new Calc();
            if (rusck.IsChecked == true)
            {
                a.rusckclc.IsChecked = true;
            }
                a.Show();
        }

        private void Second_Click(object sender, RoutedEventArgs e)
        {
            
                Notebook a = new Notebook();
            if (rusck.IsChecked == true)
            {
                a.ruscknb.IsChecked = true;
            }
                a.Show();
        }

        private void Third_Click(object sender, RoutedEventArgs e)
        {
            Planetary a = new Planetary();
            if(rusck.IsChecked == true)
            {
                a.rusckpl.IsChecked = true;
            }
            a.Show();
        }

        private void Forth_Click(object sender, RoutedEventArgs e)
        {
            Timing a = new Timing();
            if(rusck.IsChecked == true)
            {
                a.ruscktim.IsChecked = true;
            }
            a.Show();
        }

        private void Fith_Click(object sender, RoutedEventArgs e)
        {
            
            Filework a = new Filework();
            if(rusck.IsChecked == true)
            {
                a.rusckfw.IsChecked = true;
            }
            a.Show();
        }

        private void Sixth_Click(object sender, RoutedEventArgs e)
        {
            Secret a = new Secret();
            if(rusck.IsChecked == true)
            {
                a.ruscksc.IsChecked = true;
            }
            a.Show();
        }

        private void First_MouseEnter(object sender, MouseEventArgs e)
        {
            First.Width = 414 ;
            First.Height = 117;
            First.Opacity = 1;
        }

        private void First_MouseLeave(object sender, MouseEventArgs e)
        {
            First.Width = 384;
            First.Height = 108;
            First.Opacity = 0.8;
        }

        private void Second_MouseEnter(object sender, MouseEventArgs e)
        {
            Second.Width = 414;
            Second.Height = 117;
            Second.Opacity = 1;
        }

        private void Second_MouseLeave(object sender, MouseEventArgs e)
        {
           Second.Width = 384;
            Second.Height = 108;
            Second.Opacity = 0.8;
        }

        private void Third_MouseEnter(object sender, MouseEventArgs e)
        {
            Third.Width = 414;
            Third.Height = 117;
            Third.Opacity = 1;
        }

        private void Third_MouseLeave(object sender, MouseEventArgs e)
        {
            Third.Width = 384;
            Third.Height = 108;
            Third.Opacity = 0.8;
        }

        private void Forth_MouseEnter(object sender, MouseEventArgs e)
        {
            Forth.Width = 414;
            Forth.Height = 117;
            Forth.Opacity = 1;
        }

        private void Forth_MouseLeave(object sender, MouseEventArgs e)
        {
            Forth.Width = 384;
            Forth.Height = 108;
            Forth.Opacity = 0.8;
        }

        private void Fith_MouseEnter(object sender, MouseEventArgs e)
        {
            Fith.Width = 414;
            Fith.Height = 117;
            Fith.Opacity = 1;
        }

        private void Fith_MouseLeave(object sender, MouseEventArgs e)
        {
            Fith.Width = 384;
            Fith.Height = 108;
            Fith.Opacity = 0.8;
        }

        private void Sixth_MouseEnter(object sender, MouseEventArgs e)
        {
            Sixth.Width = 414;
            Sixth.Height = 117;
            Sixth.Opacity = 1;
        }

        private void Sixth_MouseLeave(object sender, MouseEventArgs e)
        {
            Sixth.Width = 384;
            Sixth.Height = 108;
            Sixth.Opacity = 0.8;
        }

        private void BackB_MouseEnter(object sender, MouseEventArgs e)
        {
            BackB.Width = 414;
            BackB.Height = 117;
        }

        private void BackB_MouseLeave(object sender, MouseEventArgs e)
        {
            BackB.Width = 384;
            BackB.Height = 108;
        }
    }
}
