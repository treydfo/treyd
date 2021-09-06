using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace treyd.Models
{
    public class SortMethod
    {
        public long? SortMethodId { get; set; }
        public string Name { get; set; }
        public bool Ascending { get; set; }
    }
}