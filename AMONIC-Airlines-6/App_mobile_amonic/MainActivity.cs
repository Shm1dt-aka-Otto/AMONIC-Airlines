using Android.App;
using System;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Content.PM;

namespace App_mobile_amonic
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
    
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
           
            Button btnAoa = FindViewById<Button>(Resource.Id.About_our_airline);
            Button btnAmenities = FindViewById<Button>(Resource.Id.button3);
            Button btnRS = FindViewById<Button>(Resource.Id.Reserve_Seat);


            btnAoa.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(About_our_airlinesActivity));
                StartActivity(intent);
            };

            btnAmenities.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(AmenitiesActivity));
                StartActivity(intent);
            };

            btnRS.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ReserveSeat));
                StartActivity(intent);
            };


        }

        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}