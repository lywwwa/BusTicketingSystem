using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BusTicketingSystem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new View.BusSchedulePage());
           // this.Navigation.RemovePage(this);
        }

        public void Cancel_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("", "To Cancel Reservation go to your nearest Bus Ticketing Store. Cancellation Fee: 50.00", "OK");
            // this.Navigation.PushAsync(new View.SearchPage());
            // this.Navigation.RemovePage(this);
        }
    }
}
