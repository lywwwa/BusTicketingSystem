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

        public static void SetTotAmt(double TAmt)
        {
            Payment.TotAmt=TAmt;
        }

        public static void SetTotQty(int qty)
        {
            Payment.ToTQty = qty;
        }

        public static void SetRefNo(int refno)
        {
            Payment.ReferenceNo = refno;
        }

        public static int GetRefNo()
        {
            return Payment.ReferenceNo;
        }

        public static double GetTotAmt()
        {
            return Payment.TotAmt;
        }

        public static int GetTotQty()
        {
            return Payment.ToTQty;
        }
    }
}
