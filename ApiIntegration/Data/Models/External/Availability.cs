﻿using System;

namespace ApiIntegration.Data.Models.External
{
    public class Availability
    {
        public string ProductCode { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Nights { get; set; }
        public decimal Price { get; set; }
        public int Spaces { get; set; }
    }
}
