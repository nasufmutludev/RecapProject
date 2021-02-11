using Business.Abstract;
using Business.Constants;
using Core.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine(Messages.CarAdded);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(Messages.CarDeleted);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
            Console.WriteLine(Messages.CarListed);
        }

        public Car GetByColorId(int colorId)
        {
            return _carDal.Get(x => x.ColorId == colorId);
        }

        public List<Car> GetByDaileyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(x => x.DailyPrice >= min && x.DailyPrice <= max);
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(x => x.CarId== carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(Messages.CarUpdated);
        }
    }
}
