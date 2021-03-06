
namespace WinFormsApp
{
    partial class CarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRent = new System.Windows.Forms.Button();
            this.dtCarList = new System.Windows.Forms.DataGridView();
            this.grbCarAdd = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblDescreption = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtDescreption = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblDailyPrice = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbModelYear = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblModelYear = new System.Windows.Forms.Label();
            this.statusCheck = new System.Windows.Forms.StatusStrip();
            this.dataStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtCarList)).BeginInit();
            this.grbCarAdd.SuspendLayout();
            this.statusCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(10, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 569);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnRent);
            this.tabPage1.Controls.Add(this.dtCarList);
            this.tabPage1.Controls.Add(this.grbCarAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Araç Bilgisi";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(564, 244);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(107, 31);
            this.btnRent.TabIndex = 16;
            this.btnRent.Text = "Kirala / Teslim Al";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dtCarList
            // 
            this.dtCarList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCarList.Location = new System.Drawing.Point(11, 11);
            this.dtCarList.Name = "dtCarList";
            this.dtCarList.RowTemplate.Height = 25;
            this.dtCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtCarList.Size = new System.Drawing.Size(660, 228);
            this.dtCarList.TabIndex = 15;
            this.dtCarList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCarList_CellClick);
            // 
            // grbCarAdd
            // 
            this.grbCarAdd.Controls.Add(this.btnClear);
            this.grbCarAdd.Controls.Add(this.btnDelete);
            this.grbCarAdd.Controls.Add(this.btnEdit);
            this.grbCarAdd.Controls.Add(this.btnAdd);
            this.grbCarAdd.Controls.Add(this.lblCarName);
            this.grbCarAdd.Controls.Add(this.lblDescreption);
            this.grbCarAdd.Controls.Add(this.txtCarName);
            this.grbCarAdd.Controls.Add(this.txtDescreption);
            this.grbCarAdd.Controls.Add(this.lblBrand);
            this.grbCarAdd.Controls.Add(this.lblDailyPrice);
            this.grbCarAdd.Controls.Add(this.cmbBrand);
            this.grbCarAdd.Controls.Add(this.txtDailyPrice);
            this.grbCarAdd.Controls.Add(this.lblColor);
            this.grbCarAdd.Controls.Add(this.cmbModelYear);
            this.grbCarAdd.Controls.Add(this.cmbColor);
            this.grbCarAdd.Controls.Add(this.lblModelYear);
            this.grbCarAdd.Location = new System.Drawing.Point(11, 244);
            this.grbCarAdd.Name = "grbCarAdd";
            this.grbCarAdd.Size = new System.Drawing.Size(352, 278);
            this.grbCarAdd.TabIndex = 14;
            this.grbCarAdd.TabStop = false;
            this.grbCarAdd.Text = "Araç Ekle";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(266, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(91, 240);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Location = new System.Drawing.Point(5, 24);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(53, 13);
            this.lblCarName.TabIndex = 2;
            this.lblCarName.Text = "Araç Adı :";
            // 
            // lblDescreption
            // 
            this.lblDescreption.AutoSize = true;
            this.lblDescreption.Location = new System.Drawing.Point(5, 150);
            this.lblDescreption.Name = "lblDescreption";
            this.lblDescreption.Size = new System.Drawing.Size(56, 13);
            this.lblDescreption.TabIndex = 13;
            this.lblDescreption.Text = "Açıklama :";
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(64, 21);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(138, 20);
            this.txtCarName.TabIndex = 1;
            this.txtCarName.MouseHover += new System.EventHandler(this.txtCarName_MouseHover);
            // 
            // txtDescreption
            // 
            this.txtDescreption.Location = new System.Drawing.Point(64, 146);
            this.txtDescreption.Multiline = true;
            this.txtDescreption.Name = "txtDescreption";
            this.txtDescreption.Size = new System.Drawing.Size(228, 88);
            this.txtDescreption.TabIndex = 12;
            this.txtDescreption.MouseHover += new System.EventHandler(this.txtDescreption_MouseHover);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(5, 49);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(43, 13);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Marka :";
            // 
            // lblDailyPrice
            // 
            this.lblDailyPrice.AutoSize = true;
            this.lblDailyPrice.Location = new System.Drawing.Point(5, 125);
            this.lblDailyPrice.Name = "lblDailyPrice";
            this.lblDailyPrice.Size = new System.Drawing.Size(35, 13);
            this.lblDailyPrice.TabIndex = 11;
            this.lblDailyPrice.Text = "Fiyat :";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(64, 46);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(138, 21);
            this.cmbBrand.TabIndex = 5;
            this.cmbBrand.MouseHover += new System.EventHandler(this.cmbBrand_MouseHover);
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.Location = new System.Drawing.Point(64, 121);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(138, 20);
            this.txtDailyPrice.TabIndex = 10;
            this.txtDailyPrice.MouseHover += new System.EventHandler(this.txtDailyPrice_MouseHover);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(5, 75);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Renk :";
            // 
            // cmbModelYear
            // 
            this.cmbModelYear.FormattingEnabled = true;
            this.cmbModelYear.Location = new System.Drawing.Point(64, 96);
            this.cmbModelYear.Name = "cmbModelYear";
            this.cmbModelYear.Size = new System.Drawing.Size(138, 21);
            this.cmbModelYear.TabIndex = 9;
            this.cmbModelYear.MouseHover += new System.EventHandler(this.cmbModelYear_MouseHover);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(64, 71);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(138, 21);
            this.cmbColor.TabIndex = 7;
            this.cmbColor.MouseHover += new System.EventHandler(this.cmbColor_MouseHover);
            // 
            // lblModelYear
            // 
            this.lblModelYear.AutoSize = true;
            this.lblModelYear.Location = new System.Drawing.Point(5, 100);
            this.lblModelYear.Name = "lblModelYear";
            this.lblModelYear.Size = new System.Drawing.Size(58, 13);
            this.lblModelYear.TabIndex = 8;
            this.lblModelYear.Text = "Model Yılı :";
            // 
            // statusCheck
            // 
            this.statusCheck.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.dataStatus});
            this.statusCheck.Location = new System.Drawing.Point(0, 605);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusCheck.Size = new System.Drawing.Size(715, 22);
            this.statusCheck.TabIndex = 3;
            this.statusCheck.Text = "statusStrip1";
            // 
            // dataStatus
            // 
            this.dataStatus.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dataStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.dataStatus.Name = "dataStatus";
            this.dataStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnUserForm
            // 
            this.btnUserForm.Location = new System.Drawing.Point(556, 12);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(64, 20);
            this.btnUserForm.TabIndex = 4;
            this.btnUserForm.Text = "Kullanıcılar";
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(626, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(64, 20);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Müşteriler";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(715, 627);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnUserForm);
            this.Controls.Add(this.statusCheck);
            this.Controls.Add(this.tabControl1);
            this.Name = "CarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama";
            this.Load += new System.EventHandler(this.CarDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dtCarList)).EndInit();
            this.grbCarAdd.ResumeLayout(false);
            this.grbCarAdd.PerformLayout();
            this.statusCheck.ResumeLayout(false);
            this.statusCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.StatusStrip statusCheck;
        private System.Windows.Forms.ToolStripStatusLabel dataStatus;        
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.ComboBox cmbModelYear;
        private System.Windows.Forms.Label lblModelYear;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblDailyPrice;
        private System.Windows.Forms.Label lblDescreption;
        private System.Windows.Forms.TextBox txtDescreption;
        private System.Windows.Forms.GroupBox grbCarAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUserForm;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRent;
        public System.Windows.Forms.DataGridView dtCarList;
    }
}

