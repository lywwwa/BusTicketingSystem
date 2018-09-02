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
			InitializeComponent ();
            //user info and payment details
		}

        public void Clicked_Checkout(object sender,EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(FullName.Text) || string.IsNullOrWhiteSpace(Address.Text) || string.IsNullOrWhiteSpace(EmailAdd.Text) || string.IsNullOrWhiteSpace(Contact.Text))
            {
                DisplayAlert("", "Enter complete details!", "OK");
            }
            else
            {
                Model.Data data_ = new Model.Data();

                data_.GetUserInfo(FullName.Text, Address.Text, EmailAdd.Text, Contact.Text);
                this.Navigation.PushAsync(new MainPage());
                this.Navigation.RemovePage(this);
            }


        }
	}
}