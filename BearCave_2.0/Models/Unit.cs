using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BearCave_2._0.Models
{
    public class Unit
    {
        public int UnitID { get; set; }
        public int DoorNum { get; set; } 
        public int Floor { get; set; } //null for houses with one occupant
                                       //floors are done american style (1 = ground floor)
        public float DefaultRent { get; set; } //rent cost is weekly; if rent period is monthly, then weeklyrent * 52.14 / 12 = monthlyrent
        public float CurrentRent { get; set; }

        
    }
}
