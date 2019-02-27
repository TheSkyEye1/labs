using System;
using System.Collections.Generic;
using System.IO;
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
    /// <summary>
    /// Логика взаимодействия для Filework.xaml
    /// </summary>
    public partial class Filework : Window
    {
        public Filework()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            Open.FontSize = 70;
            Save.FontSize = 70;
            F1.Header = "File";
            Open.Header = "Open";
            Save.Header = "Save";
            backbfw.Content = "Back";
        }

        private void Backbfw_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            string line;
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";
            dlg.ShowDialog();
            System.IO.StreamReader file = new System.IO.StreamReader(dlg.FileName);
            while ((line = file.ReadLine()) != null)
            {
                
                textboxfl.Text += line + Environment.NewLine;
            }
            file.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; 
            dlg.DefaultExt = ".txt"; 
            dlg.Filter = "Text documents (.txt)|*.txt";                                                       
            dlg.ShowDialog();

            using (StreamWriter outputFile = new StreamWriter(dlg.FileName))
            {
                //lines – массив строк
                string lines = textboxfl.Text;
             //  foreach (string line in lines)
                    outputFile.WriteLine(lines);
            }


        }

        private void Rusckfw_Checked(object sender, RoutedEventArgs e)
        {
            if(rusckfw.IsChecked == true)
            {
                F1.Header = "Файл";
                Open.FontSize = 55;
                Save.FontSize = 55;
                Open.Header = "Открыть";
                Save.Header = "Сохранить";
                backbfw.Content = "Назад";
            }
        }

        private void Backbfw_MouseEnter(object sender, MouseEventArgs e)
        {
            backbfw.Height = 117;
            backbfw.Width = 412;
        }

        private void Backbfw_MouseLeave(object sender, MouseEventArgs e)
        {
            backbfw.Height = 108;
            backbfw.Width = 384;
        }
    }
}
