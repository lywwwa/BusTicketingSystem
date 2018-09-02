using System;
using System.Collections.Generic;
using System.Text;
using BusTicketingSystem.Model;

namespace BusTicketingSystem.Model
{
   public class Data
    {
        public string Prices(string type)
        {
            if (type == "OrdinaryPrice")
            {
                return "50.00";
            }
            else if (type == "RegularPrice")
            {
                return "25.00";
            }
            else if (type == "DeluxePrice")
            {
                return "150.00";
            }
            else
            {
                return "0";
            }
        }
       

        public List<BusSchedule> BSched = new List<BusSchedule>() {
            new BusSchedule()
            {
                Origin="Pasig",
                Destination="Quiapo",
                Time="12:00 PM"
            },

            new BusSchedule()
            {
                Origin="Cainta",
                Destination="Quiapo",
                Time="12:30 PM"
            }
        };

       public void GetUserInfo(string FullName,string Address,string email,string contact)
        {
            
            string FName = FullName;
            string Add = Address;
            string EMail = email;
            string ContactNo = contact;
        }
    }
}
