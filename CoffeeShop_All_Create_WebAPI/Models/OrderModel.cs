﻿using System.ComponentModel.DataAnnotations;

namespace CoffeeShop_All_Create_WebAPI.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public string PaymentMode { get; set; }
        public decimal? TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderNumber { get; set; }
        public int UserID { get; set; }
    }
}