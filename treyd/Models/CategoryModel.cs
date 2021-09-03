using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class CategoryModel
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        public int? ParentCategoryID { get; set; }

        [Required(ErrorMessage = "Navn á bólki er kravt.", AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool? IsChecked { get; set; }

        public bool? Expanded { get; set; }

        public bool? HasSubCategories { get; set; }

        public string ImagePath { get; set; }

        public DateTime Registered { get; set; }

        public string ParentCategory { get; set; }
    }
}
