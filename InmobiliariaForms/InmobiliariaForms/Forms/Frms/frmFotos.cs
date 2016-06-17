using InmobiliariaForms.InmobiliariaService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    public partial class frmFotos : Form
    {
        public Inmueble Inmueble { get; set; }
        List<Foto> FotosDelInmueble = new List<Foto>();

        int locX = 20;
        int locY = 10;
        int sizeWidth = 130;
        int sizeHeight = 130;

        public frmFotos()
        {
            InitializeComponent();
        }

        private void frmFotos_Load(object sender, EventArgs e)
        {
            pnlImagenes.Controls.Clear();
            int locnewX = locX;
            int locnewY = locY;

            FotosDelInmueble = ServiceHelper.ws.GetFotosDelInmueble(Inmueble.Id).ToList();

            foreach (Foto fotoDelInmueble in FotosDelInmueble)
            {
                LoadImagestoPanel(fotoDelInmueble, locnewX, locnewY);
                locnewX = locnewX + sizeWidth + 10;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadImagestoPanel(Foto foto, int newLocX, int newLocY)
        {
            PictureBox ctrl = new PictureBox();
            ctrl.Image = ScaleImage(Image.FromStream(new MemoryStream(foto.Imagen)), sizeWidth, sizeHeight);
            //ctrl.BackColor = Color.Black;
            ctrl.BorderStyle = BorderStyle.FixedSingle;
            ctrl.Location = new Point(newLocX, newLocY);
            ctrl.Size = new System.Drawing.Size(sizeWidth, sizeHeight);
            ctrl.SizeMode = PictureBoxSizeMode.StretchImage;
            ctrl.MouseMove += new MouseEventHandler(control_MouseMove);
            ctrl.Tag = foto.Id;
            pnlImagenes.Controls.Add(ctrl);
        }

        private void control_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            PictureBox pic = (PictureBox)control;
            Foto fotoElegida = FotosDelInmueble.Find(x => x.Id == (int)pic.Tag);
            picBox.Image = ScaleImage(Image.FromStream(new MemoryStream(fotoElegida.Imagen)), picBox.Width, picBox.Height);
        }

        private void LoadControls()
        {
            int locnewX = locX;
            int locnewY = locY;

            foreach (Control p in pnlImagenes.Controls)
            {
                locnewX = locX;

                //if (locnewX >= pnlImagenes.Width - sizeWidth - 10)
                //{
                    
                //    //locY = locY + sizeHeight + 30;
                //    //locnewY = locY;
                //}
                //else
                //{

                //    locnewY = locY;
                //}

                p.Location = new Point(locnewX, locnewY);
                p.Size = new Size(sizeWidth, sizeHeight);

                //locnewY = locY; //+ sizeHeight + 10;
                locnewX = locnewX + sizeWidth + 10;
            }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }
    }
}
