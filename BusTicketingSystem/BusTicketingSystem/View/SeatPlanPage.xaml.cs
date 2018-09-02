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
	public partial class SeatPlanPage : ContentPage
	{
		public SeatPlanPage ()
		{
            //grids
			InitializeComponent ();
		}

        public void Clicked_Seat(object sender,EventArgs e)
        {
            BackgroundColor = Color.FromHex("#63539e");
        }

        public async void Clicked_Checkout(object sender,EventArgs e)
        {
            /*if (seat==0){
             *  var autoseat = await DisplayAlert("Question?", "You didn't choose a seat.Continue?", "Yes", "No");
        }*/
           
            var check = await DisplayAlert("Question?", "Are you sure?", "Yes", "No");
            //Debug.WriteLine("Answer: " + answer);
            if (check)
            {
                await Navigation.PushAsync(new PaymentPage());
            }
           
            
        }
	}
}