using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketingSystem.Controller
{
    class Randomizer
    {
        
        public void RandomGen()
        {
            Random rand = new Random();
            int randomnumber = rand.Next(1, 29);
            Controller.PaymentController.SetSeats(randomnumber); 
        }

        public void GenRefNo()
        {
            Random rand = new Random();
            int randomnumber = rand.Next(0,9);
            int randomnumber1 = rand.Next(10, 30);
            Controller.PaymentController.SetRefNo(randomnumber+randomnumber1);
        }

   
    }
}
