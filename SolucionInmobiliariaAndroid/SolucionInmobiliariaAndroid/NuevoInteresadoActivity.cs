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
using SolucionInmobiliariaAndroid.InmobiliariaService;

namespace SolucionInmobiliariaAndroid
{
    [Activity(Label = "Morán-Villa Bienes Raices")]
    public class NuevoInteresadoActivity : Activity
    {
        EditText txNombre;
        EditText txApellido;
        EditText txTelefono;
        EditText txEmail;
        EditText txMonto;
        EditText txObservaciones;
        Spinner spnTipoMoneda;
        Spinner spnTipoInmueble;
        Spinner spnTipoOperacion;
        Spinner spnAmbientes;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.NuevoInteresado);

            LoadControls();

            
        }

        private void LoadControls()
        {
            txNombre = FindViewById<EditText>(Resource.Id.txNombre);
            txApellido = FindViewById<EditText>(Resource.Id.txApellido);
            txTelefono = FindViewById<EditText>(Resource.Id.txTelefono);
            txEmail = FindViewById<EditText>(Resource.Id.txEmail);
            txMonto = FindViewById<EditText>(Resource.Id.txMonto);
            txObservaciones = FindViewById<EditText>(Resource.Id.txObservaciones);
            spnTipoMoneda = FindViewById<Spinner>(Resource.Id.spnTipoMoneda);
            spnTipoInmueble = FindViewById<Spinner>(Resource.Id.spnTipoInmueble);
            spnTipoOperacion = FindViewById<Spinner>(Resource.Id.spnTipoOperacion);
            spnAmbientes = FindViewById<Spinner>(Resource.Id.spnAmbientes);

            Button btGuardar = FindViewById<Button>(Resource.Id.btGuardar);
            btGuardar.Click += BtGuardar_Click;

            Button btCancelar = FindViewById<Button>(Resource.Id.btCancelar);
            btCancelar.Click += BtCancelar_Click;

            List<string> tiposMoneda = new List<string>() { "Pesos", "Dólares" };
            List<string> tipoInmueble = new List<string>() { "Terreno", "Departamento",
            "Casa", "Quinta", "Local", "Fondo de Comercio", "Oficina", "Galpon"};
            List<string> tipoOperacion = new List<string>() { "Venta", "Alquiler" };
            List<string> ambientes = new List<string>() { "Monoambiente", "Dos Ambiente",
            "Tres Ambientes", "Cuatro Ambientes", "Cinco o más Ambientes" };

            spnTipoMoneda.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, tiposMoneda);
            spnTipoInmueble.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, tipoInmueble);
            spnTipoOperacion.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, tipoOperacion);
            spnAmbientes.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleSpinnerItem, ambientes);
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Finish();
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            Interesado interesado = new Interesado();
            interesado.Nombre = txNombre.Text;
            interesado.Apellido = txApellido.Text;
            interesado.Email = txEmail.Text;
            interesado.Disponible = true;
            interesado.Telefono = txTelefono.Text;
            interesado.Observaciones = txObservaciones.Text;
            interesado.MontoHasta = Convert.ToDecimal(txMonto.Text);

            if (spnTipoMoneda.SelectedItem.ToString() == "Pesos")
                interesado.TipoDeMoneda = 1;
            else
                interesado.TipoDeMoneda = 2;

            if (spnTipoInmueble.SelectedItem.ToString() == "Terreno")
            {
                interesado.TipoDeInmueble = 1;
            }
            else if (spnTipoInmueble.SelectedItem.ToString() == "Departamento")
            {
                interesado.TipoDeInmueble = 2;
            }
            else if (spnTipoInmueble.SelectedItem.ToString() == "Casa")
            {
                interesado.TipoDeInmueble = 3;
            }
            else if (spnTipoInmueble.SelectedItem.ToString() == "Quinta")
            {
                interesado.TipoDeInmueble = 4;
            }
            else if (spnTipoInmueble.SelectedItem.ToString() == "Local")
            {
                interesado.TipoDeInmueble = 5;
            }
            else if (spnTipoInmueble.SelectedItem.ToString() == "Fondo de Comercio")
            {
                interesado.TipoDeInmueble = 6;
            }
            else if (spnTipoInmueble.SelectedItem.ToString() == "Oficina")
            {
                interesado.TipoDeInmueble = 7;
            }
            else if (spnTipoInmueble.SelectedItem.ToString() == "Galpon")
            {
                interesado.TipoDeInmueble = 8;
            }

            if (spnTipoOperacion.SelectedItem.ToString() == "Venta")
            {
                interesado.TipoDeOperacion = 1;
            }
            else
            {
                interesado.TipoDeOperacion = 2;
            }
            

            if (spnAmbientes.SelectedItem.ToString() == "Monoambiente")
            {
                interesado.Ambientes = 1;
            }
            else if (spnAmbientes.SelectedItem.ToString() == "Dos Ambiente")
            {
                interesado.Ambientes = 2;
            }
            else if (spnAmbientes.SelectedItem.ToString() == "Tres Ambientes")
            {
                interesado.Ambientes = 3;
            }
            else if (spnAmbientes.SelectedItem.ToString() == "Cuatro Ambientes")
            {
                interesado.Ambientes = 4;
            }
            else if (spnAmbientes.SelectedItem.ToString() == "Cinco o más Ambientes")
            {
                interesado.Ambientes = 5;
            }

            interesado.MontoDesde = 0m;

            InmobiliariaService.Service ws = new InmobiliariaService.Service();
            ws.GuardarInteresadoAsync(interesado);

            Toast.MakeText(this, "Se está guardando el interesado!", ToastLength.Long);
            this.Finish();
        }
    }
}