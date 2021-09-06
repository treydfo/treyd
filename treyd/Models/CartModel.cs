using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class CartModel
    {
        public List<CartItemModel> CartItems { get; set; } = new List<CartItemModel>();

        public double Total
        {
            get
            {
                double total = 0.00;

                foreach (var item in CartItems)
                {
                    total += item.Total;
                }

                return total;
            }
        }

        public int Count
        {
            get
            {
                int count = 0;

                foreach (var item in CartItems)
                {
                    count += item.Quantity;
                }

                return count;
            }
        }
    }
}
