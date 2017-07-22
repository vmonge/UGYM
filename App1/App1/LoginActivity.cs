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
using App1;
using System.Threading.Tasks;

namespace UGYM
{
    [Activity(Label = "Login", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class LoginActivity : Activity
    {
        Button login;
        EditText email, pass;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.Login);
            base.OnCreate(savedInstanceState);

            login = FindViewById<Button>(Resource.Id.b_login);
            email = FindViewById<EditText>(Resource.Id.editText1);
            pass = FindViewById<EditText>(Resource.Id.editText2);

            email.Focusable = true;


            login.Click += (sender, e) =>
            {
                var messageDialog = new Android.App.AlertDialog.Builder(this);
                try
                {
                    if (pass.Text != string.Empty && email.Text != string.Empty)
                    {
                        if (Android.Util.Patterns.EmailAddress.Matcher(email.Text).Matches())
                        {
                            if (email.Text == "nojodagoso@gmail.com")
                            {
                                if (pass.Text == "12345")
                                {
                                    var intent = new Intent(this, typeof(HomeActivity));
                                    StartActivity(intent);
                                }
                                else
                                {
                                    messageDialog.SetMessage("Error, contaseña incorrecta ");
                                    messageDialog.SetNeutralButton("Try again", delegate { });
                                    messageDialog.Show();
                                    pass.Focusable = true;
                                }

                            }
                            else
                            {
                                messageDialog.SetMessage("Error, correo no encontrado ");
                                messageDialog.SetNeutralButton("Try again", delegate { });
                                messageDialog.Show();
                                email.Focusable = true;
                            }
                        }
                        else
                        {
                            messageDialog.SetMessage("Error, por favor ingrese el correo valido ");
                            messageDialog.SetNeutralButton("Ok", delegate { });
                            messageDialog.Show();
                            email.Focusable = true;
                        }
                    }
                    else
                    {
                        messageDialog.SetMessage("Error, por favor ingrese el correo y la contraseña ");
                        messageDialog.SetNeutralButton("Ok", delegate { });
                        messageDialog.Show();
                        email.Focusable = true;
                    }
                }
                catch (Exception)
                {
                    
                    messageDialog.SetMessage("Error: ");
                    messageDialog.SetNeutralButton("Try again later", delegate { });
                    messageDialog.Show();
                }

            };

            //var callDialog = new AlertDialog.Builder(this);
            //callButton.Click += (sender, e) =>
            //{
            //    // On "Call" button click, try to dial phone number.
                
            //    callDialog.SetMessage("Call " + translatedNumber + "?");
            //    callDialog.SetNeutralButton("Call", delegate
            //    {
            //        // add dialed number to list of called numbers.
            //        phoneNumbers.Add(translatedNumber);
            //        // enable the Call History button
            //        callHistoryButton.Enabled = true;

            //        // Create intent to dial phone
            //        var callIntent = new Intent(Intent.ActionDial);
            //        callIntent.SetData(Uri.Parse("tel:" + translatedNumber));
            //        StartActivity(callIntent);
            //    });
            //    callDialog.SetNegativeButton("Cancel", delegate { });

                //DisplayAlert("Warnning", "Wrong password, please try again", "Try Again");

                //login.Click += Valida_login;
                // Create your application here
        }
    }
}