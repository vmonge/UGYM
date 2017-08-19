using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using App1;

namespace UGYM
{
    [Activity(Label = "HomeActivity", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class HomeActivity : Activity
    {
        private Button empezar, mensa, log_out, info;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            empezar = FindViewById<Button>(Resource.Id.b_empezar);
            mensa = FindViewById<Button>(Resource.Id.b_log_out);
            log_out = FindViewById<Button>(Resource.Id.b_log_out);
            info = FindViewById<Button>(Resource.Id.b_info);

            empezar.Click += (sender, e) =>
            {
                var messageDialog = new Android.App.AlertDialog.Builder(this);

                try
                {
                    var intent = new Intent(this, typeof(ListActivity));
                    StartActivity(intent);
                }
                catch (Exception ex)
                {
                    messageDialog.SetMessage("Error: " + ex);
                    messageDialog.SetNeutralButton("Try again later", delegate { });
                    messageDialog.Show();
                }
            
            };

            mensa.Click += (sender, e) =>
            {
                var messageDialog = new Android.App.AlertDialog.Builder(this);

                try
                {
                    var intent = new Intent(this, typeof(RutinaActivity));
                    StartActivity(intent);
                }
                catch (Exception ex)
                {
                    messageDialog.SetMessage("Error: " + ex);
                    messageDialog.SetNeutralButton("Try again later", delegate { });
                    messageDialog.Show();
                }

            };

            log_out.Click += (sender, e) =>
            {
                var messageDialog = new Android.App.AlertDialog.Builder(this);

                try
                {
                    var intent = new Intent(this, typeof(LoginActivity));
                    StartActivity(intent);
                }
                catch (Exception ex)
                {
                    messageDialog.SetMessage("Error: " + ex);
                    messageDialog.SetNeutralButton("Try again later", delegate { });
                    messageDialog.Show();
                }

            };

            info.Click += (sender, e) =>
            {
                var messageDialog = new Android.App.AlertDialog.Builder(this);

                try
                {
                    var intent = new Intent(this, typeof(InformacionActivity));
                    StartActivity(intent);
                }
                catch (Exception ex)
                {
                    messageDialog.SetMessage("Error: " + ex);
                    messageDialog.SetNeutralButton("Try again later", delegate { });
                    messageDialog.Show();
                }

            };
        }
    }
}