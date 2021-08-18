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
    public partial class AddUser : Form
    {
        private readonly Car_RentalEntities car_RentalEntities;
        private Manage_Users _manageUsers;
        public AddUser(Manage_Users manage_Users)
        {
            InitializeComponent();
            car_RentalEntities = new Car_RentalEntities();
            _manageUsers = manage_Users;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = car_RentalEntities.Roles.ToList();
            comboRole.DataSource = roles;
            comboRole.ValueMember = "Id";
            comboRole.DisplayMember = "Name";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var Username = txt_UserName.Text;
                var RoleId = (int)comboRole.SelectedValue;
                
                //var password = Utils.DefaultHashedPassword();
                var user = new User
                {
                    Username = Username,
                    //Password = password,
                    isActive = true


                };
                car_RentalEntities.Users.Add(user);
                car_RentalEntities.SaveChanges();

                var userid = user.Id;

                var userRole = new UserRole
                {
                    RoleId = RoleId,
                    UserId = userid
                };
                car_RentalEntities.UserRoles.Add(userRole);
                car_RentalEntities.SaveChanges();
                MessageBox.Show("New User Added Successfully");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Has Occured");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}