using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using GR.Net.Maroulis.Library;
using Android.Graphics;
using Android.Views;

namespace UGYM
{
    [Activity(Label = "SplashScreen",MainLauncher = true, Icon = "@drawable/logo_nuevo" , Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            var config = new EasySplashScreen(this)
                .WithFullScreen()
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(HomeActivity)))
                .WithSplashTimeOut(5000) // 5 sec
                .WithBackgroundColor(Color.White)
                .WithFooterText("Copyright 2017")
                .WithBeforeLogoText("EDMT Dev co,Ltd")
                .WithAfterLogoText("This is Easy Splash Screen");

            config.BeforeLogoTextView.SetTextColor(Color.Gray);
            config.FooterTextView.SetTextColor(Color.Gray);
            config.AfterLogoTextView.SetTextColor(Color.Gray);

            View view = config.Create();
            SetContentView(view);

            //SetContentView(Resource.Layout.Splash);


        }
    }
}

