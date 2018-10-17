﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyOData.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
    }
}