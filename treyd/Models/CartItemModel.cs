using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class CartItemModel
    {
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }

        public double Total
        {
            get { return Product.Price * Quantity; }
        }
    }
}
