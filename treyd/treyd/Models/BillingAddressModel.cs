using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class BillingAddressModel
    {
        [ScaffoldColumn(false)]
        public long BillingAddressID { get; set; }
        public string Address { get; set; }
        /*public IEnumerable<CompanyModel> Companies { get; set; }
        public IEnumerable<PersonModel> Persons { get; set; }
        public IEnumerable<ShippingInfoModel> ShippingInfos { get; set; }*/
    }
}
