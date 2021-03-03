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
    [Activity(Label = "AmenitiesActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class AmenitiesActivity : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Amenities);

            Button btnBack = FindViewById<Button>(Resource.Id.btnBack);
            btnBack.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };


            //items = new string[] {
            //    "Extra Blanket                                             10$",
            //    "Next Seat Free                                           30$",
            //    "Two Neighboring Seats                            50$",
            //    "Tablet Rental                                              12$",
            //    "Laptop Rental                                            15$",
            //    "Lounge Access                                           25$",
            //    "Soft Drinks                                                  Free",
            //    "Premium Headphones Rental                 5$",
            //    "Extra Bag                                                    15$",
            //    "Fast Checkin Lane                                     10$",
            //    "Wi-Fi 50 mb                                                Free",
            //    "Wi-Fi 250 mb                                              25$"};

            //SetContentView(Resource.Layout.Amenities);

            //mainList = (ListView)FindViewById<ListView>(Resource.Id.listView1);

            //mainList.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, Resource.Id.imageView1, items);


            //Button Back = FindViewById<Button>(Resource.Id.btnBack);
            //Back.Click += (sender, e) =>
            //{
            //    var intent = new Intent(this, typeof(MainActivity));
            //    StartActivity(intent);
            //};



            // Create your application here
        }
       
    }
}