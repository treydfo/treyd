using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class OrderItemsModel
    {
        public int Amount { get; set; }
        public double Subtotal { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public long OrderNumber { get; set; }
        public double Total { get; set; }
        public int OrderID { get; set; }
        public OrderModel Orders { get; set; }
        public int UserID { get; set; }
        public UserModel Users { get; set; }
    }
}
