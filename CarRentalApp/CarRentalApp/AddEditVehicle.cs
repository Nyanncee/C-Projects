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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private Manage_Vehicle_Listing _manage_Vehicle_Listing;
        private readonly Car_RentalEntities car_RentalEntities;

        public AddEditVehicle(Manage_Vehicle_Listing manage_Vehicle_Listing = null)
        {
            InitializeComponent();
            txt_AddEdit.Text = "Add New Vehicle";
            isEditMode = false;
            _manage_Vehicle_Listing = manage_Vehicle_Listing;
            car_RentalEntities = new Car_RentalEntities();
            
        }
        public AddEditVehicle(CarType carToEdit)
        {
            InitializeComponent();
            txt_AddEdit.Text = "Edit Vehicle";
            isEditMode = true;
            car_RentalEntities = new Car_RentalEntities();
            PopulateFields(carToEdit);
        }

        private void PopulateFields(CarType car)
        {
            lblId.Text = car.Car_Id.ToString();
            txt_Name.Text = car.Car_Make;
            txt_Model.Text = car.Car_Model;
            txt_VIN.Text = car.VIN;
            txt_Year.Text = car.Year.ToString(); //conversion of int to string
            txt_LicenseNumber.Text = car.LicensePlateNumber;
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            //if(isEditMode == true)
            if (isEditMode)
            {
                //editing code
                var Id = int.Parse(lblId.Text);
                var car = car_RentalEntities.CarTypes.FirstOrDefault(q => q.Car_Id == Id);
                car.Car_Model = txt_Model.Text;
                car.Car_Make = txt_Name.Text;
                car.VIN = txt_VIN.Text;
                car.Year = int.Parse(txt_Year.Text);
                car.LicensePlateNumber = txt_LicenseNumber.Text;

                car_RentalEntities.SaveChanges();
            }
            else
            {
                //adding code
                var newCar = new CarType
                {
                    LicensePlateNumber = txt_LicenseNumber.Text,
                    Car_Make = txt_Name.Text,
                    Car_Model = txt_Model.Text,
                    VIN = txt_VIN.Text,
                    Year = int.Parse(txt_Year.Text)


                };
                car_RentalEntities.CarTypes.Add(newCar);
                car_RentalEntities.SaveChanges();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            Close();

        }
    }
}
