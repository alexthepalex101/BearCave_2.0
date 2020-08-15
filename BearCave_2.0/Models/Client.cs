using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
namespace BearCave_2._0.Models

{
    public class Client
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int HomePhone { get; set; }
        public int MobilePhone { get; set; }
        public int WorkPhone { get; set; }
        public DateTime TenancyStart { get; set; }
        public string NINumber { get; set; }
        public int HBref { get; set; }
        public bool Active { get; set; }
        public double YTDBalance { get; set; }
        public string RentPeriod { get; set; }

        public ICollection<Unit> Units { get; set; }
       
    }
}
