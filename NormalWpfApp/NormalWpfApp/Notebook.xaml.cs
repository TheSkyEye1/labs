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
    
    public partial class Notebook : Window
    {
       
        int i = 0;
        public Notebook()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            nbt.FontSize = 45;
            addbox.Content = "Add";
            BackBnb.Content = "Back";
            nbt.Text = "write here your most terrible secrets :)";
            nbtl.Text = "Text Store";
        }

        private void BackBnb_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Addbox_Click(object sender, RoutedEventArgs e)
        {
            string a;
            a = nbt.Text;
            notebox.Items.Add(a);
            nbt.Text = null;
        }

        private void Nbt_MouseEnter(object sender, MouseEventArgs e)
        {
            if(i == 0)
            {
                nbt.Text = "";
                i++;
            }
            

        }

        private void Ruscknb_Checked(object sender, RoutedEventArgs e)
        {
            if(ruscknb.IsChecked == true)
            {
                addbox.Content = "Добавить";
                BackBnb.Content = "Назад";
                nbt.FontSize = 40;
                nbt.Text = "напиши здесь свои самые потаенные секреты :)";
                nbtl.Text = "Хранилище";
            }
        }

        private void BackBnb_MouseEnter(object sender, MouseEventArgs e)
        {
            BackBnb.Foreground = Brushes.White;
        }

        private void BackBnb_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();

            BackBnb.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }

        private void Addbox_MouseEnter(object sender, MouseEventArgs e)
        {
            addbox.Foreground = Brushes.White;
        }

        private void Addbox_MouseLeave(object sender, MouseEventArgs e)
        {
            var bc = new BrushConverter();
            addbox.Foreground = (Brush)bc.ConvertFrom("#FF072742");
        }
    }
}
