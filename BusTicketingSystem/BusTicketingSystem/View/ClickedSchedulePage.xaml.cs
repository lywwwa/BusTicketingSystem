using BusTicketingSystem.Controller;
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
        Model.Data dt = new Model.Data();

        public ClickedSchedulePage ()
		{
			InitializeComponent ();

            /*
            Model.Data dt = new Model.Data();

            string prc = dt.Prices("Ordinary");
            OrdPrice.Text = prc;

            string prc1 = dt.Prices("Regular");
            RegPrice.Text = prc1;

            string prc2 = dt.Prices("Deluxe");
            DelPrice.Text = prc2;
            */
        }

        public void OnTapOrdinary(object sender, EventArgs args)
        {
            BusController.SetBusType("Ordinary");
            BusController.SetBusFee("Ordinary");
            this.Navigation.PushAsync(new SeatPlanPage());
            //string pr = dt.Prices("OrdinaryPrice");
          
            //open seatplann for ordinary
        }

        private void OnTapRegular(object sender, EventArgs e)
        {
            BusController.SetBusType("Regular");
            BusController.SetBusFee("Regular");
            this.Navigation.PushAsync(new SeatPlanPage());
            //string pr1 = dt.Prices("RegularPrice");
            
            //open seatplan for regular
        }

        private void OnTapDeluxe(object sender, EventArgs e)
        {
            BusController.SetBusType("Deluxe");
            BusController.SetBusFee("Deluxe");
            this.Navigation.PushAsync(new SeatPlanPage());
            //string pr2 = dt.Prices("DeluxePrice");
            
            //open seatplan for deluxe
        }
    }
}