using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SolucionInmobiliariaAndroid.InmobiliariaService;

namespace SolucionInmobiliariaAndroid
{
    [Activity(Label = "Morán-Villa Bienes Raices", MainLauncher = true, Icon = "@drawable/logo")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btLogin = FindViewById<Button>(Resource.Id.btLogin);
            EditText txUsuario = FindViewById<EditText>(Resource.Id.txUsuario);
            EditText txPassword = FindViewById<EditText>(Resource.Id.txPassword);

            btLogin.Click += delegate 
            {
                string email = txUsuario.Text.Trim();
                if (!email.Contains("@moranvilla.com.ar"))
                {
                    email += "@moranvilla.com.ar";
                }
                string password = txPassword.Text.Trim();

                if (email == string.Empty || password == string.Empty)
                {
                    //no esta completo el login
                }

                InmobiliariaService.Service ws = new InmobiliariaService.Service();
                Vendedor vendedor = ws.Login(email, password);

                if (vendedor != null)
                {
                    Intent intent = new Intent(this, typeof(HomeActivity));
                    intent.PutExtra("Id", vendedor.Id);
                    intent.PutExtra("Nombre", vendedor.Nombre);
                    StartActivity(intent);
                    Finish();
                }
            };
        }
    }
}

