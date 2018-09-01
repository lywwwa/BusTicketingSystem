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
            
            BindingContext = new Controller.BusScheduleController();
         

        }

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ClickedSchedulePage());
        }
    }
}