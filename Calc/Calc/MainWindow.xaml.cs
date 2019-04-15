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

namespace Calc
{
    
    
    public partial class MainWindow : Window
    {
        
        double rez = 0;
        string output = "";
        int numeras = 0;
        int action = 0;
        int scob = 0;
        int butt = 0;
        public MainWindow()
        {
            InitializeComponent();
            calcbox.IsReadOnly = true;
        }

        public static int priority(char symbol)
        {
            switch (symbol)
            {
                case '-':
                case '+': return 1;
                case '/':
                case '*': return 2;
                case '(': return 0;
            }

            return -1;
        }

        public static string polandnot(string input)
        {
            string output = "";
            Stack<char> stak = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    output += input[i];
                }
                else
                    if (input[i] == '(')
                {
                    stak.Push(input[i]);
                }
                else
                    if (input[i] == ')')
                {
                    while (stak.Peek() != '(') output += stak.Pop();
                    stak.Pop();
                }
                else
                {
                    if (stak.Count > 0)
                    {
                        if (priority(stak.Peek()) < priority(input[i]))
                        {
                            stak.Push(input[i]);
                        }
                        else
                        {
                            while (stak.Count > 0) output += stak.Pop();
                            stak.Push(input[i]);
                        }
                    }
                    else
                    {
                        stak.Push(input[i]);
                    }
                }

            }
            while (stak.Count > 0) output += stak.Pop();

            return output;
        }

        public static double calculate(string input)
        {
            double rez = 0;
            Stack<double> st = new Stack<double>();

            for (int i = 0; i < input.Length; i++)
            {
               
                if (Char.IsDigit(input[i]) == true)
                {
                    double t = input[i] - '0';
                    
                    st.Push(t);
                }
                else
                {
                    double op2 = st.Pop();
                    double op1 = st.Pop();


                    double op3 = 0;
                    switch (input[i])
                    {
                        case '+':
                            op3 = op1 + op2;
                            Console.WriteLine("{0}+{1}", op1, op2);
                            break;
                        case '-':
                            op3 = op1 - op2;
                            Console.WriteLine("{0}-{1}", op1, op2);
                            break;
                        case '/':
                            op3 = op1 / op2;
                            Console.WriteLine("{0}/{1}", op1, op2);
                            break;
                        case '*':
                            op3 = op1 * op2;
                            Console.WriteLine("{0}*{1}", op1, op2);
                            break;
                    }
                    st.Push(op3);
                }
            }

            rez = st.Pop();

            return rez;
        }




        private void But7_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '7';
                numeras += 1;
            }
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '8';
                numeras += 1;
            }
        }

        private void But9_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '9';
                numeras += 1;
            }
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '4';
                numeras += 1;
            }
        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '5';
                numeras += 1;
            }
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '6';
                numeras += 1;
            }
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '1';
                numeras += 1;
            }
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '2';
                numeras += 1;
            }
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '3';
                numeras += 1;
            }
        }

        private void Butpi_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += 'π';
                numeras += 1;
            }
        }

        private void But0_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += '0';
                numeras += 1;
            }
        }

        private void Bute_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                action = 1;
                calcbox.Text += 'e';
                numeras += 1;
            }
        }

        private void Dellast_Click(object sender, RoutedEventArgs e)
        {
            if(numeras!= 0)
            {
                calcbox.Text = calcbox.Text.Substring(0, calcbox.Text.Length - 1);
                numeras -= 1;
                action = 0;
            }

        }

        private void Delall_Click(object sender, RoutedEventArgs e)
        {

            calcbox.Text = null;
            numeras = 0;
            action = 1;

        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                if (action != 0)
                {
                    calcbox.Text += '+';
                    numeras += 1;
                    action = 0;
                }
            }
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                if (action != 0)
                {
                    calcbox.Text += '-';
                    numeras += 1;
                    action = 0;
                }
            }
        }

        private void Umn_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                if (action != 0)
                {
                    calcbox.Text += '*';
                numeras += 1;
                    action = 0;
                }
            }
        }

        private void Dis_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                if (action != 0)
                {
                    calcbox.Text += '/';
                numeras += 1;
                    action = 0;
                }
            }
        }

        private void Lefts_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                
                calcbox.Text += '(';
                numeras += 1;
                scob += 1;
            }
        }

        private void Rights_Click(object sender, RoutedEventArgs e)
        {
            if (numeras < 24)
            {
                if (scob != 0)
                {
                    calcbox.Text += ')';
                    numeras += 1;
                    
                    scob -= 1;
                }
            }
        }

        private void Rezalt_Click(object sender, RoutedEventArgs e)
        {
            
            string input = calcbox.Text;
            
            output = polandnot(input);
            rez = calculate(output);
            calcbox.Text = output;
            calcbox.Text = rez.ToString();
        }

        private void Themebut_Click(object sender, RoutedEventArgs e)
        {
            if(butt== 0)
            {
                calcbox.Text = output;
                butt = 1;
                themebut.Content = "Пол.Нот.";
            }
            else
            {
                calcbox.Text = rez.ToString(); ;
                butt = 0;
                themebut.Content = "Числа";
            }
        }
    }
}
