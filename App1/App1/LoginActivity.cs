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
    [Activity(Label = "Login", MainLauncher = true , Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.Login);
            base.OnCreate(savedInstanceState);
            
            // Create your application here
        }
    }
}