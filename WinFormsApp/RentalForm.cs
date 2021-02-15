using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTO;
using System;
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
            var result = _rentalService.GetRentalDetails().Data;
            dtRental.DataSource = result;
        }

        private void LoadUser()
        {
            cmbCustomer.DataSource = _customerService.GetCustomerDetails().Data;
            cmbCustomer.DisplayMember = "FirstName";
            cmbCustomer.ValueMember = "CustomerId";
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
            CarDetails frm = (CarDetails)Application.OpenForms["CarDetails"];
            int id = (int)frm.dtCarList.CurrentRow.Cells[0].Value;
            var result = _rentalService.CheckReturnDate(id);
            if (result.Success)
            {
                Rental rental = new Rental()
                {
                    CarId=Convert.ToInt32(cmbCar.SelectedValue),
                    CustomerId=Convert.ToInt32(cmbCustomer.SelectedValue),
                    RentDate=dtpRentDate.Value
                };
                _rentalService.Add(rental);
                LoadRental();
            }
            else
            {
                MessageBox.Show(Messages.Error);
            }
        }

        private void btnReturnRental_Click(object sender, EventArgs e)
        {
            CarDetails frm = (CarDetails)Application.OpenForms["CarDetails"];
            int id = (int)frm.dtCarList.CurrentRow.Cells[0].Value;
            var result = _rentalService.UpdateReturnDate(id);
            if (result.Success)
            {
                LoadRental();
            }
            else
            {
                MessageBox.Show(Messages.Error);
            }
        }
    }
}
