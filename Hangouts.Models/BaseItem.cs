﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangout.Models
{
    public abstract class BaseItem
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double SalePrice { get; set; }
        public double RegPrice { get; set; }
        public double AverageRating { get; set; }
        public bool? IsLike { get; set; }
        public string SmallImageUrl { get; set; }
        public int Vintage { get; set; }
    }
}
