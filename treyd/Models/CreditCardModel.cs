using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class CreditCardModel
    {
        [ScaffoldColumn(false)]
        public long CreditCardID { get; set; }
        public string Cardholder { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime Registered { get; set; }
        public IEnumerable<PersonModel> Persons { get; set; }
        public IEnumerable<CompanyModel> Companies { get; set; }
        public IEnumerable<ShoppingCentreModel> ShoppingCentres { get; set; }
    }
}
