using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace DataConverters
{
    /// <summary>
    /// Interaction logic for Addform.xaml
    /// </summary>
    public partial class Addform : Window
    {
        OleDbConnection conn;
        public Addform()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            string connStr = "Provider = Microsoft.Jet.OLEDB.4.0; " 
                             + "Data Source = Converters.mdb";

            conn = new OleDbConnection(connStr);
            conn.Open();

            string insertString = "insert into Courses(RefNum,Department,[Number],Name, InstructorFirstName, InstructorLastName, ClassSize, NumEnrolled) values(?,?,?,?,?,?,?,?)";
           
            using (OleDbCommand insert = new OleDbCommand(insertString, conn))
            {
                insert.Parameters.AddWithValue("RefNum", ref_num.Text);
                insert.Parameters.AddWithValue("Department", dept.Text);
                insert.Parameters.AddWithValue("Number", numb.Text);
                insert.Parameters.AddWithValue("Name", name.Text);
                insert.Parameters.AddWithValue("InstructorFirstName", first_name.Text);
                insert.Parameters.AddWithValue("InstructorLastName", last_name.Text);
                insert.Parameters.AddWithValue("ClassSize", class_size.Text);
                insert.Parameters.AddWithValue("NumEnrolled", no_enrolled.Text);
                insert.ExecuteNonQuery();
                conn.Close();
                this.Close();
                MainWindow main = new MainWindow();
                main.Show();
            }
        }
    }
}
