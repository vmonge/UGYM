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

namespace App1
{
    [Activity(Label = "MenuActivity")]
    public class RutinaActivity : Activity
    {

        Button button;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            button = FindViewById<Button>(Resource.Id.b_siguente);

            button.Click += delegate {
                try
                {
                    var imageView = FindViewById<ImageView>(Resource.Id.imageView1);
                    imageView.SetImageResource(Resource.Drawable.curl_concentrado);
                }
                catch (Exception ex)
                {
                    messageDialog.SetMessage("Error, contaseña incorrecta " + ex);
                    messageDialog.SetNeutralButton("Intenta de nuevo.", delegate { });
                    messageDialog.Show();
                }
            };           


        // Create your application here
    }
    }
}