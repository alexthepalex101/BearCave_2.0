using BearCave_2._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BearCave_2._0.Data
{
    
        public static class DbInitializer
        {
            public static void Initialize(BearCaveContext context)
            {
                context.Database.EnsureCreated();

                // Look for any students.
                if (context.Clients.Any())
                {
                    return;   // DB has been seeded
                }

                var clients = new Client[] //store in array
                {
                    //I put spaces after commas for readability and maintainability reasons
                    //it's easier to highlight parts without stealing the comma from previous att.
            new Client{Title = "Mr", FirstName="Carson", LastName="Alexander",DOB=DateTime.Parse("2005-09-01"), Email="x@x.x", 
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-01-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=100.10, RentPeriod="Monthly" },
            new Client{Title = "Mrs", FirstName="Meredith", LastName="Alonso",DOB=DateTime.Parse("2002-08-01"), Email="x@x.h",
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-02-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=200.10, RentPeriod="Monthly" },
            new Client{Title = "Mr", FirstName="Arturo", LastName="Anand",DOB=DateTime.Parse("2003-09-20"), Email="x@x.e",
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-03-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=300.10, RentPeriod="Monthly" },
            new Client{Title = "Dr", FirstName="Gytis", LastName="Barzdukas",DOB=DateTime.Parse("2002-01-01"), Email="x@x.f",
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-04-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=900.10, RentPeriod="Monthly" },
            new Client{Title = "Miss", FirstName="Yan", LastName="Li",DOB=DateTime.Parse("2002-09-01"), Email="x@x.a",
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-05-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=10.10, RentPeriod="Monthly" },
            new Client{Title = "Ms", FirstName="Peggy", LastName="Justice",DOB=DateTime.Parse("2001-11-01"), Email="x@x.p",
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-06-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=400.10, RentPeriod="Monthly" },
            new Client{Title = "Mx", FirstName="Laura", LastName="Norman",DOB=DateTime.Parse("2003-02-01"), Email="x@x.b",
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-07-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=300.10, RentPeriod="Monthly" },
            new Client{Title = "Mr", FirstName="Nino", LastName="Olivetto",DOB=DateTime.Parse("2005-09-20"), Email="x@x.y",
                HomePhone=0208711711, MobilePhone=0792811811, WorkPhone=0792911911, TenancyStart=DateTime.Parse("2020-08-01"),
                NINumber="AB123456C", HBref=123456789, Active=true, YTDBalance=200.10, RentPeriod="Monthly" }
                };
                foreach (Client s in clients) //loop through array and store
                {
                    context.Clients.Add(s);
                }
                context.SaveChanges();

                var units = new Unit[]
                {
                   //I put the unit IDs manually to test if 'autoid' works when I input
                   //data from the create page of the site.
            
            new Unit{UnitID=1, DoorNum=1, Floor=1, DefaultRent=600, CurrentRent=600},
            new Unit{UnitID=2, DoorNum=2, Floor=1, DefaultRent=600, CurrentRent=600},
            new Unit{UnitID=3, DoorNum=3, Floor=1, DefaultRent=600, CurrentRent=600},
            new Unit{UnitID=4, DoorNum=4, Floor=1, DefaultRent=600, CurrentRent=600},
            new Unit{UnitID=5, DoorNum=5, Floor=1, DefaultRent=600, CurrentRent=600},
            new Unit{UnitID=6, DoorNum=6, Floor=1, DefaultRent=600, CurrentRent=600},
            new Unit{UnitID=7, DefaultRent=1000, CurrentRent=1050},
            new Unit{UnitID=8, DefaultRent=1000, CurrentRent=1050},
            new Unit{UnitID=9, DefaultRent=1000, CurrentRent=1050},
            new Unit{UnitID=10, DefaultRent=1000, CurrentRent=1050},
            new Unit{UnitID=11, DefaultRent=1000, CurrentRent=1050},
            new Unit{UnitID=12, DefaultRent=1000, CurrentRent=1050},
                };
                foreach (Unit c in units)
                {
                    context.Units.Add(c);
                }
                context.SaveChanges();

                var properties = new Property[]
                {
            new Property{PropertyType="Flat", Address="Manor House, 9 Street Street", City="Oleander", County="Soil", Postcode="MM18 U92"},
            new Property{PropertyType="House", Address="Address A", City="City A", County="County A", Postcode="XX01 X01"},
            new Property{PropertyType="House", Address="Address B", City="City B", County="County B", Postcode="XX02 X01"},
             new Property{PropertyType="House", Address="Address C", City="City C", County="County C", Postcode="XX03 X01"},
             new Property{PropertyType="House", Address="Address D", City="City D", County="County D", Postcode="XX04 X01"},
             new Property{PropertyType="House", Address="Address E", City="City E", County="County E", Postcode="XX05 X01"},
             
                };
                foreach (Property e in properties)
                {
                    context.Properties.Add(e);
                }
                context.SaveChanges();
            }
        }
    }

