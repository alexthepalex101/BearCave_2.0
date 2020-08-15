using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearCave_2._0.Models
{
    public class Property
    {
        public int PropertyID { get; set; }
        public string PropertyType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }

        public ICollection<Unit> Units { get; set; }

    }
}
