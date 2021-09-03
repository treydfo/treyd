using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class AdminModel
    {
        [ScaffoldColumn(false)]
        public long AdminID { get; set; }
        public long UserID { get; set; }
        public UserModel User { get; set; }
        public IEnumerable<PersonModel> Persons { get; set; }
        public IEnumerable<ShoppingCentreModel> ShoppingCentres { get; set; }
    }
}
