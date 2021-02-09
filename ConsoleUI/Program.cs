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
            //CarTest();
            //BrandAdd();
            //BrandUpdate();
            //BrandDelete();
            //ColorAdd();
            //ColorUpdate();
            //ColorDelete();
            //CarAdd();
            //CarUpdate();
            CarDelete();
        }

        private static void CarDelete()
        {
            try
            {
                Car car = new Car()
                {
                    CarId = 7,
                    CarName = "BMW",
                    BrandId = 2,
                    ColorId = 2,
                    DailyPrice = 2500,
                    ModelYear = 2000,
                    Description = "Yeni Araç Girişi"
                };
                _carService.Delete(car);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CarUpdate()
        {
            try
            {
                Car car = new Car()
                {
                    CarId=7,
                    CarName = "BMW",
                    BrandId = 2,
                    ColorId = 2,
                    DailyPrice = 2500,
                    ModelYear = 2000,
                    Description = "Yeni Araç Girişi"
                };
                _carService.Update(car);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ColorDelete()
        {
            try
            {
                Color color = new Color()
                {
                    ColorId = 1,
                    ColorName = "Mavi"
                };
                _colorService.Delete(color);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ColorUpdate()
        {
            try
            {
                Color color = new Color()
                {
                    ColorId=1,
                    ColorName = "Mavi"
                };
                _colorService.Update(color);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void BrandDelete()
        {
            try
            {
                Brand brand = new Brand()
                {
                    BrandId = 1,
                    BrandName = "BMW"
                };
                _brandService.Delete(brand);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void BrandUpdate()
        {
            try
            {
                Brand brand = new Brand()
                {
                    BrandId = 1,
                    BrandName = "BMW"
                };
                _brandService.Update(brand);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
