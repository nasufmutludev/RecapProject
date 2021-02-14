
namespace WinFormsApp
{
    partial class RentalForm
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
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.btnChecked = new System.Windows.Forms.Button();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Enabled = false;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(117, 51);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(136, 23);
            this.cmbCustomer.TabIndex = 0;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(21, 54);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(53, 15);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Müşteri :";
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Location = new System.Drawing.Point(21, 83);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(90, 15);
            this.lblRentDate.TabIndex = 3;
            this.lblRentDate.Text = "Kiralama Tarihi :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(157, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Kirala";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(117, 80);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(136, 23);
            this.dtpRentDate.TabIndex = 5;
            // 
            // btnChecked
            // 
            this.btnChecked.Location = new System.Drawing.Point(259, 48);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(61, 26);
            this.btnChecked.TabIndex = 23;
            this.btnChecked.Text = "Seç";
            this.btnChecked.UseVisualStyleBackColor = true;
            this.btnChecked.Click += new System.EventHandler(this.btnChecked_Click);
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(21, 25);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(89, 15);
            this.lblCar.TabIndex = 25;
            this.lblCar.Text = "Kiralanan Araç :";
            // 
            // cmbCar
            // 
            this.cmbCar.Enabled = false;
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(117, 22);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(136, 23);
            this.cmbCar.TabIndex = 24;
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 148);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.btnChecked);
            this.Controls.Add(this.dtpRentDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cmbCustomer);
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalForm";
            this.Load += new System.EventHandler(this.RentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Button btnChecked;
        public System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCar;
        public System.Windows.Forms.ComboBox cmbCar;
    }
}