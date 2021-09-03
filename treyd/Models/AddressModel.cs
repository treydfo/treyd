using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class AddressModel
    {
        [ScaffoldColumn(false)]
        public long AddressID { get; set; }
        [Required(ErrorMessage = "Bústaður er kravdur.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Býur/bygd er kravt.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Postnummar er kravt.")]
        [MinLength(3, ErrorMessage = "Postnummarið skal vera 3 tøl til longdar."),
            MaxLength(3, ErrorMessage = "Postnummarið skal vera 3 tøl til longdar.")]
        public int PostalCode { get; set; }
        public int UserID { get; set; }
        public UserModel User { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Registered { get; set; }
        //public long PostalCodeID { get; set; }
        //public PostalCodeModel PostalCode { get; set; }
        //public IEnumerable<PersonModel> Persons { get; set; }
        //public IEnumerable<CompanyModel> Companies { get; set; }
        //public IEnumerable<ShoppingCentreModel> ShoppingCentres { get; set; }
        //public IEnumerable<ShippingInfoModel> ShippingInfos { get; set; }
    }
}
