
namespace WinFormsApp
{
    partial class UserForm
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
            this.grbUserAdd = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtUsers = new System.Windows.Forms.DataGridView();
            this.grbUserAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUserAdd
            // 
            this.grbUserAdd.Controls.Add(this.txtMail);
            this.grbUserAdd.Controls.Add(this.txtLastName);
            this.grbUserAdd.Controls.Add(this.btnUserClear);
            this.grbUserAdd.Controls.Add(this.btnUserDelete);
            this.grbUserAdd.Controls.Add(this.btnUserUpdate);
            this.grbUserAdd.Controls.Add(this.btnUserAdd);
            this.grbUserAdd.Controls.Add(this.lblName);
            this.grbUserAdd.Controls.Add(this.txtName);
            this.grbUserAdd.Controls.Add(this.lblSurname);
            this.grbUserAdd.Controls.Add(this.lblPass);
            this.grbUserAdd.Controls.Add(this.txtPass);
            this.grbUserAdd.Controls.Add(this.lblEmail);
            this.grbUserAdd.Location = new System.Drawing.Point(12, 279);
            this.grbUserAdd.Name = "grbUserAdd";
            this.grbUserAdd.Size = new System.Drawing.Size(411, 194);
            this.grbUserAdd.TabIndex = 18;
            this.grbUserAdd.TabStop = false;
            this.grbUserAdd.Text = "Araç Ekle";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(70, 83);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(160, 23);
            this.txtMail.TabIndex = 19;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(70, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 23);
            this.txtLastName.TabIndex = 18;
            // 
            // btnUserClear
            // 
            this.btnUserClear.Location = new System.Drawing.Point(309, 150);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(96, 26);
            this.btnUserClear.TabIndex = 17;
            this.btnUserClear.Text = "Temizle";
            this.btnUserClear.UseVisualStyleBackColor = true;
            this.btnUserClear.Click += new System.EventHandler(this.btnUserClear_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(207, 150);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(96, 26);
            this.btnUserDelete.TabIndex = 16;
            this.btnUserDelete.Text = "Sil";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(105, 150);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(96, 26);
            this.btnUserUpdate.TabIndex = 15;
            this.btnUserUpdate.Text = "Düzenle";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(5, 150);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(96, 26);
            this.btnUserAdd.TabIndex = 14;
            this.btnUserAdd.Text = "Ekle";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ad :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 57);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(45, 15);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Soyad :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 115);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(36, 15);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Şifre :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(70, 112);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(160, 23);
            this.txtPass.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email :";
            // 
            // dtUsers
            // 
            this.dtUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsers.Location = new System.Drawing.Point(12, 12);
            this.dtUsers.Name = "dtUsers";
            this.dtUsers.RowTemplate.Height = 25;
            this.dtUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtUsers.Size = new System.Drawing.Size(727, 261);
            this.dtUsers.TabIndex = 17;
            this.dtUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsers_CellClick);
            this.dtUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsers_CellDoubleClick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 486);
            this.Controls.Add(this.grbUserAdd);
            this.Controls.Add(this.dtUsers);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.grbUserAdd.ResumeLayout(false);
            this.grbUserAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserAdd;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnUserClear;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dtUsers;
    }
}