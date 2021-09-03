using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class PersonModel
    {
        [ScaffoldColumn(false)]
        public long PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime Registered { get; set; }
        public long SellerID { get; set; }
        public SellerModel Seller { get; set; }
        public long CustomerID { get; set; }
        public CustomerModel Customer { get; set; }
        public long AdminID { get; set; }
        public AdminModel Admin { get; set; }
        public long EmailID { get; set; }
        public EmailModel Email { get; set; }
        public long PhoneNumberID { get; set; }
        public PhoneNumberModel PhoneNumber { get; set; }
        public long AddressID { get; set; }
        public AddressModel Address { get; set; }
        public long BillingAddressID { get; set; }
        public BillingAddressModel BillingAddress { get; set; }
        public long CreditCardID { get; set; }
        public CreditCardModel CreditCard { get; set; }
    }
}
