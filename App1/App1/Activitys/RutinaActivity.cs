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
    public class RutinaActivity : ListActivity
    {

        ListView rutinas;
        string[] items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RutinList);

            rutinas = FindViewById<ListView>(Resource.Id.lv_rutinas);
            items = new string[] { "Día 1", "Día 2", "Día 3", "Día 4", "Día 5" };
            rutinas.
            // Create your application here
        }
    }
}