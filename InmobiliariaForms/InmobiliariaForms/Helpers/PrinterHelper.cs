using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InmobiliariaForms
{
    public class PrinterHelper
    {
        public DataGridView gvListado { get; set; }
        PrintDocument printDocument1;

        #region Member Variables
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        int numPage = 1;
        #endregion

        public PrinterHelper()
        {
            
        }

        public void SetValues()
        {
            gvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //gvListado = gvListado.RemoveEmptyColumns();
            printDocument1 = new PrintDocument();
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
        }

        public void Imprimir()
        {
            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Listado de Inmuebles " + DateTime.Now.Date.ToString("dd-MM-yyyy");
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in gvListado.Columns)
                {
                    if (dgvGridCol.Visible)
                    {
                        iTotalWidth += dgvGridCol.Width;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the header title strign
                string title = "Listado de Inmuebles";
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in gvListado.Columns)
                    {

                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                    (double)iTotalWidth * (double)iTotalWidth *
                                    ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;

                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= gvListado.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = gvListado.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //System.Globalization.CultureInfo resourceCulture;
                            //object obj = ResourceManager.GetObject("waiting", resourceCulture);
                            //return ((System.Drawing.Bitmap)(obj));
                            //ResourceManager

                            e.Graphics.DrawImage(InmobiliariaForms.Properties.Resources.MV, new Rectangle(new Point(e.MarginBounds.Left, 15), new Size(55, 50)));
                            //e.Graphics.DrawImage(Image.FromFile("Resources/pmcontexto.png"), new Rectangle(new Point(e.MarginBounds.Left, 15), new Size(55, 50)));
                            //new Point(10, 10));

                            //Draw Header
                            e.Graphics.DrawString(title, new Font(gvListado.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(title, new Font(gvListado.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(gvListado.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(gvListado.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString(title, new Font(new Font(gvListado.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in gvListado.Columns)
                            {

                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);


                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;

                            //Draw Bottom
                            e.Graphics.DrawString("Powered by: SystemAs", new Font(gvListado.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom);
                            //Draw Bottom
                            e.Graphics.DrawString("Página " + (numPage).ToString(), new Font(gvListado.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Right, e.MarginBounds.Bottom);

                            numPage++;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {

                            if (Cel.Value != null)
                            {
                                if (Cel.Value is DateTime)
                                {
                                    e.Graphics.DrawString(DateTime.Parse(Cel.Value.ToString()).ToString("yyyy/MM/dd"), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }
                                else
                                {
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));



                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //public static DataGridView RemoveEmptyColumns(this DataGridView grdView)
        //{
        //    List<string> names = new List<string>();

        //    foreach (DataGridViewColumn clm in grdView.Columns)
        //    {
        //        bool notAvailable = true;

        //        foreach (DataGridViewRow row in grdView.Rows)
        //        {
        //            if (row.Cells[clm.Index].Value != null && !string.IsNullOrEmpty(row.Cells[clm.Index].Value.ToString()))
        //            {
        //                notAvailable = false;
        //                break;
        //            }
        //        }
        //        if (notAvailable)
        //        {
        //            names.Add(clm.Name);
        //            //dgvAux.Columns.RemoveAt(clm.Index);//.Visible = false;
        //            //grdView.Columns.RemoveAt(clm.Index);//.Visible = false;
        //        }
        //    }

        //    foreach (string name in names)
        //    {
        //        grdView.Columns.Remove(name);
        //    }
        //    //grdView.Columns.Remove("Id");

        //    return grdView;
        //}
    }
}
