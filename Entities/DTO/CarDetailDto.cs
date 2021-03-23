using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }       
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Descreption { get; set; }
        
    }
}
