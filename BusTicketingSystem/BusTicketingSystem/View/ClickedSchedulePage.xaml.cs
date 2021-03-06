﻿using BusTicketingSystem.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusTicketingSystem.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClickedSchedulePage : ContentPage
	{
  

        public ClickedSchedulePage ()
		{
			InitializeComponent ();

            
        }

        public void OnTapOrdinary(object sender, EventArgs args)
        {
            BusController.SetBusType("Ordinary");
            BusController.SetBusFee("Ordinary");
            this.Navigation.PushAsync(new SeatPlanPage());
            
          
            //open seatplann for ordinary
        }

        private void OnTapRegular(object sender, EventArgs e)
        {
            BusController.SetBusType("Regular");
            BusController.SetBusFee("Regular");
            this.Navigation.PushAsync(new SeatPlanPage());
            
            
            //open seatplan for regular
        }

        private void OnTapDeluxe(object sender, EventArgs e)
        {
            BusController.SetBusType("Deluxe");
            BusController.SetBusFee("Deluxe");
            this.Navigation.PushAsync(new SeatPlanPage());
           
            
            //open seatplan for deluxe
        }
    }
}