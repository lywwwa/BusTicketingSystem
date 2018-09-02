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
        int qty = 0;
        int tapCount;

		public SeatPlanPage ()
		{
            //grids
			InitializeComponent ();
		}

        public void Clicked_Seat1(object sender,EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s1.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s1.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }
            
            
            Quantity.Text = ""+qty;
        }

        public void Clicked_Seat2(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s2.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s2.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }

        public void Clicked_Seat3(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s3.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s3.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }

        public void Clicked_Seat4(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s4.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s4.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }

        public void Clicked_Seat5(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s5.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s5.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat6(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s6.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s6.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat7(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s7.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s7.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat8(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s8.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s8.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat9(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s9.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s9.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat10(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s10.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s10.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat11(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s11.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s11.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat12(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s12.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s12.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat13(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s13.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s13.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat14(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s14.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s14.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat15(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s15.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s15.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat16(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s16.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s16.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat17(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s17.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s17.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat18(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s18.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s18.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat19(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s19.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s19.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat20(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s20.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s20.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat21(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s21.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s21.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat22(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s22.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s22.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat23(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s23.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s23.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat24(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s24.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s24.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat25(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s25.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s25.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat26(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s26.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s26.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat27(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s27.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s27.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat28(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s28.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s28.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }


            Quantity.Text = "" + qty;
        }
        public void Clicked_Seat29(object sender, EventArgs e)
        {
            tapCount++;

            if (tapCount % 2 == 0)
            {
                s29.BackgroundColor = Color.FromHex("#52add4");
                qty--;
            }
            else
            {
                s29.BackgroundColor = Color.FromHex("#63539e");
                qty++;
            }

            
            Quantity.Text = "" + qty;
        }
    
        public async void Clicked_Checkout(object sender,EventArgs e)
        {
            if (Quantity.Text=="0"){
               var autoseat = await DisplayAlert("Question?", "You didn't choose a seat.Continue?", "Yes", "No");
        }
           
            var check = await DisplayAlert("Question?", "Are you sure?", "Yes", "No");
            //Debug.WriteLine("Answer: " + answer);
            if (check)
            {
                await Navigation.PushAsync(new PaymentPage());
            }
           
            
        }
	}
}