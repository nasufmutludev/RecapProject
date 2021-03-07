using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Core.Utilities;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckCarNameExists(car.CarName),
                CheckIfCarCountOfColorCorrect(car.ColorId));
            if (result!=null)
            {
                return result;
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }

        private IResult CheckIfCarCountOfColorCorrect(int colorId)
        {
            var result = _carDal.GetAll(x => x.ColorId == colorId).Count;
            if (result>10)
            {
                return new ErrorResult(Messages.ColorCountError);
            }

            return new SuccessResult();
        }

        private IResult CheckCarNameExists(string carName)
        {
            var result = _carDal.GetAll(x => x.CarName == carName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }

            return new SuccessResult();
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        [CacheAspect]
        [SecuredOperation("car.add,admin")]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Car> GetByColorId(int colorId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.ColorId == colorId), Messages.Listed);
        }

        public IDataResult<List<Car>> GetByDaileyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.DailyPrice >= min && x.DailyPrice <= max), Messages.Listed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.Listed);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
    }
}
