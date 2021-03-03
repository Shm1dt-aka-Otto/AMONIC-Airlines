using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_mobile_amonic
{
    [Activity(Label = "ReserveSeat", ScreenOrientation = ScreenOrientation.Portrait)]
    public class ReserveSeat : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Create your application here
            SetContentView(Resource.Layout.Reserve_seat);
            

            var ImgFirst = FindViewById<ImageView>(Resource.Id.imageView1);
            var ImgBusiness = FindViewById<ImageView>(Resource.Id.imageView1);
            var edtTicketNumber = FindViewById<EditText>(Resource.Id.editText1);

            Button btnNext = FindViewById<Button>(Resource.Id.button2);
            btnNext.Click += (sender, e) =>
            {
                int count = 1;
                edtTicketNumber.Text = "";
                if (count % 2 == 0 )
                {
                    ImgBusiness.Visibility = ViewStates.Visible;
                    count++;
                }
                else
                {
                    ImgFirst.Visibility = ViewStates.Visible;
                    count++;
                }

            };

            Button btnResSeat = FindViewById<Button>(Resource.Id.button1);
            btnResSeat.Click += (sender, e) =>
            {
                ImgFirst.Visibility = ViewStates.Invisible;
                ImgBusiness.Visibility = ViewStates.Invisible;
                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Confirm reserve");
                alert.SetMessage("You have successfully booked your seat");
                alert.SetNegativeButton("Ok", (senderAlert, args) => {
                    Toast.MakeText(this, "Goodluck!", ToastLength.Short).Show();
                });
                Dialog dialog = alert.Create();
                dialog.Show();

            };

            Button btnBack = FindViewById<Button>(Resource.Id.btnBack);
            btnBack.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}