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
    [Activity(Label = "About_our_airlinesActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class About_our_airlinesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.About_our_airlines);

            Button btnBack = FindViewById<Button>(Resource.Id.btnBack);
            btnBack.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}