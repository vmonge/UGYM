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
using GR.Net.Maroulis.Library;

namespace UGYM
{
    [Activity(Label = "HomeActivity", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class HomeActivity : AppCompatActivity
    {
        int count = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Home);
        }
    }
}