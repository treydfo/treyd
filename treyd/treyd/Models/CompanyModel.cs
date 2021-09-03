using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class CompanyModel
    {
        [ScaffoldColumn(false)]
        public long CompanyID { get; set; }
        [Required(ErrorMessage = "Navn á fyritøku er kravt."),
            MaxLength(50, ErrorMessage = "Navn á fyritøku kann í mesta lagi vera 50 tekn til longdar.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Teldupostur er kravdur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime? Established { get; set; }
        public DateTime Registered { get; set; }
        /*public long SellerID { get; set; }
        public SellerModel Seller { get; set; }
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
        public long StoreID { get; set; }
        public StoreModel Store { get; set; }*/
    }
}
