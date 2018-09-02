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

            Model.Data dt = new Model.Data();

            string prc = dt.Prices("OrdinaryPrice");
            OrdPrice.Text = prc;

            string prc1 = dt.Prices("RegularPrice");
            RegPrice.Text = prc1;

            string prc2 = dt.Prices("DeluxePrice");
            DelPrice.Text = prc2;

        }

        public void OnTapOrdinary(object sender, EventArgs args)
        {
            this.Navigation.PushAsync(new SeatPlanPage());
            //open seatplann for ordinary
        }

        private void OnTapRegular(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SeatPlanPage());
            //open seatplan for regular
        }

        private void OnTapDeluxe(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SeatPlanPage());
            //open seatplan for deluxe
        }
    }
}