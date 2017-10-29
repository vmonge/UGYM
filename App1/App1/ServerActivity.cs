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
using MySql.Data.MySqlClient;
using System.Data;
using UGYM;
using App1.Resources.DataBaseMySQL;

namespace App1
{
    [Activity(Label = "Conneccion con el servodor")]
    public class ServerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Server);
            Button bn = FindViewById<Button>(Resource.Id.b_try_conn);

            bn.Click += Bn_Click;

            
        }

        private void Bn_Click(object sender, EventArgs e)
        {
            string error;
            MySQLconn conn = new MySQLconn(); 
            try
            {
                if (conn.TryConnection(out error))
                {
                    Toast.MakeText(this, "Conexion exitosa", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "Error al conectar: ", ToastLength.Long).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, "Problema al consultar: " + ex, ToastLength.Long).Show();
                throw;
            };
        }
    }
}