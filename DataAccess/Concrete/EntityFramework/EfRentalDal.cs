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
        public List<RentalDto> GetRentalDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join cs in context.Customers on r.CustomerId equals cs.CustomerId
                             join u in context.Users on cs.UserId equals u.UserId
                             select new RentalDto
                             {
                                 RentalId = r.RentalId,
                                 CarName=c.CarName,
                                 FirstName = u.FirstName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                             };
                             
                return result.ToList();
            }
        }
    }
}
