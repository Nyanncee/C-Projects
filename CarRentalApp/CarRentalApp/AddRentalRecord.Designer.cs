
namespace CarRentalApp
{
    partial class AddRentalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_submit = new System.Windows.Forms.Button();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.txt_RentalCarSys = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date_rented = new System.Windows.Forms.DateTimePicker();
            this.date_returned = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_typeofcar = new System.Windows.Forms.ComboBox();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_AddEdit = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(557, 559);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(186, 57);
            this.button_submit.TabIndex = 0;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // txt_Customer
            // 
            this.txt_Customer.Location = new System.Drawing.Point(21, 248);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(285, 38);
            this.txt_Customer.TabIndex = 1;
            // 
            // txt_RentalCarSys
            // 
            this.txt_RentalCarSys.AutoSize = true;
            this.txt_RentalCarSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RentalCarSys.Location = new System.Drawing.Point(195, 53);
            this.txt_RentalCarSys.Name = "txt_RentalCarSys";
            this.txt_RentalCarSys.Size = new System.Drawing.Size(486, 61);
            this.txt_RentalCarSys.TabIndex = 3;
            this.txt_RentalCarSys.Text = "Add Rental Record";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Date Rented";
            // 
            // date_rented
            // 
            this.date_rented.Location = new System.Drawing.Point(21, 421);
            this.date_rented.Name = "date_rented";
            this.date_rented.Size = new System.Drawing.Size(285, 38);
            this.date_rented.TabIndex = 6;
            // 
            // date_returned
            // 
            this.date_returned.Location = new System.Drawing.Point(504, 421);
            this.date_returned.Name = "date_returned";
            this.date_returned.Size = new System.Drawing.Size(278, 38);
            this.date_returned.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(531, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Date Returned";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Type of Car";
            // 
            // combo_typeofcar
            // 
            this.combo_typeofcar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_typeofcar.FormattingEnabled = true;
            this.combo_typeofcar.Location = new System.Drawing.Point(21, 577);
            this.combo_typeofcar.Name = "combo_typeofcar";
            this.combo_typeofcar.Size = new System.Drawing.Size(285, 39);
            this.combo_typeofcar.TabIndex = 10;
            // 
            // txt_Cost
            // 
            this.txt_Cost.Location = new System.Drawing.Point(504, 248);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(278, 38);
            this.txt_Cost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cost of Rent";
            // 
            // lbl_AddEdit
            // 
            this.lbl_AddEdit.AutoSize = true;
            this.lbl_AddEdit.Location = new System.Drawing.Point(371, 134);
            this.lbl_AddEdit.Name = "lbl_AddEdit";
            this.lbl_AddEdit.Size = new System.Drawing.Size(0, 32);
            this.lbl_AddEdit.TabIndex = 13;
            // 
            // lblRecordId
            // 
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Location = new System.Drawing.Point(389, 713);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(0, 32);
            this.lblRecordId.TabIndex = 14;
            this.lblRecordId.Visible = false;
            // 
            // AddRentalRecord
            // 
            this.ClientSize = new System.Drawing.Size(837, 878);
            this.Controls.Add(this.lblRecordId);
            this.Controls.Add(this.lbl_AddEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cost);
            this.Controls.Add(this.combo_typeofcar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_returned);
            this.Controls.Add(this.date_rented);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_RentalCarSys);
            this.Controls.Add(this.txt_Customer);
            this.Controls.Add(this.button_submit);
            this.Name = "AddRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox txt_Customer;
        private System.Windows.Forms.Label txt_RentalCarSys;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_rented;
        private System.Windows.Forms.DateTimePicker date_returned;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_typeofcar;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_AddEdit;
        private System.Windows.Forms.Label lblRecordId;
    }
}

