using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class OrderItemModel
    {
        [ScaffoldColumn(false)]
        public int OrderItemID { get; set; }
        public int Amount { get; set; }
        public double Subtotal { get; set; }
        public int OrderID { get; set; }
        public OrderModel Order { get; set; }
        public int ProductID { get; set; }
        public ProductModel Product { get; set; }
        public DateTime Registered { get; set; }
    }
}
