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
            Model.Data data_ = new Model.Data();

            data_.GetUserInfo(FullName.Text,Address.Text,EmailAdd.Text,Contact.Text);

        }
	}
}