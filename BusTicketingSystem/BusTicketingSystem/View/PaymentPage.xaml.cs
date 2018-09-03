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
	public partial class PaymentPage : ContentPage
	{
       

        public PaymentPage ()
		{
            Controller.Randomizer cr =new Controller.Randomizer();
            cr.GenRefNo();
            InitializeComponent ();

            Seats.Text = Controller.PaymentController.GetTotQty().ToString();
            Price.Text = Controller.PaymentController.GetTotAmt().ToString();

        }

        public void Clicked_Checkout(object sender,EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(FullName.Text) || string.IsNullOrWhiteSpace(Address.Text) || string.IsNullOrWhiteSpace(EmailAdd.Text) || string.IsNullOrWhiteSpace(Contact.Text))
            {
                DisplayAlert("", "Enter complete details!", "OK");
            }
            else
            {
                Controller.PaymentController.SetCustName(FullName.Text);
                Controller.PaymentController.SetCustNumber(Contact.Text);
                Controller.PaymentController.SetCustEmail(EmailAdd.Text);
                Controller.PaymentController.SetCustAddress(Address.Text);

                DisplayAlert("Reference No.", Controller.PaymentController.GetRefNo().ToString(), "OK");

                this.Navigation.PushAsync(new MainPage());
                this.Navigation.RemovePage(this);
            }


        }
	}
}