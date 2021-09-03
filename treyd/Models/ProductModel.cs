using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class ProductModel
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }
        public string ProductNumber { get; set; }

        [Required(ErrorMessage = "Vøruheiti er kravt.", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vørulýsing er kravd.", AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Prísur á vøru er kravdur.", AllowEmptyStrings = false),
            Range(0.01, float.MaxValue, ErrorMessage = "Prísurin skal vera positivur og í mesta lagi 1 milliard")]
        [Column(TypeName = "decimal(17, 2)")]
        public float Price { get; set; }
        public int Discount { get; set; }

        [Required(ErrorMessage = "Vørunøgd er kravd")]
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
        public bool InStock { get; set; }
        public string Category { get; set; }
        public string Seller { get; set; }
        public bool Published { get; set; }
        public string Producer { get; set; }
        public DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateAdded { get; set; }

        public float GetDiscountPrice
        {
            get
            {
                return Price - (Discount * Price / 100);
            }
        }

        public string ProductViewUrl
        {
            get
            {
                return "soelumidstoedin/voera/" + ProductID;
            }
        }

        public string StoreUrl
        {
            get
            {
                return "handlar/" + Seller;
            }
        }
    }
}
