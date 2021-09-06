using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class StoreModel
    {
        [ScaffoldColumn(false)]
        public long StoreID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public UserModel User { get; set; }
        public string MainColor { get; set; }
        public string CoverImagePath { get; set; }
        public string StoreIconPath { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Registered { get; set; }
        /*public IEnumerable<CompanyModel> Companies { get; set; }
        public IEnumerable<ShoppingCentreModel> ShoppingCentres { get; set; }*/
    }
}
