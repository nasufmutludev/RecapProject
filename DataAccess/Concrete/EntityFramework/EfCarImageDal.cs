using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityReporsitoryBase<CarImage, CarContext>, ICarImageDal
    {
        public List<CarImageDto> GetCarImageDetails(Expression<Func<CarImage, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from cI in filter == null ? context.CarImages : context.CarImages.Where(filter)
                             join c in context.Cars on cI.CarId equals c.CarId
                             select new CarImageDto
                             {
                                 Id = cI.Id,
                                 CarId = c.CarId,
                                 CarName = c.CarName,
                                 ImagePath = cI.ImagePath,
                                 Date = cI.Date
                             };
                return result.ToList();
            }
        }
    }
}
