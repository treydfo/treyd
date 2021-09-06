using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class SubCategoryModel
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        public string ParentId { get; set; }

        [Display(Name = "Navn", Description = "Navn á bólki")]
        [Required(ErrorMessage = "Navn á bólki er kravt.", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Display(Name = "Lýsing", Description = "Lýsing av bólki")]

        public bool Expanded { get; set; }

        public bool HasSubFolders { get; set; }

        // public IEnumerable<ProductModel> Products { get; set; }
    }
}