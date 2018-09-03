using BusTicketingSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketingSystem.Provider
{
    public class ProvPayment
    {
        public static void SetCustName(string name)
        {
            Payment.CustName = name;
        }

        public static void SetCustNumber(string number)
        {
            Payment.CustNumber = number;
        }

        public static void SetCustEmail(string email)
        {
            Payment.CustEmail = email;
        }

        public static void SetCustAddress(string address)
        {
            Payment.CustAddress = address;
        }

    }
}
