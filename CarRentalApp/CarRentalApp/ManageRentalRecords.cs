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
   
    public partial class ManageRentalRecords : Form
    {
        private bool isEditMode;
        private readonly Car_RentalEntities car_RentalEntities;
        public ManageRentalRecords()
        {
            InitializeComponent();
            car_RentalEntities = new Car_RentalEntities();
        }

        private void btn_addnewRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddRentalRecord
            {
                MdiParent = this.MdiParent
            };
            addRentalRecord.Show();
        }

        private void btn_editRecord_Click(object sender, EventArgs e)
        {

            //get ID of selected row
            var Id = (int)gvVehicleRecord.SelectedRows[0].Cells["Customer_Id"].Value;

            //query database for record
            var record = car_RentalEntities.AddRecords.FirstOrDefault(q => q.Car_Id == Id);

            //launch AddEditVehicle window with data
            //var editRentalRecord = new EditRentalRecord(record);
            //editRentalRecord.MdiParent = this.MdiParent;
            //editRentalRecord.Show();
        }


        private void btn_delRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //get Id of selected row
                var Id = (int)gvVehicleRecord.SelectedRows[0].Cells["Customer_Id"].Value;

                //query database for record
                var record = car_RentalEntities.AddRecords.FirstOrDefault(q => q.Customer_Id == Id);

                //delete vehicle from the table
                car_RentalEntities.AddRecords.Remove(record);
                car_RentalEntities.SaveChanges();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }
        private void PopulateGrid()
        {
            var records = car_RentalEntities.AddRecords
                .Select(q => new
                {
                    Customer = q.Customer_Name,
                    DateOut = q.date_Rented,
                    DateIn = q.date_Returned,
                    Id = q.Customer_Id,
                    Cost = q.Cost,
                    Car = q.CarType.Car_Make + " " + q.CarType.Car_Model //concatinating two properties of Cartypes
                }).ToList();
            gvVehicleRecord.DataSource = records;
            gvVehicleRecord.Columns["DateIn"].HeaderText = "Date In";
            gvVehicleRecord.Columns["DateOut"].HeaderText = "Date Out";
        }

    }
}
