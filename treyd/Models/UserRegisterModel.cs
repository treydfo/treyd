using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class UserRegisterModel
    {
        [ScaffoldColumn(false)]
        public long UserID { get; set; }

        [Required(ErrorMessage = "Fyritøkunavn er kravt."),
            MinLength(1, ErrorMessage = "Fyritøkunavnið skal í minsta lagi vera 1 tekn til longdar."),
            MaxLength(100, ErrorMessage = "Fyritøkunavnið kann í mesta lagi vera 100 tekn til longdar.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Brúkaranavn er kravt."),
            MinLength(3, ErrorMessage = "Brúkaranavnið skal í minsta lagi vera 3 tekn til longdar."),
            MaxLength(50, ErrorMessage = "Brúkaranavnið kann í mesta lagi vera 50 tekn til longdar.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Brúkaranavn er kravt."),
            MinLength(3, ErrorMessage = "Brúkaranavnið skal í minsta lagi vera 3 tekn til longdar."),
            MaxLength(50, ErrorMessage = "Brúkaranavnið kann í mesta lagi vera 50 tekn til longdar.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bústaður er kravdur.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Býur/bygd er kravt.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postnummar er kravt.")]
        public string PostalCode { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "Loyniorð er kravt."),
            MinLength(6, ErrorMessage = "Loyniorðið skal í minsta lagi vera 6 tekn til longdar."),
            MaxLength(12, ErrorMessage = "Loyniorðið kann í mesta lagi vera 12 tekn til longdar.")]
        public string Password { get; set; }

        [ScaffoldColumn(false)]
        [Compare(nameof(Password),
            ErrorMessage = "'Loyniorð' og 'Vátta loyniorð' mugu vera eins")]
        public string ConfirmPassword { get; set; }

        [ScaffoldColumn(false)]
        public string PasswordSalt { get; set; }

        [Required(ErrorMessage = "Teldupostur er kravdur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Role { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Registered { get; set; }
        /*public IEnumerable<AdminModel> Admins { get; set; }
        public IEnumerable<SellerModel> Sellers { get; set; }
        public IEnumerable<CustomerModel> Customers { get; set; }
        public IEnumerable<ShoppingCartModel> ShoppingCarts { get; set; }*/
    }
}
