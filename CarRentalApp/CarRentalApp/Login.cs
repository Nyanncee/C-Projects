using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly Car_RentalEntities car_RentalEntities;
        public Login()
        {
            InitializeComponent();
            car_RentalEntities = new Car_RentalEntities();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create(); //for encryption of password

                var username = txt_Username.Text.Trim(); //takewhitespacesfromusername
                var password = txt_Password.Text;

                //var hashed_password = Utils.HashedPassword(password);

                var user = car_RentalEntities.Users.FirstOrDefault(q => q.Username == username &&
                q.Password == password && q.isActive == true);
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    
                    //roleShortname = user.UserRole.Role.Shortname;
                    var mainWindow = new MainWindow(this,user);
                    mainWindow.Show();
                    Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! Please try again");
            }
        }

       
    }
}
