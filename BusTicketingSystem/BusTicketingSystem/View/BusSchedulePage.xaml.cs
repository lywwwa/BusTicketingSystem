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
	public partial class BusSchedulePage : ContentPage
	{
		public BusSchedulePage ()
		{
			InitializeComponent ();
		}

        public void OnItemSelected(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ClickedSchedulePage());
        }
    }
}