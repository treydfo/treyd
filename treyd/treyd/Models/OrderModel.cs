using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class OrderModel
    {
        [ScaffoldColumn(false)]
        public int OrderID { get; set; }
        public long OrderNumber { get; set; }
        public double Total { get; set; }
        public int UserID { get; set; }
        public UserModel User { get; set; }
        public int PaymentID { get; set; }
        public PaymentModel Payment { get; set; }
        public DateTime DateOrdered { get; set; }
        /*public long CustomerID { get; set; }
        public CustomerModel Customer { get; set; }
        public IEnumerable<ShippingInfoModel> ShippingInfos { get; set; }*/
    }
}
