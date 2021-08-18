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
    public partial class AddRentalRecord : Form
    {
        private bool isEditMode;
        private readonly Car_RentalEntities car_RentalEntities; //goingtogiveaccesstoeveryentityinthemodel
        public AddRentalRecord()
        {
            InitializeComponent();
            lbl_AddEdit.Text = "Add New Rental";
            this.Text = "Add New Rental ";
            isEditMode = false;
            car_RentalEntities = new Car_RentalEntities();
        }
         public AddRentalRecord(AddRecord recordToEdit)
        {
            InitializeComponent();
            lbl_AddEdit.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record ";
            if(recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you have selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                car_RentalEntities = new Car_RentalEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(AddRecord recordToEdit)
        {
            txt_Customer.Text = recordToEdit.Customer_Name;
            date_rented.Value = (DateTime)recordToEdit.date_Rented;
            date_returned.Value = (DateTime)recordToEdit.date_Returned;
            txt_Cost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.Customer_Id.ToString();

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            {

                string customerName = txt_Customer.Text;
                var dateOut = date_rented.Value;
                var dateIn = date_returned.Value;
                double cost = Convert.ToDouble(txt_Cost.Text);

                var carType = combo_typeofcar.Text; //convertingvartostring
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage +="Please enter missing data. \n\r";
                }
                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Incorrect Data Selection. \n\r";
                }
                //if(isValid == true)
                if (isValid)
                {

                    var customerRecord = new AddRecord();
                    if (isEditMode)
                    {
                        var Id = int.Parse(lblRecordId.Text);
                        customerRecord = car_RentalEntities.AddRecords.FirstOrDefault(q => q.Customer_Id == Id);
                    }
                        
                        customerRecord.Customer_Name = customerName;
                        customerRecord.date_Rented = dateIn;
                        customerRecord.date_Returned = dateOut;
                        customerRecord.Cost = (decimal)(cost);
                        customerRecord.Car_Id = (int)combo_typeofcar.SelectedValue;

                        
                        if(!isEditMode)
                        car_RentalEntities.AddRecords.Add(customerRecord);


                        car_RentalEntities.SaveChanges();

                        //MessageBox.Show($"Thank you for submitting your application: {txt_Customer.Text}"); //printsmessageandcustomernamegivenbytheuser
                        MessageBox.Show($"Customer Name: {customerName}\n\r" +
                        $"Date Rented: {dateOut}\n\r" +
                        $"Date Returned: {dateIn}\n\r" +
                        $"Cost of Rent: {cost} \n\r" +
                        $"Car type: {carType}\n\r" +
                        $"THANK YOU FOR YOUR BUSINESS");
                    
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }

            catch (Exception ex)
            {
                //throw;
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //basically select * from CarTypes
            //using LINQ to query database using native C# code
            //var cars = car_RentalEntities.CarTypes.ToList();
            var cars = car_RentalEntities.CarTypes.Select(q => new
            {
                
                Name = q.Car_Make + " " + q.Car_Model
            }).ToList();
            //displaymember is the text shown to user
            combo_typeofcar.DisplayMember = "Car_Name";
            //what we intend to really store
            combo_typeofcar.ValueMember = "Car_Id";
            combo_typeofcar.DataSource = cars;
           
        }

    }
}