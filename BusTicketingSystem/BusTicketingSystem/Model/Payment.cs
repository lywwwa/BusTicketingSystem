using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketingSystem.Model
{
    public class Payment
    {
        internal static string CustNumber;

        public static string CustName { set; get; }

        public static string CustContact { set; get; }

        public static string CustEmail { set; get; }

        public static string CustAddress { set; get; }

        public static int ReferenceNo { set; get; }

        public static double TotAmt { set; get; }

        public static int ToTQty { set; get; }
    }
}
