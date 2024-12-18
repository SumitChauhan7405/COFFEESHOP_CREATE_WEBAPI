﻿using System.ComponentModel.DataAnnotations;

namespace CoffeeShop_All_Create_WebAPI.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
    }
}