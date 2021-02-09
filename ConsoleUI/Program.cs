using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static ICarService _carService = new CarManager(new EfCarDal());
        static IColorService _colorService = new ColorManager(new EfColorDal());
        static IBrandService _brandService = new BrandManager(new EfBrandDal());
        static void Main(string[] args)
        {
            CarTest();
            //BrandAdd();
            //ColorAdd();
            //CarAdd();
        }

        private static void BrandAdd()
        {
            try
            {
                Brand brand = new Brand()
                {                    
                    BrandName = "Volvo",
                };
                _brandService.Add(brand);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ColorAdd()
        {
            try
            {
                Color color = new Color()
                {                   
                   ColorName="Siyah"
                };
                _colorService.Add(color);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CarAdd()
        {
            try
            {
                Car car = new Car()
                {
                    CarName = "BMW",
                    BrandId = 2,
                    ColorId = 2,
                    DailyPrice = 15,
                    ModelYear = 2021,
                    Description = "Yeni Araç Girişi"
                };
                _carService.Add(car);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" + car.CarName + "--" + car.BrandName + "--" + "--" + car.DailyPrice + "/" + car.ColorId + "--" + car.ColorName);
            }
        }
    }
}
