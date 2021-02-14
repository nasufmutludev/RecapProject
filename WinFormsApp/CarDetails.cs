using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTO;
using FluentValidation.Results;
using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class CarDetails : Form
    {
        public CarDetails()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
            _brandService = new BrandManager(new EfBrandDal());
            _colorService = new ColorManager(new EfColorDal());
            _userService = new UserManager(new EfUserDal());
            _rentalService = new RentalManager(new EfRentalDal());
        }
        ICarService _carService;
        IBrandService _brandService;
        IColorService _colorService;
        IUserService _userService;
        IRentalService _rentalService;
        private void CarDetails_Load(object sender, EventArgs e)
        {
            CustomDate();

            CarList();
            CarHeaderText();
            dtCarList.Columns[0].Visible = false;
            CmbMarka();
            CmbColor();
        }
        private void CustomDate()
        {
            for (int i = 1988; i <= DateTime.Now.Year; i++)
            {
                cmbModelYear.Items.Add(i);
            }
        }

        private void CmbColor()
        {
            cmbColor.DataSource = _colorService.GetAll().Data;
            cmbColor.DisplayMember = "ColorName";
            cmbColor.ValueMember = "ColorId";
        }

        private void CmbMarka()
        {
            cmbBrand.DataSource = _brandService.GetAll().Data;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandId";
        }

        private void CarList()
        {
            var result = _carService.GetCarDetails().Data;
            dtCarList.DataSource = result;
        }

        private void CarHeaderText()
        {
            dtCarList.Columns[0].HeaderText = "CarId";
            dtCarList.Columns[1].HeaderText = "Araç Bilgisi";
            dtCarList.Columns[2].HeaderText = "Araç Markası";
            dtCarList.Columns[3].HeaderText = "Renk Bilgisi";
            dtCarList.Columns[4].HeaderText = "Yıl";
            dtCarList.Columns[5].HeaderText = "Fiyat Bilgisi";
            dtCarList.Columns[6].HeaderText = "Açıklama";            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car()
                {
                    CarName = txtCarName.Text,
                    BrandId = Convert.ToInt32(cmbBrand.SelectedValue),
                    ColorId = Convert.ToInt32(cmbColor.SelectedValue),
                    ModelYear = Convert.ToInt32(cmbModelYear.Text),
                    DailyPrice = Convert.ToDecimal(txtDailyPrice.Text),
                    Description = txtDescreption.Text
                };
                _carService.Add(car);
                TextBoxClear();
                CarList();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sistem Bilgisi: " + hata.Message);
            }
        }

        private void txtCarName_MouseHover(object sender, EventArgs e)
        {
            dataStatus.Text = "Araç Adı Giriniz";
        }

        private void dtCarList_MouseHover(object sender, EventArgs e)
        {
            dataStatus.Text = Messages.Listed;
        }

        private void cmbBrand_MouseHover(object sender, EventArgs e)
        {
            dataStatus.Text = "Araç Markası Seçiniz";
        }

        private void cmbColor_MouseHover(object sender, EventArgs e)
        {
            dataStatus.Text = "Araç Rengi Giriniz";
        }

        private void cmbModelYear_MouseHover(object sender, EventArgs e)
        {
            dataStatus.Text = "Model Yılını Seçiniz";
        }

        private void txtDailyPrice_MouseHover(object sender, EventArgs e)
        {
            dataStatus.Text = "Fiyat Giriniz";
        }

        private void txtDescreption_MouseHover(object sender, EventArgs e)
        {
            dataStatus.Text = "Açıklama Giriniz";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _carService.Update(new Car
                {
                    CarId = Convert.ToInt32(dtCarList.CurrentRow.Cells[0].Value),
                    CarName = txtCarName.Text,
                    BrandId = Convert.ToInt32(cmbBrand.SelectedValue),
                    ColorId = Convert.ToInt32(cmbColor.SelectedValue),
                    ModelYear = Convert.ToInt32(cmbModelYear.Text),
                    DailyPrice = Convert.ToDecimal(txtDailyPrice.Text),
                    Description = txtDescreption.Text
                });
                CarList();
                TextBoxClear();
                MessageBox.Show("Sistem Bilgisi: " + Messages.Updated);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtCarList.CurrentRow != null)
                {
                    _carService.Delete(new Car
                    {
                        CarId = Convert.ToInt32(dtCarList.CurrentRow.Cells[0].Value)
                    });
                }
                MessageBox.Show("Sistem Bilgisi: " + Messages.Deleted);
                CarList();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Sistem Bilgisi: " + hata.Message);
            }
        }

        private void dtCarList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dtCarList.CurrentRow;
            txtCarName.Text = row.Cells[1].Value.ToString();
            cmbBrand.Text = Convert.ToString(row.Cells[2].Value);
            cmbColor.Text = Convert.ToString(row.Cells[3].Value);
            cmbModelYear.Text = row.Cells[4].Value.ToString();
            txtDailyPrice.Text = row.Cells[5].Value.ToString();
            txtDescreption.Text = row.Cells[6].Value.ToString();
        }

        private void TextBoxClear()
        {
            foreach (Control control in grbCarAdd.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    control.Text = "";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomersForm frm = new CustomersForm();
            frm.Show();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentalForm frm = new RentalForm();
            frm.Show();
        }
    }
}
