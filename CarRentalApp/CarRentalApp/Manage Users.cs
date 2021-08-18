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
    public partial class Manage_Users : Form
    {
        private readonly Car_RentalEntities car_RentalEntities;
        public Manage_Users()
        {
            InitializeComponent();
            car_RentalEntities = new Car_RentalEntities();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent = this.MdiParent;
                addUser.Show();

            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dGManageUsers.SelectedRows[0].Cells["Id"].Value;

                var user = car_RentalEntities.Users.FirstOrDefault(q => q.Id == id);
              
                //hashing the generic password
                //var hashed_password = Utils.DefaultHashedPassword();
                //user.Password = hashed_password;
                car_RentalEntities.SaveChanges();

                MessageBox.Show($"{user.Username}'s Password has been reset!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dGManageUsers.SelectedRows[0].Cells["Id"].Value;

                var user = car_RentalEntities.Users.FirstOrDefault(q => q.Id == id);
                //if(user.isActive == true)
                //user.isActive = false;
                //else
                //user.isActive = true;
                user.isActive = user.isActive == true ? false : true;

                car_RentalEntities.SaveChanges();

                MessageBox.Show($"{user.Username}'s active status has changed!");
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ManageUsers_Load(object sender, EventArgs e) {
            PopulateGrid();
        }
            public void PopulateGrid()
            {
            var users = car_RentalEntities.Users
                .Select(q => new
                {
                    q.Id,
                    q.Username


                }).ToList();
            dGManageUsers.DataSource = users;
            dGManageUsers.Columns["Username"].HeaderText = "Username";
            dGManageUsers.Columns["name"].HeaderText = "Role Name";
            dGManageUsers.Columns["isActive"].HeaderText = "Active";

            dGManageUsers.Columns["Id"].Visible = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
    }

