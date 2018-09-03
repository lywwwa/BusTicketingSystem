using BusTicketingSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketingSystem.Provider
{
    public class ProvBus
    {
        public static void SetBusType(string bus)
        {
            Bus.BusType = bus;
        }

        public static void SetBusSched(string sched)
        {
            Bus.BusSched = sched;
        }

        public static void SetBusFee(string type)
        {

            if (type.Equals("Ordinary"))
            {
                Bus.BusFee = 25.00;
            }
            else if (type.Equals("Regular"))
            {
                Bus.BusFee = 50.00;
            }
            else if (type.Equals("Deluxe"))
            {
                Bus.BusFee = 150.00;
            }
            else
            {
                Bus.BusFee = 0.00;
            }

        }

        public static void SetBusSeat(int bus)
        {
            Bus.BusSeat = bus;
        }



        public static string GetBusType()
        {
            return Bus.BusType;
        }

        public static string GetBusSched()
        {
            return Bus.BusSched;
        }

        public static double GetBusFee()
        {
            return Bus.BusFee;
        }

        public static int GetBusSeat()
        {
            return Bus.BusSeat;
        }

    }
}
