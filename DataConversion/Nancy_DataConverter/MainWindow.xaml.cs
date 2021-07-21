using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace DataConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection conn;

        public MainWindow()
        {
            InitializeComponent();
            string connStr =
             "Provider = Microsoft.Jet.OLEDB.4.0;" + "Data Source = Converters.mdb";


            conn = new OleDbConnection(connStr);
            conn.Open();

            using (OleDbCommand cmd =
                new OleDbCommand("select * from Courses", conn))
            {
                dg2.ItemsSource = cmd.ExecuteReader();
                dg2.Items.Refresh();
            }
        }
        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            Addform ac = new Addform();
            ac.Show();
        }

        private void dg2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            {
                DataGrid dg2 = (DataGrid)sender;

                var row = dg2.SelectedItem as DbDataRecord;
                Addform c = new Addform();

                c.ref_num.Text = row.GetValue(0).ToString();
                c.dept.Text = row.GetValue(1).ToString();
                c.numb.Text = row.GetValue(2).ToString();
                c.name.Text = row.GetValue(3).ToString();
                c.first_name.Text = row.GetValue(4).ToString();
                
                c.last_name.Text = row.GetValue(5).ToString();
                c.class_size.Text = row.GetValue(6).ToString();
                c.no_enrolled.Text = row.GetValue(7).ToString();
                c.Show();
            }
        }
    }
    }

