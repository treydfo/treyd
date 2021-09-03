using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class CustomerModel
    {
        [ScaffoldColumn(false)]
        public long CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Teldupostur er kravdur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime Registered { get; set; }
        /*public IEnumerable<PersonModel> Persons { get; set; }
        public IEnumerable<OrderModel> Orders { get; set; }*/
    }
}
