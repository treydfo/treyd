﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class PhoneNumberModel
    {
        [ScaffoldColumn(false)]
        public long PhoneNumberID { get; set; }
        public int? PhoneNumber { get; set; }
        public IEnumerable<PersonModel> Persons { get; set; }
        public IEnumerable<CompanyModel> Companies { get; set; }
        public IEnumerable<ShoppingCentreModel> ShoppingCentres { get; set; }
    }
}
