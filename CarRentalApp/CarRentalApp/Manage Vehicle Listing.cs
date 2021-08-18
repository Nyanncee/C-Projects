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
    public partial class Manage_Vehicle_Listing : Form
    {
        private readonly Car_RentalEntities car_RentalEntities;
        public Manage_Vehicle_Listing()
        {
            InitializeComponent();
            car_RentalEntities = new Car_RentalEntities();
        }

        private void Manage_Vehicle_Listing_Load(object sender, EventArgs e)
        {
            //Select * From TypeCars
            //var cars = car_RentalEntities.CarTypes.ToList();

            //like, Select CarID as CarId, car_name as CarName from Cartypes
            //using lambda expression here to select desired columns from database
            var cars = car_RentalEntities.CarTypes.Select(q => new 
            {   Name = q.Car_Make,
                Model = q.Car_Model,
                VIN = q.VIN, Year =q.Year,
                LicensePlateNumber = q.LicensePlateNumber,
                q.Car_Id  //as same as Id =  q.Car_Id
            }).ToList();
            
            gvVehicleList.DataSource = cars;
            //the first column generated is gonna be ID
            //gvVehicleList.Columns[0].HeaderText = "ID";
            //second column generated be Name
            //gvVehicleList.Columns[1].HeaderText = "Name";
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            //get ID of selected row
            var Id = (int)gvVehicleList.SelectedRows[0].Cells["Car_Id"].Value;

            //query database for record
            var car = car_RentalEntities.CarTypes.FirstOrDefault(q => q.Car_Id == Id);

            //launch AddEditVehicle window with data
            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try {
                //get Id of selected row
                var Id = (int)gvVehicleList.SelectedRows[0].Cells["Car_Id"].Value;

                //query database for record
                var car = car_RentalEntities.CarTypes.FirstOrDefault(q => q.Car_Id == Id);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    //delete vehicle from table
                    car_RentalEntities.CarTypes.Remove(car);
                    car_RentalEntities.SaveChanges();
                }
                PopulateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //Simple Refresh Option
            PopulateGrid();
        }
        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var cars = car_RentalEntities.CarTypes
                .Select(q => new
                {
                    Name = q.Car_Make,
                    Model = q.Car_Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Car_Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvVehicleList.Columns["Car_Id"].Visible = false;
        }
    }
}
