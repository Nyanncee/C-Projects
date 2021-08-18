using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public User _user;
        public string _roleName;
      
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
          
        }

        private void addRentalRecord_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddRentalRecord")) {
                var addRentalRecord = new AddRentalRecord();
                //showing one instance of window
                addRentalRecord.ShowDialog();

                //this represents the MainWindow here
                addRentalRecord.MdiParent = this;
                // if (!Utils.FormIsOpen("AddRecord")) ;

            }
        }
        private void manageVehicle_click_Click(object sender, EventArgs e)
        { 
            //gives list of open forms of all datatypes Form
            //var OpenForms = Application.OpenForms.Cast<Form>();
            //var isOpen = OpenForms.Any(q => q.Name == "Manage_Vehicle_Listing");
            if (!Utils.FormIsOpen("Manage_Vehicle_Listing"))
            {
                var vehicleListing = new Manage_Vehicle_Listing();
                vehicleListing.MdiParent = this;

                vehicleListing.Show();
            }
            

        }
        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageRenatlRecords"))
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsers_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageRentalRecords"))
            {
                var manageUsers = new Manage_Users();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //if(_user.Password == Password_Reset())
            //{
                var resetPassword = new Password_Reset(_user);
                resetPassword.ShowDialog();
            //}

            var username = _user.Username;
            toolStripLabel.Text = $"Logged In As : {username}";
            if(_roleName != "admin")
            {
                manageUsers.Visible = false;
            }
            else
            {
                manageUsers.Enabled = true;
            }
        }

        
    }
}
