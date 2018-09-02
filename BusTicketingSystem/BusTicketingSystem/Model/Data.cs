using System;
using System.Collections.Generic;
using System.Text;
using BusTicketingSystem.Model;

namespace BusTicketingSystem.Model
{
   public class Data
    {
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
    }
}
