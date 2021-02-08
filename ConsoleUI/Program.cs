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
        static void Main(string[] args)
        {
            //CarTest();
            ColorAdd();
            CarAdd();
        }

        private static void ColorAdd()
        {
            try
            {
                Color color = new Color()
                {
                   ColorId=9,
                   ColorName="Siyah"
                };
                _carService.Add(color);

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
                    ColorId = 9,
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
