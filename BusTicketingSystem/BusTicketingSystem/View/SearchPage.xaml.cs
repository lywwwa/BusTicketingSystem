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
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
		}

        public async void Clicked_Search(object a,EventArgs e)
        {
            if (ReservationNo.Text.Equals(Controller.PaymentController.GetRefNo()))
            {
                var cancelq = await DisplayAlert("!!", "Cancel Reservation?", "Yes", "No");

                if (cancelq)
                {
                    Controller.PaymentController.SetCustName("");
                    Controller.PaymentController.SetCustNumber("");
                    Controller.PaymentController.SetCustEmail("");
                    Controller.PaymentController.SetCustAddress("");
                    Controller.PaymentController.SetRefNo(0);
                    Controller.PaymentController.SetTotQty(0);
                    Controller.PaymentController.SetTotAmt(0);
                }
            }
            else
            {
                await DisplayAlert("", "Not Found", "OK");
            }
        }
	}
}