using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using GR.Net.Maroulis.Library;
using Android.Graphics;
using Android.Views;
using App1;

namespace UGYM
{
    [Activity(Label = "UGYM",/*MainLauncher = true,*/ Icon = "@drawable/logo_nuevo", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SplashActivity : AppCompatActivity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            var config = new EasySplashScreen(this)
                .WithFullScreen()
                .WithTargetActivity(Java.Lang.Class.FromType(typeof(HomeActivity)))
                .WithSplashTimeOut(5000)
                .WithBackgroundResource(Color.White)
                .WithHeaderText("Header")
                .WithFooterText("Copyright 2016")
                .WithBeforeLogoText("My cool company")
                .WithLogo(Resource.Drawable.logo_nuevo)
                .WithAfterLogoText("Some more details");

                config.BeforeLogoTextView.SetTextColor(Color.Gray);
                config.FooterTextView.SetTextColor(Color.Gray);
                config.AfterLogoTextView.SetTextColor(Color.Gray);

            View view = config.Create();

            //SetContentView(Resource.Layout.Splash);

        }
    }
}

