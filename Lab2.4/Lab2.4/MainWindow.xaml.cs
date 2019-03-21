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
using System.Data.SQLite;

namespace Lab2._4
{
    public partial class MainWindow : Window
    {



        public class SStudent
        {
            public int Unicid { get; set; }
            public string Fio { get; set; }
            public int Math { get; set; }
            public int Phys { get; set; }
        }

        List<SStudent> slist = new List<SStudent>();

        string dbname = "";

        public MainWindow()
        {
            InitializeComponent();
            datgr.IsReadOnly = true;

                datgr.SelectedCellsChanged += Datgr_SelectedCellsChanged;

            mathbox.Text = "";
            physbox.Text = "";
            namebox.Text = "";
            unicidbox.Text = "";
            
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            datgr.IsEnabled = true;
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.ShowDialog();
            dbname = dlg.FileName;
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=" + dbname + ";Version=3;");
            m_dbConnection.Open();
            string sql = "SELECT * FROM student, info WHERE student.unicid = info.unicid";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SStudent stud = new SStudent();
                stud.Fio = reader["fio"].ToString();
                stud.Unicid = int.Parse(reader["unicid"].ToString());
                stud.Math = int.Parse(reader["math"].ToString());
                stud.Phys = int.Parse(reader["phys"].ToString());
                slist.Add(stud);
            }

            datgr.ItemsSource = slist;
            datgr.Items.Refresh();
            m_dbConnection.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
            if (dbname != "" && unicidbox.Text != "" && mathbox.Text != "" && namebox.Text != "" && physbox.Text != "")
            {
                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=" + dbname + ";Version=3;");
                m_dbConnection.Open();
                string sql4 = "SELECT unicid FROM student";
                SQLiteCommand command = new SQLiteCommand(sql4, m_dbConnection);
                command.ExecuteNonQuery();

                try
                {
                    string sql = "INSERT INTO student (unicid, fio) VALUES (" + unicidbox.Text + ",'" + namebox.Text + "')";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();

                    string sql2 = "INSERT INTO info (unicid, math, phys) VALUES (" + unicidbox.Text + "," + mathbox.Text + "," + physbox.Text + ")";

                    command = new SQLiteCommand(sql2, m_dbConnection);

                    command.ExecuteNonQuery();

                    SStudent stud = new SStudent();
                    stud.Fio = namebox.Text;
                    stud.Unicid = int.Parse(unicidbox.Text);
                    stud.Math = int.Parse(mathbox.Text);
                    stud.Phys = int.Parse(physbox.Text);
                    slist.Add(stud);
                    datgr.ItemsSource = null;
                    datgr.ItemsSource = slist;
                    datgr.Items.Refresh();
                    m_dbConnection.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Error: Invalid ID");
                };

                
            }
            else
            {
                if (unicidbox.Text == "")
                {
                    MessageBox.Show("Incorrect value of ID");
                }
                else
                if (namebox.Text == "")
                {
                    MessageBox.Show("Incorrect Name");
                }
                else
                if (mathbox.Text == "")
                {
                    MessageBox.Show("Incorrect value of Math");
                }
                else
                if (physbox.Text == "")
                {
                    MessageBox.Show("Incorrect value of Phys");
                }
            }

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            if (dbname != "" && unicidbox.Text != "" && mathbox.Text != "" && namebox.Text != "" && physbox.Text != "")
            {
                if (datgr.SelectedIndex > -1)
                {
                    SQLiteConnection m_dbConnection;
                    m_dbConnection = new SQLiteConnection("Data Source=" + dbname + ";Version=3;");
                    m_dbConnection.Open();

                    string sql3 = " UPDATE student SET fio = '" + namebox.Text + "' WHERE unicid =" + unicidbox.Text + ";" + " UPDATE info SET math = " + mathbox.Text + ", phys =" + physbox.Text + " WHERE unicid =" + unicidbox.Text;
                    SQLiteCommand command = new SQLiteCommand(sql3, m_dbConnection);
                    command.ExecuteNonQuery();

                    slist[datgr.SelectedIndex].Fio = namebox.Text;
                    ((SStudent)datgr.Items[datgr.SelectedIndex]).Fio = namebox.Text;
                    ((SStudent)datgr.Items[datgr.SelectedIndex]).Math = int.Parse(physbox.Text);
                    ((SStudent)datgr.Items[datgr.SelectedIndex]).Phys = int.Parse(mathbox.Text);
                    datgr.Items.Refresh();
                }
            }
        }

        private void Datgr_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dbname != "" && unicidbox.Text != "" && mathbox.Text != "" && namebox.Text != "" && physbox.Text != "")
            {

                try
                {
                    namebox.Text = ((SStudent)datgr.Items[datgr.SelectedIndex]).Fio;
                    mathbox.Text = ((SStudent)datgr.Items[datgr.SelectedIndex]).Math.ToString();
                    physbox.Text = ((SStudent)datgr.Items[datgr.SelectedIndex]).Phys.ToString();
                    unicidbox.Text = ((SStudent)datgr.Items[datgr.SelectedIndex]).Unicid.ToString();
                }
                catch { };
            }

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

            if (datgr.SelectedIndex > -1)
            {
                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=" + dbname + ";Version=3;");
                m_dbConnection.Open();

                string sql3 = " DELETE FROM student WHERE unicid = " + ((SStudent)datgr.Items[datgr.SelectedIndex]).Unicid + ";" + " DELETE FROM info WHERE unicid = " + ((SStudent)datgr.Items[datgr.SelectedIndex]).Unicid;
                SQLiteCommand command = new SQLiteCommand(sql3, m_dbConnection);
                command.ExecuteNonQuery();

                slist.RemoveAt(datgr.SelectedIndex);
                datgr.Items.Refresh();
            }

        }

    
    }
}
