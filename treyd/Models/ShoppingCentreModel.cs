using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class ShoppingCentreModel
    {
        [ScaffoldColumn(false)]
        public long ShoppingCentreID { get; set; }
        public string Name { get; set; }
        public DateTime Registered { get; set; }
        public long AdminID { get; set; }
        public AdminModel Admin { get; set; }
        public long EmailID { get; set; }
        public EmailModel Email { get; set; }
        public long PhoneNumberID { get; set; }
        public PhoneNumberModel PhoneNumber { get; set; }
        public long AddressID { get; set; }
        public AddressModel Address { get; set; }
        public long CreditCardID { get; set; }
        public CreditCardModel CreditCard { get; set; }
        public long StoreID { get; set; }
        public StoreModel Store { get; set; }
    }
}
