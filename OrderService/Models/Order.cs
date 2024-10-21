﻿using ProductService.Models;

namespace OrderService.Models
{

    public class Order
    {

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
