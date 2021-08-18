
namespace CarRentalApp
{
    partial class ManageRentalRecords
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
            this.txt_ManageRecords = new System.Windows.Forms.Label();
            this.btn_addnewRecord = new System.Windows.Forms.Button();
            this.btn_editRecord = new System.Windows.Forms.Button();
            this.btn_addRecord = new System.Windows.Forms.Button();
            this.gvVehicleRecord = new System.Windows.Forms.DataGridView();
            this.btn_addRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ManageRecords
            // 
            this.txt_ManageRecords.AutoSize = true;
            this.txt_ManageRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ManageRecords.Location = new System.Drawing.Point(293, 27);
            this.txt_ManageRecords.Name = "txt_ManageRecords";
            this.txt_ManageRecords.Size = new System.Drawing.Size(613, 61);
            this.txt_ManageRecords.TabIndex = 5;
            this.txt_ManageRecords.Text = "Manage Rental Records";
            // 
            // btn_addnewRecord
            // 
            this.btn_addnewRecord.Location = new System.Drawing.Point(28, 613);
            this.btn_addnewRecord.Name = "btn_addnewRecord";
            this.btn_addnewRecord.Size = new System.Drawing.Size(284, 70);
            this.btn_addnewRecord.TabIndex = 6;
            this.btn_addnewRecord.Text = "Add New Record";
            this.btn_addnewRecord.UseVisualStyleBackColor = true;
            this.btn_addnewRecord.Click += new System.EventHandler(this.btn_addnewRecord_Click);
            // 
            // btn_editRecord
            // 
            this.btn_editRecord.Location = new System.Drawing.Point(993, 613);
            this.btn_editRecord.Name = "btn_editRecord";
            this.btn_editRecord.Size = new System.Drawing.Size(236, 70);
            this.btn_editRecord.TabIndex = 7;
            this.btn_editRecord.Text = "Edit Record";
            this.btn_editRecord.UseVisualStyleBackColor = true;
            this.btn_editRecord.Click += new System.EventHandler(this.btn_editRecord_Click);
            // 
            // btn_addRecord
            // 
            this.btn_addRecord.Location = new System.Drawing.Point(1995, 613);
            this.btn_addRecord.Name = "btn_addRecord";
            this.btn_addRecord.Size = new System.Drawing.Size(237, 70);
            this.btn_addRecord.TabIndex = 8;
            this.btn_addRecord.Text = "Delete Record";
            this.btn_addRecord.UseVisualStyleBackColor = true;
            this.btn_addRecord.Click += new System.EventHandler(this.btn_delRecord_Click);
            // 
            // gvVehicleRecord
            // 
            this.gvVehicleRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleRecord.Location = new System.Drawing.Point(28, 181);
            this.gvVehicleRecord.Name = "gvVehicleRecord";
            this.gvVehicleRecord.RowHeadersWidth = 102;
            this.gvVehicleRecord.RowTemplate.Height = 40;
            this.gvVehicleRecord.Size = new System.Drawing.Size(2216, 414);
            this.gvVehicleRecord.TabIndex = 9;
            // 
            // btn_addRefresh
            // 
            this.btn_addRefresh.Location = new System.Drawing.Point(28, 90);
            this.btn_addRefresh.Name = "btn_addRefresh";
            this.btn_addRefresh.Size = new System.Drawing.Size(242, 65);
            this.btn_addRefresh.TabIndex = 10;
            this.btn_addRefresh.Text = "Refresh";
            this.btn_addRefresh.UseVisualStyleBackColor = true;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2281, 754);
            this.Controls.Add(this.btn_addRefresh);
            this.Controls.Add(this.gvVehicleRecord);
            this.Controls.Add(this.btn_addRecord);
            this.Controls.Add(this.btn_editRecord);
            this.Controls.Add(this.btn_addnewRecord);
            this.Controls.Add(this.txt_ManageRecords);
            this.Name = "ManageRentalRecords";
            this.Text = "ManageRentalRecords";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_ManageRecords;
        private System.Windows.Forms.Button btn_addnewRecord;
        private System.Windows.Forms.Button btn_editRecord;
        private System.Windows.Forms.Button btn_addRecord;
        private System.Windows.Forms.DataGridView gvVehicleRecord;
        private System.Windows.Forms.Button btn_addRefresh;
    }
}