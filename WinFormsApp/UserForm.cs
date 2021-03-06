using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;
using Core.Entities.Concrete;

namespace WinFormsApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());            
        }
        IUserService _userService;
        
        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User users = new User()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Email = txtMail.Text,
                    //Password = txtPass.Text
                };
                _userService.Add(users);
                UsersLoad();
                TextBoxUserClear();
                MessageBox.Show("Sistem Bilgisi: " + Messages.Added);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sistem Bilgisi: " + hata.Message);
            }
        }

        private void TextBoxUserClear()
        {
            foreach (Control control in grbUserAdd.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    control.Text = "";
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UsersLoad();
        }

        private void UsersLoad()
        {
            var result = _userService.GetAll().Data;
            dtUsers.DataSource = result;
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtUsers.CurrentRow != null)
                {
                    _userService.Delete(new User
                    {
                        Id = Convert.ToInt32(dtUsers.CurrentRow.Cells[0].Value)
                    });
                }
                MessageBox.Show("Sistem Bilgisi: " + Messages.Deleted);
                UsersLoad();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sistem Bilgisi: " + hata.Message);
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Update(new User
                {
                    Id= Convert.ToInt32(dtUsers.CurrentRow.Cells[0].Value),
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Email = txtMail.Text,
                    //Password = txtPass.Text
                });
                UsersLoad();
                TextBoxUserClear();
                MessageBox.Show("Sistem Bilgisi: " + Messages.Updated);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void dtUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dtUsers.CurrentRow;
            txtName.Text = row.Cells[1].Value.ToString();
            txtLastName.Text = row.Cells[2].Value.ToString();
            txtMail.Text = row.Cells[3].Value.ToString();
            txtPass.Text = row.Cells[4].Value.ToString();            
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            TextBoxUserClear();
        }

        private void dtUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomersForm frm = (CustomersForm)Application.OpenForms["CustomersForm"];
            var row = dtUsers.CurrentRow;
            frm.cmbUser.Text = row.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
