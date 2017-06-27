using Android.App;
using Android.Widget;
using Android.OS;

namespace UGYM
{
    [Activity(Theme ="@style/MyTheme.Splash",MainLuncher = true,NoHistory =true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task starWork = new Task(() =>
            {
                Task.Delay(3000);
            });

            startupWork.ContinueWith(t => {
                StartActivity(new Intent(Application.Context, typeof(HomeActivity)));
            },TaskSheduler.FromCurrentSynchronizationContext());

            starWork.Start();
        }
    }
}

