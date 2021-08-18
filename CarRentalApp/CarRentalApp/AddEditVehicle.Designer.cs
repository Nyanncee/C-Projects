
namespace CarRentalApp
{
    partial class AddEditVehicle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SaveChanges = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_AddEdit = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_VIN = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_LicenseNumber = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_VIN = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_LicenseNumber = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_LicenseNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Year, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_VIN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Model, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Model, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_VIN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Year, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_LicenseNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Name, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1104, 373);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Location = new System.Drawing.Point(176, 535);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(229, 73);
            this.btn_SaveChanges.TabIndex = 1;
            this.btn_SaveChanges.Text = "Save Changes";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(784, 535);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(189, 73);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_AddEdit
            // 
            this.txt_AddEdit.AutoSize = true;
            this.txt_AddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AddEdit.Location = new System.Drawing.Point(341, 27);
            this.txt_AddEdit.Name = "txt_AddEdit";
            this.txt_AddEdit.Size = new System.Drawing.Size(0, 61);
            this.txt_AddEdit.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(90, 32);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(3, 74);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(93, 32);
            this.lbl_Model.TabIndex = 1;
            this.lbl_Model.Text = "Model";
            // 
            // lbl_VIN
            // 
            this.lbl_VIN.AutoSize = true;
            this.lbl_VIN.Location = new System.Drawing.Point(3, 148);
            this.lbl_VIN.Name = "lbl_VIN";
            this.lbl_VIN.Size = new System.Drawing.Size(61, 32);
            this.lbl_VIN.TabIndex = 2;
            this.lbl_VIN.Text = "VIN";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(3, 222);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(75, 32);
            this.lbl_Year.TabIndex = 3;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_LicenseNumber
            // 
            this.lbl_LicenseNumber.AutoSize = true;
            this.lbl_LicenseNumber.Location = new System.Drawing.Point(3, 296);
            this.lbl_LicenseNumber.Name = "lbl_LicenseNumber";
            this.lbl_LicenseNumber.Size = new System.Drawing.Size(294, 32);
            this.lbl_LicenseNumber.TabIndex = 4;
            this.lbl_LicenseNumber.Text = "License Plate Number";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(555, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(537, 38);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(555, 77);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(537, 38);
            this.txt_Model.TabIndex = 6;
            // 
            // txt_VIN
            // 
            this.txt_VIN.Location = new System.Drawing.Point(555, 151);
            this.txt_VIN.Name = "txt_VIN";
            this.txt_VIN.Size = new System.Drawing.Size(537, 38);
            this.txt_VIN.TabIndex = 7;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(555, 225);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(537, 38);
            this.txt_Year.TabIndex = 8;
            // 
            // txt_LicenseNumber
            // 
            this.txt_LicenseNumber.Location = new System.Drawing.Point(555, 299);
            this.txt_LicenseNumber.Name = "txt_LicenseNumber";
            this.txt_LicenseNumber.Size = new System.Drawing.Size(537, 38);
            this.txt_LicenseNumber.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(765, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 32);
            this.lblId.TabIndex = 5;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 722);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txt_AddEdit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.Text = "AddEditVehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_SaveChanges;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_LicenseNumber;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_VIN;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label lbl_VIN;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_LicenseNumber;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label txt_AddEdit;
        private System.Windows.Forms.Label lblId;
    }
}