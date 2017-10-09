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

namespace UGYM
{
    [Activity(Label = "UGYM", MainLauncher = true, Icon = "@drawable/logo_nuevo", Theme = "@style/MyTheme.Splash", NoHistory = true)]
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
            Rutina rutina1 = new Rutina()
            {
                Dia = "Dia 1",
                Nombre = "Hombros y Piernas"
            };
            Rutina rutina2 = new Rutina()
            {
                Dia = "Dia 2",
                Nombre = "Espalda y Pectorales"
            };
            Rutina rutina3 = new Rutina()
            {
                Dia = "Dia 3",
                Nombre = "Brazos y Abdomen"
            };
            try
            {
                db = new DataBase();
                if (true)
                {
                    db.DeleteQueryTablaRutina();
                    //db.InsertTableRutina(rutina1);
                    //db.InsertTableRutina(rutina2);
                    //db.InsertTableRutina(rutina3);
                    StartActivity(new Intent(Application.Context, typeof(LoginActivity)));
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

