using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();        
        IResult Add(Brand car);
        IResult Update(Brand car);
        IResult Delete(Brand car);
    }
}
