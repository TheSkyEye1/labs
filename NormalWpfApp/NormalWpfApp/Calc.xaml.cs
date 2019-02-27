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
   
    public partial class Calc : Window
    {
        int a = 0;
        int b = 0;
        double i = 0;
        double g = 0;

        public Calc()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            AL.Content = "Number A";
            BL.Content = "Number B";
            RE.Content = "Result";
            BackBFirst.Content = "Back";
        }

        private void BackBFirst_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PLUS_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int b = 0;
            if (NumA.Text == "")
            {
                a = 0;

            }
            else
            {
                a = int.Parse(NumA.Text);

            }
      
            
                if (NumB.Text == "")
                {
                    b = 0;
                }
                else
                {
                    b = int.Parse(NumB.Text);
                }
           
            
            NumC.Content = (a + b).ToString();
        }

        private void MINUS_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int b = 0;
            if (NumA.Text == "")
            {
                a = 0;

            }
            else
            {
                a = int.Parse(NumA.Text);

            }
            
            
                if (NumB.Text == "")
                {
                    b = 0;
                }
                else
                {
                    b = int.Parse(NumB.Text);
                }
            
           
            NumC.Content = (a - b).ToString();
        }

        private void MULT_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int b = 0;
            if (NumA.Text == "")
            {
                a = 0;
               
            }
            else
            {
                a = int.Parse(NumA.Text);

            }
           
                if (NumB.Text == "")
                {
                    b = 0;
                }
                else
                {
                    b = int.Parse(NumB.Text);
                }
            
           
            NumC.Content = (a * b).ToString();
        }

        private void SPLIT_Click(object sender, RoutedEventArgs e)
        {
            
            double i = 0; double g = 0;
            if (NumA.Text == "")
            {
                i = 0;
                
            }
            else
            {
                i = double.Parse(NumA.Text);
                
            }
            
                if (NumB.Text == "")
                {
                    g = 0;
                }
                else
                {
                    g = double.Parse(NumB.Text);
                }
            
            
            if (g != 0)
            {
                NumC.Content = (i / g).ToString();
            }
            else
                NumC.Content = "Error";
        }

        private void SPLIT_MouseEnter(object sender, MouseEventArgs e)
        {
            SPLIT.Foreground = Brushes.White;
           
        }

        private void SPLIT_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();

            SPLIT.Foreground = (Brush)bc.ConvertFrom("#FF072742");
            errorcalc.Content = "";
        }

        private void Rusckclc_Checked(object sender, RoutedEventArgs e)
        {
            if(rusckclc.IsChecked == true)
            {
                AL.Content = "Число А";
                BL.Content = "Число Б";
                RE.Content = "Результат";
                BackBFirst.Content = "Назад";

            }
        }

        private void PLUS_MouseEnter(object sender, MouseEventArgs e)
        {
            PLUS.Foreground = Brushes.White;
        }

        private void PLUS_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();

            PLUS.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }

        private void MINUS_MouseEnter(object sender, MouseEventArgs e)
        {
            MINUS.Foreground = Brushes.White;
        }

        private void MINUS_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();

            MINUS.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }

        private void MULT_MouseEnter(object sender, MouseEventArgs e)
        {
            MULT.Foreground = Brushes.White;
        }

        private void MULT_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();

            MULT.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }
    }
}
