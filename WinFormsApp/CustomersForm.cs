using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            _customerService = new CustomerManager(new EfCustomerDal());
            _userService = new UserManager(new EfUserDal());
        }
        ICustomerService _customerService;
        IUserService _userService;
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            dtCustomer.Columns[0].Visible = false;
            LoadUserCmb();

        }

        private void LoadUserCmb()
        {
            cmbUser.DataSource = _userService.GetAll().Data;
            cmbUser.DisplayMember = "FirstName";
            cmbUser.ValueMember = "UserId";
        }

        private void LoadCustomer()
        {
            var result = _customerService.GetCustomerDetails().Data;
            dtCustomer.DataSource = result;
        }

        private void btnChecked_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer()
                {
                   UserId=Convert.ToInt32(cmbUser.SelectedValue),
                   CompanyName=txtCompanyName.Text
                };
                _customerService.Add(customer);
                LoadCustomer();                
                MessageBox.Show("Sistem Bilgisi: " + Messages.Added);
        }
            catch (Exception hata)
            {
                MessageBox.Show("Sistem Bilgisi: " + hata.Message);
            }
}

        private void dtCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RentalForm frm = (RentalForm)Application.OpenForms["RentalForm"];
            var row = dtCustomer.CurrentRow;
            frm.cmbCustomer.Text = row.Cells[2].Value.ToString();
            this.Close();
        }
    }
}
