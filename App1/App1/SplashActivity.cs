using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using GR.Net.Maroulis.Library;
using Android.Graphics;
using Android.Views;
using App1;
using System.Threading.Tasks;
using Android.Util;
using Android.Content;
using UGYM.Resources.DataHelperSQLite;
using App1.Resources.Model;
using Android.Database;
using System;
using SQLite;
using Android.Database.Sqlite;
using System.Data;

namespace UGYM
{
    [Activity(Label = "UGYM", Icon = "@drawable/logo_nuevo", MainLauncher = true, Theme = "@style/MyTheme.Splash", NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        DataBase db;
        
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");
        }

        // Prevent the back button from canceling the startup process
        public override void OnBackPressed() { }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {
            Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
            await Task.Delay(5000); // Simulate a bit of startup work.
            Log.Debug(TAG, "Startup work is finished - starting MainActivity.");

            try
            {
                db = this.getWritableDatabase();
                String count = "SELECT count(*) FROM Usuario";
                ICursor mcursor = db.RawQuery(count, null);
                mcursor.MoveToFirst();
                int icount = mcursor.GetInt(0);
                if (icount > 0)
                {
                    StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
                }
                else
                {
                    StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            
            try
            {
                db = new DataBase();
                if (true)
                {
                    db.DeleteQueryTablaRutina();
                    
                    StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
                }
                else
                {
                    StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}

