using BusTicketingSystem.Controller;
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
        int tapCount=0, tapCount1 = 0, tapCount2 = 0,tapCount3=0, tapCount4=0, tapCount5 = 0, tapCount6 = 0, tapCount7 = 0, tapCount8 = 0, tapCount9 = 0, tapCount10=0;
        int tapCount11 = 0, tapCount12 = 0, tapCount13 = 0, tapCount14 = 0, tapCount15 = 0, tapCount16 = 0, tapCount17 = 0, tapCount18 = 0, tapCount19 = 0, tapCount20 = 0, tapCount21 = 0;
        int tapCount22 = 0, tapCount23 = 0, tapCount24 = 0, tapCount25 = 0, tapCount26 = 0, tapCount27 = 0, tapCount28 = 0;
        
        public SeatPlanPage ()
		{
            
            InitializeComponent ();
            overlay.IsVisible = false;
            Price.Text = (BusController.GetBusFee()).ToString();
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
            
            Quantity.Text = "" + qty;
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }

        public void Clicked_Seat2(object sender, EventArgs e)
        {
            tapCount1++;

            if (tapCount1 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }

        public void Clicked_Seat3(object sender, EventArgs e)
        {
            tapCount2++;

            if (tapCount2 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }

        public void Clicked_Seat4(object sender, EventArgs e)
        {
            tapCount3++;

            if (tapCount3 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }

        public void Clicked_Seat5(object sender, EventArgs e)
        {
            tapCount4++;

            if (tapCount4 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat6(object sender, EventArgs e)
        {
            tapCount5++;

            if (tapCount5 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat7(object sender, EventArgs e)
        {
            tapCount6++;

            if (tapCount6 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat8(object sender, EventArgs e)
        {
            tapCount7++;

            if (tapCount7 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat9(object sender, EventArgs e)
        {
            tapCount8++;

            if (tapCount8 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat10(object sender, EventArgs e)
        {
            tapCount9++;

            if (tapCount9 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat11(object sender, EventArgs e)
        {
            tapCount10++;

            if (tapCount10 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat12(object sender, EventArgs e)
        {
            tapCount11++;

            if (tapCount11 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat13(object sender, EventArgs e)
        {
            tapCount12++;

            if (tapCount12 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat14(object sender, EventArgs e)
        {
            tapCount13++;

            if (tapCount13 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat15(object sender, EventArgs e)
        {
            tapCount14++;

            if (tapCount14 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat16(object sender, EventArgs e)
        {
            tapCount15++;

            if (tapCount15 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat17(object sender, EventArgs e)
        {
            tapCount16++;

            if (tapCount16 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat18(object sender, EventArgs e)
        {
            tapCount17++;

            if (tapCount17 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat19(object sender, EventArgs e)
        {
            tapCount18++;

            if (tapCount18 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat20(object sender, EventArgs e)
        {
            tapCount19++;

            if (tapCount19 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat21(object sender, EventArgs e)
        {
            tapCount20++;

            if (tapCount20 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat22(object sender, EventArgs e)
        {
            tapCount21++;

            if (tapCount21 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat23(object sender, EventArgs e)
        {
            tapCount22++;

            if (tapCount22 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat24(object sender, EventArgs e)
        {
            tapCount23++;

            if (tapCount23 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat25(object sender, EventArgs e)
        {
            tapCount24++;

            if (tapCount24 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat26(object sender, EventArgs e)
        {
            tapCount25++;

            if (tapCount25 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat27(object sender, EventArgs e)
        {
            tapCount26++;

            if (tapCount26 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat28(object sender, EventArgs e)
        {
            tapCount27++;

            if (tapCount27 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
        public void Clicked_Seat29(object sender, EventArgs e)
        {
            tapCount28++;

            if (tapCount28 % 2 == 0)
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
            TotAmt.Text = (qty * BusController.GetBusFee()).ToString();
        }
    
        public async void Clicked_Checkout(object sender,EventArgs e)
        {
            if (Quantity.Text==""||Quantity.Text==" "||Quantity.Text=="0"){
               var autoseat = await DisplayAlert("Question?", "You didn't choose a seat.Continue?", "Yes", "No");

                if (autoseat)
                {

                    overlay.IsVisible = true;
                    s1.IsEnabled = false;
                    s2.IsEnabled = false;
                    s3.IsEnabled = false;
                    s4.IsEnabled = false;
                    s5.IsEnabled = false;
                    s6.IsEnabled = false;
                    s7.IsEnabled = false;
                    s8.IsEnabled = false;
                    s9.IsEnabled = false;
                    s10.IsEnabled = false;
                    s11.IsEnabled = false;
                    s12.IsEnabled = false;
                    s13.IsEnabled = false;
                    s14.IsEnabled = false;
                    s15.IsEnabled = false;
                    s16.IsEnabled = false;
                    s17.IsEnabled = false;
                    s18.IsEnabled = false;
                    s19.IsEnabled = false;
                    s20.IsEnabled = false;
                    s21.IsEnabled = false;
                    s22.IsEnabled = false;
                    s23.IsEnabled = false;
                    s24.IsEnabled = false;
                    s25.IsEnabled = false;
                    s26.IsEnabled = false;
                    s27.IsEnabled = false;
                    s28.IsEnabled = false;
                    s29.IsEnabled = false;


                }
        }
            else
            {
                var check = await DisplayAlert("Question?", "Are you sure?", "Yes", "No");
                if (check)
                {
                    Controller.PaymentController.SetTotAmt((qty * BusController.GetBusFee()));
                    Controller.PaymentController.SetTotQty(qty);
                    await Navigation.PushAsync(new PaymentPage());
                }


            }

        }
        public async void Done_Clicked(object a,EventArgs e)
        {
            Controller.PaymentController.SetTotAmt((int.Parse(qtyseats.Text) * BusController.GetBusFee()));
            Controller.PaymentController.SetTotQty(int.Parse(qtyseats.Text));
            await Navigation.PushAsync(new PaymentPage());
        }
        public void Cancel_Clicked(object sender,EventArgs e)
        {
            overlay.IsVisible = false;
            s1.IsEnabled = true;
            s2.IsEnabled = true;
            s3.IsEnabled = true;
            s4.IsEnabled = true;
            s5.IsEnabled = true;
            s6.IsEnabled = true;
            s7.IsEnabled = true;
            s8.IsEnabled = true;
            s9.IsEnabled = true;
            s10.IsEnabled = true;
            s11.IsEnabled = true;
            s12.IsEnabled = true;
            s13.IsEnabled = true;
            s14.IsEnabled = true;
            s15.IsEnabled = true;
            s16.IsEnabled = true;
            s17.IsEnabled = true;
            s18.IsEnabled = true;
            s19.IsEnabled = true;
            s20.IsEnabled = true;
            s21.IsEnabled = true;
            s22.IsEnabled = true;
            s23.IsEnabled = true;
            s24.IsEnabled = true;
            s25.IsEnabled = true;
            s26.IsEnabled = true;
            s27.IsEnabled = true;
            s28.IsEnabled = true;
            s29.IsEnabled = true;
        }
	}
}