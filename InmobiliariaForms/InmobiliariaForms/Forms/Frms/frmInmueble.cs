using InmobiliariaForms.InmobiliariaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    public partial class frmInmueble : Form
    {
        List<Vendedor> vendedores = new List<Vendedor>();
        public Inmueble Inmueble { get; set; }
        public Vendedor Vendedor { get; set; }

        public frmInmueble()
        {
            InitializeComponent();
        }



        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string errores = ValidarCamposObligatorios();
                if (errores == string.Empty)
                {
                    if (Inmueble == null)
                        Inmueble = new Inmueble();


                    eTipoInmueble tipoInmueble;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);
                    Inmueble.Tipo = (int)tipoInmueble;

                    eUbicacion ubicacion;
                    Enum.TryParse<eUbicacion>(cbUbicacion.SelectedValue.ToString(), out ubicacion);
                    Inmueble.Ubicacion = ubicacion.ToString();

                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);
                    Inmueble.Operacion = (int)tipoOperacion;

                    eMoneda tipoMoneda;
                    Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out tipoMoneda);
                    Inmueble.Moneda = (int)tipoMoneda;

                    eEstado estado;
                    Enum.TryParse<eEstado>(cbEstado.SelectedValue.ToString(), out estado);
                    Inmueble.Estado = (int)estado;

                    eCochera cochera;
                    Enum.TryParse<eCochera>(cbCochera.SelectedValue.ToString(), out cochera);
                    Inmueble.Cochera = (int)cochera == 0 ? false : true;

                    eAmbientes ambiente;
                    Enum.TryParse<eAmbientes>(cbAmbientes.SelectedValue.ToString(), out ambiente);
                    Inmueble.Ambientes = (int)ambiente;

                    Inmueble.Fecha = dateTimeFecha.Value;
                    Inmueble.Localidad = cbLocalidad.SelectedValue.ToString();
                    Inmueble.Calle = txCalle.Text.ToUpperInvariant();
                    Inmueble.Antiguedad = txAntiguedad.Text.ToUpperInvariant();
                    Inmueble.Comentarios = txComentariosInternos.Text.ToUpperInvariant();
                    Inmueble.Numero = txNumero.Text.ToUpperInvariant();
                    Inmueble.Piso = txPiso.Text.ToUpperInvariant();
                    Inmueble.Departamento = txDepto.Text.ToUpperInvariant();
                    Inmueble.EntreCalles = txEntreCalles.Text.ToUpperInvariant();
                    Inmueble.Metros2Terreno = txMtsTerreno.Text.ToUpperInvariant();
                    Inmueble.SupCubierta = txSupCubierta.Text.ToUpperInvariant();
                    Inmueble.Observaciones = txObservaciones.Text.ToUpperInvariant();
                    Inmueble.Contacto = txContacto.Text.ToUpperInvariant();
                    Inmueble.Referencia = txReferencia.Text.ToUpperInvariant();
                    Inmueble.Precio = numPrecio.Value;
                    Inmueble.CargadoPor = ((Vendedor)cbCargadoPor.SelectedItem).Id;
                    Inmueble.Disponible = checkDisponible.Checked;
                    Inmueble.Provincia = txLocalidad.Text.ToUpperInvariant();

                    

                    int inmuebleId = ServiceHelper.ws.GuardarInmueble(Inmueble);

                    
                    Inmueble.Id = inmuebleId;
                    MessageBox.Show("Inmueble guardado correctamente. Puede Agregar Fotos ahora si lo desea!");

                    try
                    {
                        ServiceHelper.ws.NotificarSobreInteresadoAsync(Inmueble, ServiceHelper.ValorDolar);
                    }
                    catch (Exception)
                    {
                    }


                    frmInmueble frmInmueble = new frmInmueble();
                    frmInmueble.Inmueble = Inmueble;

                    frmInmueble.MdiParent = (Form)this.Parent.Parent;
                    Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
                    p.Controls.Add(frmInmueble);

                    frmInmueble.BringToFront();
                    frmInmueble.StartPosition = FormStartPosition.Manual;

                    frmInmueble.Location = new Point(120, 0);
                    this.Close();
                    frmInmueble.Show();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errores, "Error de Validación");
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw ex;
            }

        }

        private string ValidarCamposObligatorios()
        {
            try
            {
                if (cbTipoInmueble.SelectedItem != null)
                {
                    eTipoInmueble tipoInmueble;
                    Enum.TryParse<eTipoInmueble>(cbTipoInmueble.SelectedValue.ToString(), out tipoInmueble);

                    if (tipoInmueble == eTipoInmueble.Sin_Especificar)
                    {
                        return "Seleccione un tipo de Inmueble por favor";
                    }
                }

                if (cbCargadoPor.SelectedItem == null)
                    return "Seleccione un Vendedor por favor";

                if (cbMoneda.SelectedItem != null)
                {
                    eMoneda tipoMoneda;
                    Enum.TryParse<eMoneda>(cbMoneda.SelectedValue.ToString(), out tipoMoneda);

                    if (tipoMoneda == eMoneda.Sin_Especificar)
                    {
                        return "Seleccione un tipo de Moneda por favor";
                    }
                }

                if (cbTipoOperacion.SelectedItem != null)
                {
                    eTipoOperacion tipoOperacion;
                    Enum.TryParse<eTipoOperacion>(cbTipoOperacion.SelectedValue.ToString(), out tipoOperacion);

                    if (tipoOperacion == eTipoOperacion.Sin_Especificar)
                    {
                        return "Seleccione un tipo de Operación por favor";
                    }
                }

                return string.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmInmueble_Load(object sender, EventArgs e)
        {
            try
            {
                cbTipoInmueble.DataSource = Enum.GetNames(typeof(eTipoInmueble));
                cbTipoInmueble.SelectedItem = eTipoInmueble.Sin_Especificar;

                cbTipoOperacion.DataSource = Enum.GetNames(typeof(eTipoOperacion));
                cbTipoOperacion.SelectedItem = eTipoOperacion.Sin_Especificar;

                cbMoneda.DataSource = Enum.GetNames(typeof(eMoneda));
                cbMoneda.SelectedItem = eMoneda.Peso;

                cbAmbientes.DataSource = Enum.GetNames(typeof(eAmbientes));
                cbAmbientes.SelectedItem = eAmbientes.Sin_Especificar;

                cbCochera.DataSource = Enum.GetNames(typeof(eCochera));
                cbCochera.SelectedItem = eCochera.No;

                cbUbicacion.DataSource = Enum.GetNames(typeof(eUbicacion));
                cbUbicacion.SelectedItem = eUbicacion.Sin_Especificar;

                cbEstado.DataSource = Enum.GetNames(typeof(eEstado));
                cbEstado.SelectedItem = eEstado.Sin_Especificar;

                cbLocalidad.DataSource = Enum.GetNames(typeof(eLocalidad));
                cbLocalidad.SelectedIndex = (int)eLocalidad.La_Pampa;

                vendedores = ServiceHelper.ws.GetVendedores().ToList();
                cbCargadoPor.DataSource = vendedores;
                cbCargadoPor.DisplayMember = "FullName";
                cbCargadoPor.ValueMember = "Id";
                cbCargadoPor.SelectedItem = null;
                cbCargadoPor.Enabled = false;

                if (this.Vendedor != null)
                {
                    cbCargadoPor.SelectedValue = Vendedor.Id;
                }

                if (Inmueble != null)
                {
                    btPublicarWeb.Enabled = true;
                    btGuardarFotos.Enabled = true;
                    btVerFotos.Enabled = true;

                    btEliminar.Visible = true;
                    cbTipoInmueble.SelectedIndex = (int)Inmueble.Tipo;
                    cbTipoOperacion.SelectedIndex = (int)Inmueble.Operacion;

                    dateTimeFecha.Value = Inmueble.Fecha != null ? Inmueble.Fecha.Value : DateTime.Now;

                    eLocalidad localidad = (eLocalidad)Enum.Parse(typeof(eLocalidad), Inmueble.Localidad);
                    cbLocalidad.SelectedIndex = (int)localidad;
                    txLocalidad.Text = Inmueble.Provincia;

                    txAntiguedad.Text = Inmueble.Antiguedad;
                    txComentariosInternos.Text = Inmueble.Comentarios;
                    txCalle.Text = Inmueble.Calle;
                    txNumero.Text = Inmueble.Numero;
                    txPiso.Text = Inmueble.Piso;
                    txDepto.Text = Inmueble.Departamento;
                    txEntreCalles.Text = Inmueble.EntreCalles;
                    numPrecio.Value = Inmueble.Precio != null ? (decimal)Inmueble.Precio : 0;
                    cbMoneda.SelectedIndex = Inmueble.Moneda;
                    txMtsTerreno.Text = Inmueble.Metros2Terreno;
                    txSupCubierta.Text = Inmueble.SupCubierta;
                    txObservaciones.Text = Inmueble.Observaciones;
                    cbCargadoPor.SelectedValue = vendedores.Find(x => x.Id == Inmueble.CargadoPor).Id;
                    txContacto.Text = Inmueble.Contacto;
                    txReferencia.Text = Inmueble.Referencia;
                    checkDisponible.Checked = Inmueble.Disponible;
                    cbAmbientes.SelectedIndex = Inmueble.Ambientes;
                    cbCochera.SelectedIndex = Inmueble.Cochera == false ? 0 : 1;
                    cbUbicacion.SelectedIndex = (int)Enum.Parse(typeof(eUbicacion), Inmueble.Ubicacion);
                    cbEstado.SelectedIndex = Inmueble.Estado;
                    
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw ex;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Inmueble inmueble = new Inmueble();


                if (ServiceHelper.ws.EliminarInmueble(Inmueble))
                {

                    MessageBox.Show("El Inmueble se elimino Correctamente", "Inmueble");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Inmueble NO se elimino", "Inmueble", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                EmailHelper.EnviarNotificacion(ex);
                throw ex;
            }
        }

        private void btGuardarFotos_Click(object sender, EventArgs e)
        {
            List<Foto> fotos = new List<Foto>();
            string archivosSinGuardar = string.Empty;

            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Multiselect = true;
                opf.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";

                opf.Title = "Seleccione las Imagenes por favor";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in opf.FileNames)
                    {
                        try
                        {
                            Foto f = new Foto();

                            //Image img = ResizeImage(file, 488, 414, true);

                            Image img = GetImageLowQuality(file);

                            ImageConverter converter = new ImageConverter();

                            f.Imagen = (byte[])converter.ConvertTo(img, typeof(byte[]));
                            f.InmuebleId = Inmueble.Id;

                            fotos.Add(f);
                            try
                            {
                                ServiceHelper.ws.GuardarFoto(f);
                            }
                            catch (Exception)
                            {
                                if (archivosSinGuardar == string.Empty)
                                    archivosSinGuardar = "No se pudieron guardar los siguientes archivos: " + Environment.NewLine;

                                archivosSinGuardar += " - " + file + Environment.NewLine;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    if (archivosSinGuardar != string.Empty)
                    {
                        MessageBox.Show(archivosSinGuardar, "Error");
                    }
                    else
                    {
                        MessageBox.Show("Imagen/es Guardada Correctamente!");
                        this.Close();
                    }
                }
            }
        }

        #region Imagenes

        private Image GetImageLowQuality(string file)
        {
            try
            {
                // Get a bitmap.
                //Bitmap bmp1 = new Bitmap(file);
                Bitmap bmp1 = new Bitmap(ResizeImage(file, 800, 600, false));
                ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);

                // Create an Encoder object based on the GUID 
                // for the Quality parameter category.
                System.Drawing.Imaging.Encoder myEncoder =
                    System.Drawing.Imaging.Encoder.Quality;

                string tempFile = string.Empty;
                // Create an EncoderParameters object. 
                // An EncoderParameters object has an array of EncoderParameter 
                // objects. In this case, there is only one 
                // EncoderParameter object in the array.
                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 60L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                tempFile = Path.GetTempFileName();
                bmp1.Save(tempFile, jgpEncoder, myEncoderParameters);

                Image imagenTuneada = System.Drawing.Image.FromFile(tempFile);
                //System.IO.File.Delete(tempFile);

                return imagenTuneada;
                //myEncoderParameter = new EncoderParameter(myEncoder, 70L);
                //myEncoderParameters.Param[0] = myEncoderParameter;
                //tempFile = Path.GetTempFileName();
                //bmp1.Save(tempFile, jgpEncoder, myEncoderParameters);

                //// Save the bitmap as a JPG file with zero quality level compression.
                //myEncoderParameter = new EncoderParameter(myEncoder, 0L);
                //myEncoderParameters.Param[0] = myEncoderParameter;
                //tempFile = Path.GetTempFileName();
                //bmp1.Save(tempFile, jgpEncoder, myEncoderParameters);
            }
            catch (Exception)
            {

                throw;
            }

        }

        internal static Image ResizeImage(string OriginalFile, int NewWidth, int MaxHeight, bool OnlyResizeIfWider)
        {
            System.Drawing.Image FullsizeImage = System.Drawing.Image.FromFile(OriginalFile);

            // Prevent using images internal thumbnail
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            FullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            if (OnlyResizeIfWider)
            {
                if (FullsizeImage.Width <= NewWidth)
                {
                    NewWidth = FullsizeImage.Width;
                }
            }

            int NewHeight = FullsizeImage.Height * NewWidth / FullsizeImage.Width;
            if (NewHeight > MaxHeight)
            {
                // Resize with height instead
                NewWidth = FullsizeImage.Width * MaxHeight / FullsizeImage.Height;
                NewHeight = MaxHeight;
            }

            System.Drawing.Image NewImage = FullsizeImage.GetThumbnailImage(NewWidth, NewHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            FullsizeImage.Dispose();

            return NewImage;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        #endregion

        private void btVerFotos_Click(object sender, EventArgs e)
        {
            frmFotos frmFotos = new frmFotos();
            frmFotos.Inmueble = Inmueble;

            frmFotos.MdiParent = (Form)this.Parent.Parent;
            Panel p = (Panel)this.Parent.Parent.Controls.Find("pnlMdi", true).First();
            p.Controls.Add(frmFotos);

            frmFotos.BringToFront();
            frmFotos.StartPosition = FormStartPosition.Manual;

            //int width = this.Controls.Find("netBarControl1", true)[0].Width;
            frmFotos.Location = new Point(120, 0);
            //this.Close();
            frmFotos.Show();
        }


        private void btPublicarWeb_Click(object sender, EventArgs e)
        {
            List<Foto> fotos = ServiceHelper.ws.GetFotosDelInmueble(Inmueble.Id).ToList();
            if (fotos.Count == 0)
            {
                MessageBox.Show("Debe Guardar Fotos antes de publicar el Inmueble en la Web");
            }
            else
            {

                if (Inmueble.WebId != null && Inmueble.WebId != 0)
                {
                    MessageBox.Show("Este Inmueble ya esta en la Web");

                }
                else
                {
                    ServiceHelper.ws.SubirInmuebleWeb(Inmueble.Id);
                    MessageBox.Show("El inmueble fue Publicado Correctamente en la Web");
                }

            }
        }
    }
}
