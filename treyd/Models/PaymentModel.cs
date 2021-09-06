using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class PaymentModel
    {
        [ScaffoldColumn(false)]
        public int PaymentID { get; set; }
        public int PaymentNumber { get; set; }
        public double Amount { get; set; }
        public string Provider { get; set; }
        public int UserID { get; set; }
        public UserModel User { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
    }
}
