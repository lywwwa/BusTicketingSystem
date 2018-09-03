using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketingSystem.Controller
{
    class Randomizer
    {
        
        public void RandomGen(int noseats)
        {
          
        
            Random rand = new Random();
            int randomnumber = rand.Next(1, 29);
          
            
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
