using Core.Abstract;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTO;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityReporsitoryBase<Car, CarContext>, ICarDal
    {        
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId join cl in context.Colors on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {      
                                 CarId=c.CarId,                                 
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 ModelYear=c.ModelYear,
                                 DailyPrice=c.DailyPrice,
                                 ColorName=cl.ColorName,
                                 Descreption=c.Description,
                                 Status=c.Status
                             };
                return result.ToList();
            }
        }
    }
}
