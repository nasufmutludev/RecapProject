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
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
            _customerService = new CustomerManager(new EfCustomerDal());
            _rentalService = new RentalManager(new EfRentalDal());
        }
        ICarService _carService;
        ICustomerService _customerService;
        IRentalService _rentalService;

        private void RentalForm_Load(object sender, EventArgs e)
        {
            LoadCar();
            cmbCarDt();
            LoadUser();
            LoadRental();
        }

        private void LoadRental()
        {
            var result = _rentalService.GetAll().Data;
            dtRental.DataSource = result;
        }

        private void LoadUser()
        {
            //cmbCustomer.DataSource = _customerService.GetAll().Data;
            //cmbCustomer.DisplayMember = "UserId";
            //cmbCustomer.ValueMember = "CustomerId";
        }

        private void LoadCar()
        {
            cmbCar.DataSource = _carService.GetAll().Data;
            cmbCar.DisplayMember = "CarName";
            cmbCar.ValueMember = "CarId";
        }

        public void cmbCarDt()
        {
            CarDetails frm = (CarDetails)Application.OpenForms["CarDetails"];
            cmbCar.Text = frm.dtCarList.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CustomersForm frm = new CustomersForm();
            frm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental()
            {
                CarId = Convert.ToInt32(cmbCar.SelectedValue),
                CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue),
                RentDate = Convert.ToDateTime(dtpRentDate.Text)
            };
            _rentalService.Add(rental);
            LoadRental();
            MessageBox.Show(Messages.Added);
        }
    }
}
