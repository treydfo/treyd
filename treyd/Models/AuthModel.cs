using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class AuthModel
    {
        public string Name { get; set; }
        public string Role { get; set; }

        [Required(ErrorMessage = "Teldupostur er kravdur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
