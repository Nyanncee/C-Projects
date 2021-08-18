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
    public partial class Password_Reset : Form
    {
        private readonly Car_RentalEntities car_RentalEntities;
        private User _user;
        public Password_Reset(User user)
        {
            InitializeComponent();
            car_RentalEntities = new Car_RentalEntities();
            _user = user;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var Password = txtNewPassword.Text;
                var confirm_password = txtConfirmPassword.Text;
                var user = car_RentalEntities.Users.FirstOrDefault(q => q.Id == _user.Id);
                if (Password != confirm_password)
                {
                    MessageBox.Show("Password do not match. Please try again!");
                }

                //_user.Password = Utils.DefaultHashedPassword();
                car_RentalEntities.SaveChanges();
                MessageBox.Show("Password was reset successfully");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured. Please try again!");
            }
        }
    }
}
