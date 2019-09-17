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

namespace _21345678
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dollar;
        int euro;
        int ruble;
        public MainWindow()
        {
            InitializeComponent();

        }
        
        public int maxmin(int rub, int dol, int eur)
        {
            int amin;
            int bmin;
            int x = rub % (5 * dol);
            int y = rub % (5 * eur);
            int ax = x % (2 * dol);
            int ay = x % dol;
            int bx = y % (2 * dol);
            int by = y % dol;
            if (ax > ay)
                amin = ay;
            else
                amin = ax;

            if (bx > by)
                bmin = by;
            else
                bmin = bx;

            if (bmin > amin)
            {
               

                return (amin);
            }
            else
            {
                return (bmin);
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            ruble = Convert.ToInt32(ruba.Text);
            dollar = Convert.ToInt32(dola.Text);
            euro = Convert.ToInt32(eura.Text);
            rubb.Text = Convert.ToString(maxmin(ruble, dollar, euro));
        }
    }
}
