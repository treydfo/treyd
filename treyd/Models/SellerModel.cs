using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class SellerModel
    {
        [ScaffoldColumn(false)]
        public long SellerID { get; set; }
        public long UserID { get; set; }
        public UserModel User { get; set; }
        public IEnumerable<CompanyModel> Companies { get; set; }
        public IEnumerable<PersonModel> Persons { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
    }
}
