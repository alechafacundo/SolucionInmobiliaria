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

namespace SolucionInmobiliariaAndroid
{
    [Activity(Label = "Morán-Villa Bienes Raices", Icon ="@drawable/logo")]
    public class HomeActivity : Activity
    {
        int vendedorId;
        string vendedorNombre;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Home);

            vendedorId = Intent.GetIntExtra("Id", 0);
            vendedorNombre = Intent.GetStringExtra("Nombre");

            TextView txNombre = FindViewById<TextView>(Resource.Id.txUsuario);
            txNombre.SetText("Bienvenido " + vendedorNombre + "!", TextView.BufferType.Normal);

            Button btNuevoInmueble = FindViewById<Button>(Resource.Id.btNuevoInmueble);
            btNuevoInmueble.Click += new EventHandler(NuevoInmueble);

            Button btNuevoInteresado = FindViewById<Button>(Resource.Id.btNuevaInteresado);
            btNuevoInteresado.Click += BtNuevoInteresado_Click;
        }

        private void BtNuevoInteresado_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(NuevoInteresadoActivity));
            intent.PutExtra("vendedorId", vendedorId);
            StartActivity(intent);
        }

        private void NuevoInmueble(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(NuevoInmuebleActivity));
            intent.PutExtra("vendedorId", vendedorId);
            StartActivity(intent);
        }
    }
}