﻿using System;
using Core;

namespace Entity.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}