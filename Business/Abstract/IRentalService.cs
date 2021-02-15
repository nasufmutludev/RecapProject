using Core.Utilities;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<RentalDto>> GetRentalDetails();
        IResult Add(Rental rental);    
        IResult CheckReturnDate(int carId);
        IResult UpdateReturnDate(int carId);
    }
}
