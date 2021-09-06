using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class PostalCodeModel
    {
        [ScaffoldColumn(false)]
        public long PostalCodeID { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public IEnumerable<AddressModel> Addresses { get; set; }
    }
}
