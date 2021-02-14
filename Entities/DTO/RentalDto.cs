﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class RentalDto:IDto
    {
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string ColorName { get; set; }
        public string FirstName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
