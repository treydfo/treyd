using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Teldupostur er kravdur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "Loyniorð er kravt."),
            MinLength(6, ErrorMessage = "Loyniorðið skal í minsta lagi vera 6 tekn til longdar."),
            MaxLength(12, ErrorMessage = "Loyniorðið kann í mesta lagi vera 12 tekn til longdar.")]
        public string Password { get; set; }
    }
}
