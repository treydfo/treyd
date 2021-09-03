using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class SubscriptionModel
    {
        [ScaffoldColumn(false)]
        public int SubscriptionID { get; set; }
        public int SubscriptionNumber { get; set; }
        public string Cardholder { get; set; }
        public string Last4 { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
        public int UserID { get; set; }
        public string Status { get; set; }
        public double SubscriptionFee { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
        //public AdminModel Admin { get; set; }
        //public long EmailID { get; set; }
        //public EmailModel Email { get; set; }
        //public long PhoneNumberID { get; set; }
        //public PhoneNumberModel PhoneNumber { get; set; }
        //public long AddressID { get; set; }
        //public AddressModel Address { get; set; }
        //public long BillingAddressID { get; set; }
        //public BillingAddressModel BillingAddress { get; set; }
        //public long CreditCardID { get; set; }
        //public CreditCardModel CreditCard { get; set; }
    }
}
