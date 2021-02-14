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
            _rentalService = new RentalManager(new EfRentalDal());
            _customerService = new CustomerManager(new EfCustomerDal());
        }

        ICarService _carService;
        ICustomerService _customerService;
        IRentalService _rentalService;
        private void RentalForm_Load(object sender, EventArgs e)
        {
            CarListDt();
            LoadCustomer();
            LoadCar();
        }

        private void CarListDt()
        {
            CarDetails frm = (CarDetails)Application.OpenForms["CarDetails"];
            var row = frm.dtCarList.CurrentRow;
            cmbCar.Text = row.Cells[1].Value.ToString();
        }

        private void LoadCar()
        {
            cmbCar.DataSource = _carService.GetAll().Data;
            cmbCar.DisplayMember = "CarName";
            cmbCar.ValueMember = "CarId";
        }

        private void LoadCustomer()
        {
            cmbCustomer.DataSource = _customerService.GetAll().Data;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerId";
        }

        private void btnChecked_Click(object sender, EventArgs e)
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
                RentDate = Convert.ToDateTime(dtpRentDate.Text),                
            };
            _rentalService.Add(rental);
            MessageBox.Show(Messages.Added);


        }
    }
}
