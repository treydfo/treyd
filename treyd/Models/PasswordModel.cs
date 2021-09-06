using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class PasswordModel
    {
        [Required(ErrorMessage = "Núverandi loyniorð er kravt."),
            MinLength(6, ErrorMessage = "Loyniorðið skal í minsta lagi vera 6 tekn til longdar."),
            MaxLength(12, ErrorMessage = "Loyniorðið kann í mesta lagi vera 12 tekn til longdar.")]
        public string CurrentPassword { get; set; }

        [ScaffoldColumn(false)]
        [Required(ErrorMessage = "Nýtt loyniorð er kravt."),
            MinLength(6, ErrorMessage = "Loyniorðið skal í minsta lagi vera 6 tekn til longdar."),
            MaxLength(12, ErrorMessage = "Loyniorðið kann í mesta lagi vera 12 tekn til longdar.")]
        public string NewPassword { get; set; }

        [ScaffoldColumn(false)]
        [Compare(nameof(NewPassword),
            ErrorMessage = "'Nýtt loyniorð' og 'Vátta nýggja loyniorðið' mugu vera eins")]
        public string ConfirmPassword { get; set; }
    }
}
