using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityReporsitoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars on r.CarId equals c.CarId
                             join cs in context.Customers on r.CustomerId equals cs.CustomerId
                             join u in context.Users on cs.UserId equals u.Id
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new RentalDto
                             {
                                 RentalId = r.RentalId,                                 
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };

                return result.ToList();
            }
        }
    }
}
