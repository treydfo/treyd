using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class ShippingInfoModel
    {
        [ScaffoldColumn(false)]
        public long ShippingInfoID { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public string Region { get; set; }
        public DateTime DateShipped { get; set; }
        public long OrderID { get; set; }
        public OrderModel Order { get; set; }
        public long AddressID { get; set; }
        public AddressModel Address { get; set; }
        public long BillingAddressID { get; set; }
        public BillingAddressModel BillingAddress { get; set; }
    }
}
