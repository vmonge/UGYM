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
using App1;
using App1.Resources.Model;
using UGYM.Resources.DataHelperSQLite;
using UGYM.Resources;
using App1.Resources;

namespace UGYM
{
    [Activity(Label = "ListActivity")]
    public class ListActivity : Activity
    {

        int rutina = 0;
        ListView listData;
        List<Rutina> listRutina = new List<Rutina>();
        DataBase db;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DayList);
            
            //Create Data Base
            //db = new DataBase();
            //db.createDataBase();

            listData = FindViewById<ListView>(Resource.Id.lv_days);

            //Load data
            LoadData();

            //Event
            listData.ItemClick += delegate
              {
                  //Set backup for selected item

              };
        }

        private void LoadData()
        {
            var messageDialog = new Android.App.AlertDialog.Builder(this);
            try
            {
                listRutina = db.SelectTableRutina();
                var adapter = new ListViewAdapter(this, listRutina);
                listData.Adapter = adapter;
            }
            catch (Exception ex)
            {
                messageDialog.SetMessage("Error: " + ex);
                messageDialog.SetNeutralButton("Try again later", delegate { });
                messageDialog.Show();
            }
            
        }
    }
}