using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.Runtime.InteropServices;

namespace CapaUsuario.Reportes
{
    public partial class fControlGestantesEntreFechas : Form
    {
        string folderPath = "C:\\PDFs\\";
        PdfPCell cell;

        const int ERROR_SHARING_VIOLATION = 32;
        const int ERROR_LOCK_VIOLATION = 33;

        DateTime fecha_inicio;
        DateTime fecha_fin;

        public string Idtobstetra { get; set; }

        public string IdtHistoriaClinica { get; set; }

        public fControlGestantesEntreFechas()
        {
            InitializeComponent();
        }

        protected virtual bool IsFileinUse(FileInfo file, string path)
        {
            FileStream stream = null;

            if (!File.Exists(path))
            {
                return false;
            }
            else
            {
                try
                {
                    stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);

                }
                catch (IOException)
                {
                    //the file is unavailable because it is:
                    //still being written to
                    //or being processed by another thread
                    //or does not exist (has already been processed)
                    return true;

                }
                finally
                {
                    if (stream != null)
                        stream.Close();
                }
                return false;
            }
        }

        private void fControlGestantesEntreFechas_Load(object sender, EventArgs e)
        {
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.cOdontologia oOdontologia = new CapaDeNegocios.cOdontologia();
            CapaDeNegocios.cEcografia oEcografia = new CapaDeNegocios.cEcografia();
            CapaDeNegocios.cGestanteMorbilidad oGestanteMorbilidad = new CapaDeNegocios.cGestanteMorbilidad();
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            CapaDeNegocios.cBateria oBateria = new CapaDeNegocios.cBateria();
            CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante oVisitaDomiciliariaGestante = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante();
            CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN oVisitaDomiciliariaPuerpera = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN();
            CapaDeNegocios.TerminoGestacion.cTerminoGestacion oTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
            CapaDeNegocios.ControlPeuperio.cControlPeuperio oControlPuerperio = new CapaDeNegocios.ControlPeuperio.cControlPeuperio();
            CapaDeNegocios.RecienNacido.cRecienNacido oRecienNacido = new CapaDeNegocios.RecienNacido.cRecienNacido();
            CapaUsuario.frmHistoriaClinica oHC = new CapaUsuario.frmHistoriaClinica("","");
        }

        private void buImprimir_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"C:\PDFs\ControGestantesEntreFechas.pdf");
            bool estaAbierto = false;
            estaAbierto = IsFileinUse(file, @"C:\PDFs\ControGestantesEntreFechas.pdf");

 
            if (!estaAbierto)
            {
                exportar_a_pdf();
            }
            else
            {
                MessageBox.Show("Por favor cerrar ControGestantesEntreFechas.pdf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
 
        }

        public void exportar_a_pdf()
        {
            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            DataTable odtHC = new DataTable();

            Paragraph paragraph = new Paragraph();
            Paragraph paragraph2 = new Paragraph();
            Paragraph paragraph3 = new Paragraph();

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            //using (FileStream stream = new FileStream(folderPath + "Graphics.pdf", FileMode.Create))
            //{


            // Add a new page to the pdf file
            //pdfDoc.NewPage();
            Document pdfDoc = new Document(PageSize.A4, 9, 9, 10, 10);
            
            //pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());

            pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4);

            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 10 );
            paragraph.Add(" REPORTE DE CONTROL DE GESTANTES ENTRE "+ fecha_inicio.Date + " Y " + fecha_fin.Date  +  "\n\n");

 
 
            /*              Llenar datagrids            */

            fecha_fin = dtpFechaFin.Value;
            fecha_inicio = dtpFechaInicio.Value;

            oHistoriaClinica.Idtobstetra = Idtobstetra;
            oHistoriaClinica.fecha_inicio = fecha_inicio;
            oHistoriaClinica.fecha_fin = fecha_fin;

            odtHC = oHistoriaClinica.ReporteHistoriaClinicaXObstetraXFechas();



            if (odtHC.Rows.Count > 0)
            {

                FileStream fs = new FileStream(folderPath + "ControGestantesEntreFechas.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, fs);
                CreateHeaderFooter(ref pdfDoc);
                //Abrir pagina
                pdfDoc.Open();

                for (int jjj = 0; jjj < odtHC.Rows.Count; jjj++)
                {
                    //recorrer trabajadores de una planilla
                    IdtHistoriaClinica = odtHC.Rows[jjj][0].ToString();

                    //obtener datagridview de trabajador
                    datagridviews_control_gestantes();
 
                    //Total de filas en dgvBoletaPago_A, si es mayor a 0 procede a reporte
                    //instanciando pdfTable A , B , C , D , E
                    PdfPTable pdfTable_HC_1 = new PdfPTable(dgvHCParte1.ColumnCount);
                    PdfPTable pdfTable_HC_2 = new PdfPTable(dgvHCParte2.ColumnCount);
                    PdfPTable pdfTable_HC_3 = new PdfPTable(dgvHCParte3.ColumnCount);

                    PdfPTable pdfTable_EC= new PdfPTable(dgvEcografico.ColumnCount);
                    PdfPTable pdfTable_OD = new PdfPTable(dgvOdontologico.ColumnCount);
                    PdfPTable pdfTable_MO = new PdfPTable(dgvMorbilidad.ColumnCount);
                    PdfPTable pdfTable_PN = new PdfPTable(dgvAtencionPreNatal.ColumnCount);
                    PdfPTable pdfTable_RB = new PdfPTable(dgvRegBateria.ColumnCount);
                    PdfPTable pdfTable_VG = new PdfPTable(dgvVisitasG.ColumnCount);
                    PdfPTable pdfTable_VP = new PdfPTable(dgvVisitasPuerpera.ColumnCount);
                    PdfPTable pdfTable_TG = new PdfPTable(dgvTerminoGestacion.ColumnCount);
                    PdfPTable pdfTable_CP = new PdfPTable(dgvControlPuerperio.ColumnCount);
                    PdfPTable pdfTable_RN = new PdfPTable(dgvRecienNacido.ColumnCount);

                    //Nueva pagina
                    pdfDoc.NewPage();

                    //obtener pdfTableA,B,C,D,E 
                    pdfTable_HC_1 = pdf_hc_1(0, 100);
                    pdfTable_HC_2 = pdf_hc_2(0, 100);
                    pdfTable_HC_3 = pdf_hc_3(0, 100);

                    pdfTable_EC = pdf_eco(0, 100);
                    pdfTable_OD = pdf_odo(0, 100);
                    pdfTable_MO = pdf_mor(0, 100);
                    pdfTable_PN = pdf_pn(0, 100);
                    pdfTable_RB = pdf_reg_bat(0, 100);
                    pdfTable_VG = pdf_vis_ges(0, 100);
                    pdfTable_VP = pdf_vis_pue(0, 100);
                    pdfTable_TG = pdf_ter_ges(0, 100);
                    pdfTable_CP = pdf_con_pue(0, 100);
                    pdfTable_RN = pdf_rec_nac(0, 100);

                    //Columnas 
                    MultiColumnText columns = new MultiColumnText();
                    columns.AddRegularColumns(36f, pdfDoc.PageSize.Width - 36f, 24f, 1);

                    //Imagen
                    string ruta = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
 
                    //C:\\Users\\ADVANCE\\Source\\Repos\\slnRecursosHumanos\\slnRecursosHumanos\\CapaUsuario\\bin\\Debug
                    //C:\\Users\\ADVANCE\\Source\\Repos\\slnRecursosHumanos\\slnRecursosHumanos\\CapaUsuario

                    string ruta_imagen = ruta + "\\logo.jpg";

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(ruta_imagen);
                    logo.ScalePercent(64f);
                    logo.SetAbsolutePosition(12f, pdfDoc.PageSize.Height - 36f - 100f);

                    //tabla que ecografia y odontologia
                    PdfPTable tabla_cabecera = new PdfPTable(3);
                    tabla_cabecera.DefaultCell.BorderWidth = 0;

                    //tabla que ecografia y odontologia
                    PdfPTable tabla_eco_odo = new PdfPTable(3);
                    tabla_eco_odo.DefaultCell.BorderWidth = 0;

                    //Agrupando tabla titular
                    tabla_eco_odo.AddCell(pdfTable_EC);
                    tabla_eco_odo.AddCell(pdfTable_OD);
                    tabla_eco_odo.AddCell(pdfTable_MO);

                    //Agrupando tabla cabecera
                    //tabla_eco_odo.AddCell();
                    tabla_eco_odo.AddCell(paragraph);

                    //Agregando pdfTable A, B, C, D, E a pdfDoc
                    columns.AddElement(paragraph);
                    columns.AddElement(pdfTable_HC_1);
                    columns.AddElement(pdfTable_HC_2);
                    columns.AddElement(pdfTable_HC_3);
                    columns.AddElement(tabla_eco_odo);
                    
                    columns.AddElement(pdfTable_PN);
                    columns.AddElement(pdfTable_RB);
                    columns.AddElement(pdfTable_VG);
                    columns.AddElement(pdfTable_VP);
                    columns.AddElement(pdfTable_TG);
                    columns.AddElement(pdfTable_CP);
                    columns.AddElement(pdfTable_RN);

                    pdfDoc.Add(columns);

                }

                
                    //int numero_pagina = writer.PageNumber;
                    //pdfDoc.Open();
                    pdfDoc.Close();
                    //stream.Close();
                    writer.Close();
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = "C:\\PDFs\\ControGestantesEntreFechas.pdf";
                    proc.Start();
                

            }
            else
            {
                MessageBox.Show("Control Gestante vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public float[] GetTamañoColumnas1(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        public float[] GetTamañoColumnasMorbilidad(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount-1; i++)
            {
                
                    values[i] = (float)dg.Columns[i].Width;
                
            }
            return values;
        }

        public float[] GetTamañoColumnas3(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*if (i == 2) values[i] = 10;*/
            }
            return values;
        }

        public float[] GetTamañoColumnas4(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*if (i == 3) values[i] = 17;*/
            }
            return values;
        }

        public float[] GetTamañoColumnas5(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*if (i == 4) values[i] = 22;*/
            }
            return values;
        }

        public float[] GetTamañoColumnas7(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*if (i == 8) values[i] = 45;
                 */
            }
            return values;
        }

        public float[] GetTamañoColumnas8(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*
                if (i == 4) values[i] = 22;
                if (i == 0) values[i] = 180;
                if (i == 5) values[i] = 180;
                */
            }
            return values;
        }

        public float[] GetTamañoColumnas9(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*
                if (i == 4) values[i] = 22;
                if (i == 0) values[i] = 180;
                if (i == 5) values[i] = 180;
                */
            }
            return values;
        }


        public float[] GetTamañoColumnas10(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*
                if (i == 4) values[i] = 22;
                if (i == 0) values[i] = 180;
                if (i == 5) values[i] = 180;
                */
            }
            return values;
        }

        public float[] GetTamañoColumnas11(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
                /*
                if (i == 4) values[i] = 22;
                if (i == 0) values[i] = 180;
                if (i == 5) values[i] = 180;
                */
            }
            return values;
        }

        public void CreateHeaderFooter(ref Document _document)
        {
            var headerfooter = FontFactory.GetFont("Arial", 8);
            HeaderFooter header = (new HeaderFooter(new Phrase("Control de gestantes entre " + fecha_inicio.Date + " y " + fecha_fin.Date , headerfooter), false));
            header.BorderColorTop = new iTextSharp.text.Color(System.Drawing.Color.Red);
            header.BorderWidthTop = 0f;
            _document.Header = header;
            HeaderFooter Footer = new HeaderFooter(new Phrase(" ", headerfooter), true);
            //Footer.BorderWidthBottom = 0f;
            Footer.BorderWidthBottom = 0f;
            Footer.BorderWidthTop = 0f;
            Footer.BorderWidthLeft = 0f;
            Footer.BorderWidthRight = 0f;
            _document.Footer = Footer;
        }


        private void datagridviews_control_gestantes()
        {
            //bool dgv_boleta_pago = true;

            DataTable odtHC1 = new DataTable();
            DataTable odtHC2 = new DataTable();
            DataTable odtHC3 = new DataTable();
            DataTable odtEC = new DataTable();
            DataTable odtOD = new DataTable();
            DataTable odtMO = new DataTable();
            DataTable odtPN = new DataTable();
            DataTable odtRB = new DataTable();
            DataTable odtVG = new DataTable();
            DataTable odtVP = new DataTable();
            DataTable odtTG = new DataTable();
            DataTable odtCP = new DataTable();
            DataTable odtRN = new DataTable();


            DataRow drFilaHC1 = odtHC1.NewRow();
            DataRow drFilaHC2 = odtHC2.NewRow();
            DataRow drFilaHC3 = odtHC3.NewRow();
            DataRow drFilaEC = odtEC.NewRow();
            DataRow drFilaOD = odtOD.NewRow();
            DataRow drFilaMO = odtMO.NewRow();
            DataRow drFilaPN = odtPN.NewRow();
            DataRow drFilaRB = odtRB.NewRow();
            DataRow drFilaVG = odtVG.NewRow();
            DataRow drFilaVP = odtVP.NewRow();
            DataRow drFilaTG = odtTG.NewRow();
            DataRow drFilaCP = odtCP.NewRow();
            DataRow drFilaRN = odtRN.NewRow();

            CapaDeNegocios.cHistoriaClinica oHistoriaClinica = new CapaDeNegocios.cHistoriaClinica();
            CapaDeNegocios.cOdontologia oOdontologia = new CapaDeNegocios.cOdontologia();
            CapaDeNegocios.cEcografia oEcografia = new CapaDeNegocios.cEcografia();
            CapaDeNegocios.cGestanteMorbilidad oGestanteMorbilidad = new CapaDeNegocios.cGestanteMorbilidad();
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            CapaDeNegocios.cBateria oBateria = new CapaDeNegocios.cBateria();
            CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante oVisitaDomiciliariaGestante = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaGestante();
            CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN oVisitaDomiciliariaPuerpera = new CapaDeNegocios.VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN();
            CapaDeNegocios.TerminoGestacion.cTerminoGestacion oTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();
            CapaDeNegocios.ControlPeuperio.cControlPeuperio oControlPuerperio = new CapaDeNegocios.ControlPeuperio.cControlPeuperio();
            CapaDeNegocios.RecienNacido.cRecienNacido oRecienNacido = new CapaDeNegocios.RecienNacido.cRecienNacido();
            CapaUsuario.frmHistoriaClinica oHC = new CapaUsuario.frmHistoriaClinica("", "");

            int dias_laborados = 0;
            int mes_dias = 0;


            oHistoriaClinica.Idthistoriaclinica = this.IdtHistoriaClinica;

            dgvHCParte1.DataSource = oHistoriaClinica.ReporteHistoriaClinicaParte1();
            dgvHCParte1.Columns[0].Visible = false;
            dgvHCParte2.DataSource = oHistoriaClinica.ReporteHistoriaClinicaParte2();
            dgvHCParte3.DataSource = oHistoriaClinica.ReporteHistoriaClinicaParte3();

            oEcografia.Idthistoriaclinica = this.IdtHistoriaClinica;
            dgvEcografico.DataSource = oEcografia.ListarEcografiaXIdHC();

            oOdontologia.Idthistoriaclinica = this.IdtHistoriaClinica;
            dgvOdontologico.DataSource = oOdontologia.ListarOdontologiaXIdHC();

            oGestanteMorbilidad.idthistoriaclinica = IdtHistoriaClinica;

            odtMO = oHC.enumerar_datatable(oGestanteMorbilidad.ListarGestanteMorbilidad(), 0);
            odtMO.Columns.RemoveAt(1);
                
            dgvMorbilidad.DataSource = odtMO;
            

            odtPN = oHC.enumerar_datatable(oCitaPrenatal.ListaCitasPreNatal(), 0);
            odtPN.Columns.RemoveAt(1);
            odtPN.Columns.RemoveAt(1);
            odtPN.Columns.RemoveAt(5);
            odtPN.Columns.RemoveAt(5);
            dgvAtencionPreNatal.DataSource = odtPN;
            

            odtRB = oHC.enumerar_datatable(oBateria.ListarBateria(IdtHistoriaClinica), 0);
            odtRB.Columns.RemoveAt(1);
            odtRB.Columns.RemoveAt(1);
            dgvRegBateria.DataSource = odtRB;
            

            odtVG = oHC.enumerar_datatable(oVisitaDomiciliariaGestante.ListarVisitaDomiciliariaGestante(IdtHistoriaClinica), 0);
            odtVG.Columns.RemoveAt(1);
            odtVG.Columns.RemoveAt(5);
            dgvVisitasG.DataSource = odtVG;
            

            odtVP = oHC.enumerar_datatable(oVisitaDomiciliariaPuerpera.ListarVisitaDomiciliariaPuerperaRN(IdtHistoriaClinica), 0);
            odtVP.Columns.RemoveAt(1);
            odtVP.Columns.RemoveAt(8);
            dgvVisitasPuerpera.DataSource = odtVP;
            

            odtTG = oHC.enumerar_datatable(oTerminoGestacion.ListarTerminoGestacion(IdtHistoriaClinica), 0);
            odtTG.Columns.RemoveAt(1);
            odtTG.Columns.RemoveAt(11);
            dgvTerminoGestacion.DataSource = odtTG;
            

            odtCP = oHC.enumerar_datatable(oControlPuerperio.ListarControlPeuperio(IdtHistoriaClinica), 0);
            dgvControlPuerperio.DataSource = odtCP;
            odtCP.Columns.RemoveAt(1);
            odtCP.Columns.RemoveAt(8);
            

            odtRN = oHC.enumerar_datatable(oRecienNacido.ListarRecienNacido(IdtHistoriaClinica), 0);
            odtRN.Columns.RemoveAt(1);
            odtRN.Columns.RemoveAt(1);
            dgvRecienNacido.DataSource = odtRN ;
            


        }

        private PdfPTable pdf_hc_1(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvHCParte1.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvHCParte1.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvHCParte1);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;
                foreach (DataGridViewColumn column in dgvHCParte1.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    /*
                    if (k == 4)
                    {
                        cell.BorderColorLeft = CMYKColor.BLACK;
                        cell.BorderColorRight = CMYKColor.BLACK;
                        cell.BorderColorTop = CMYKColor.WHITE;
                        cell.BorderColorBottom = CMYKColor.WHITE;
                        cell.BorderWidthLeft = 1f;
                        cell.BorderWidthRight = 1f;
                        cell.BorderWidthTop = 0f;
                        cell.BorderWidthBottom = 0f;
                        cell.BackgroundColor = CMYKColor.WHITE;
                    }*/
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvHCParte1.RowCount; i++)
                {
                    for (int j = 0; j < dgvHCParte1.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvHCParte1[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));

                      

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_hc_2(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvHCParte2.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvHCParte2.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvHCParte2);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;
                foreach (DataGridViewColumn column in dgvHCParte2.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    /*
                    if (k == 4)
                    {
                        cell.BorderColorLeft = CMYKColor.BLACK;
                        cell.BorderColorRight = CMYKColor.BLACK;
                        cell.BorderColorTop = CMYKColor.WHITE;
                        cell.BorderColorBottom = CMYKColor.WHITE;
                        cell.BorderWidthLeft = 1f;
                        cell.BorderWidthRight = 1f;
                        cell.BorderWidthTop = 0f;
                        cell.BorderWidthBottom = 0f;
                        cell.BackgroundColor = CMYKColor.WHITE;
                    }*/
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvHCParte2.RowCount ; i++)
                {
                    for (int j = 0; j < dgvHCParte2.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvHCParte2[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }


        private PdfPTable pdf_hc_3(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvHCParte3.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvHCParte3.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvHCParte3);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;
                foreach (DataGridViewColumn column in dgvHCParte3.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    /*
                    if (k == 4)
                    {
                        cell.BorderColorLeft = CMYKColor.BLACK;
                        cell.BorderColorRight = CMYKColor.BLACK;
                        cell.BorderColorTop = CMYKColor.WHITE;
                        cell.BorderColorBottom = CMYKColor.WHITE;
                        cell.BorderWidthLeft = 1f;
                        cell.BorderWidthRight = 1f;
                        cell.BorderWidthTop = 0f;
                        cell.BorderWidthBottom = 0f;
                        cell.BackgroundColor = CMYKColor.WHITE;
                    }*/
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvHCParte3.RowCount; i++)
                {
                    for (int j = 0; j < dgvHCParte3.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvHCParte3[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));

 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_eco(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvEcografico.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvEcografico.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvEcografico);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("ECOGRAFIA", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 4;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvEcografico.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);

                     

                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                

                for (int i = 0; i < dgvEcografico.RowCount; i++)
                {
                    for (int j = 0; j < dgvEcografico.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvEcografico[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));


 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_odo(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvOdontologico.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvOdontologico.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvOdontologico);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("ODONTOLOGIA", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 2;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvOdontologico.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
 
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvOdontologico.RowCount ; i++)
                {
                    for (int j = 0; j < dgvOdontologico.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvOdontologico[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));

                       

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_mor(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvMorbilidad.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvMorbilidad.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvMorbilidad);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
 
                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("MORBILIDAD", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 3;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvMorbilidad.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    //if (k != 1)
                        pdfTableE.AddCell(cell);

                    k++;
                }

                for (int i = 0; i < dgvMorbilidad.RowCount ; i++)
                {
                    for (int j = 0; j < dgvMorbilidad.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvMorbilidad[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));

                        //if (j != 1) 
                            pdfTableE.AddCell(cell);
                        

                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_pn(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvAtencionPreNatal.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvAtencionPreNatal.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvAtencionPreNatal);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("ATENCION PRE NATAL", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 9;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvAtencionPreNatal.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                     
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;

                    //if (k!=1 && k!=2)
                        pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvAtencionPreNatal.RowCount ; i++)
                {
                    for (int j = 0; j < dgvAtencionPreNatal.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvAtencionPreNatal[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));


                        //cell.FixedHeight = 25f;
                        //if (j != 1 && j != 2)
                            pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_reg_bat(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvRegBateria.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvRegBateria.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvRegBateria);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("REGISTRO DE EXAMENES DE BATERIA", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 9;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvRegBateria.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvRegBateria.RowCount ; i++)
                {
                    for (int j = 0; j < dgvRegBateria.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvRegBateria[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_vis_ges(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvVisitasG.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvVisitasG.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvVisitasG);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
 


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("VISITA DOMICILIARIA GESTANTE", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 5;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvVisitasG.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
 
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvVisitasG.RowCount ; i++)
                {
                    for (int j = 0; j < dgvVisitasG.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvVisitasG[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));

 
 
                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }


        private PdfPTable pdf_vis_pue(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvVisitasPuerpera.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvVisitasPuerpera.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvVisitasPuerpera);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
 

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("VISITA PUERPERA", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 8;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvVisitasPuerpera.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
 
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvVisitasPuerpera.RowCount; i++)
                {
                    for (int j = 0; j < dgvVisitasPuerpera.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvVisitasPuerpera[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }


        private PdfPTable pdf_ter_ges(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvTerminoGestacion.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvTerminoGestacion.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvTerminoGestacion);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
                int iindice_ingresos = 0;
                int iindice_descuentos = 0;
                int iindice_a_empleador_i = 0;
                int iindice_a_empleador_j = 0;
                int iindice_a_trabajador = 0;

                bool fAportacionesEmpleador = false;


                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("TERMINO GESTACION", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 11;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvTerminoGestacion.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
 
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvTerminoGestacion.RowCount ; i++)
                {
                    for (int j = 0; j < dgvTerminoGestacion.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvTerminoGestacion[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_con_pue(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvControlPuerperio.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvControlPuerperio.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvControlPuerperio);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
 

                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("CONTROL PUERPERIO", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 8;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvControlPuerperio.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
 
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvControlPuerperio.RowCount; i++)
                {
                    for (int j = 0; j < dgvControlPuerperio.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvControlPuerperio[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

        private PdfPTable pdf_rec_nac(int alineacion, int ancho)
        {
            PdfPTable pdfTableE = new PdfPTable(dgvRecienNacido.ColumnCount);
            //Creating iTextSharp Table from the DataTable data
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.TIMES_ROMAN, 7);
            iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 9, 1, iTextSharp.text.Color.BLUE);


            if (dgvRecienNacido.ColumnCount > 0)
            {

                Phrase objH_E = new Phrase("A", fuenteTitulo);
                Phrase objP_E = new Phrase("A", fuente);
                float[] headerwidths_E = GetTamañoColumnas1(dgvRecienNacido);
                pdfTableE.DefaultCell.Padding = 0;
                pdfTableE.HorizontalAlignment = alineacion;
                pdfTableE.DefaultCell.BorderWidth = 1;
                pdfTableE.SetWidths(headerwidths_E);
                pdfTableE.WidthPercentage = ancho;
 

                /* -------------------------------INICIO DGVBOLETA_E */
                int k = 0;

                cell = new PdfPCell((new Phrase("RECIEN NACIDO", new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                cell.Colspan = 6;
                cell.Rowspan = 1;
                cell.HorizontalAlignment = 1;
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTableE.AddCell(cell);

                foreach (DataGridViewColumn column in dgvRecienNacido.Columns)
                {
                    cell = new PdfPCell((new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
 
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    pdfTableE.AddCell(cell);
                    k++;
                }

                for (int i = 0; i < dgvRecienNacido.RowCount ; i++)
                {
                    for (int j = 0; j < dgvRecienNacido.ColumnCount; j++)
                    {
                        cell = new PdfPCell((new Phrase(dgvRecienNacido[j, i].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.BOLD, 7f, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK))));
 

                        //cell.FixedHeight = 25f;
                        pdfTableE.AddCell(cell);


                    }
                    //float total_altura = pdfTableE.CalculateHeights(true);
                    //ftotal_lineas_hoja += cell.GetMaxHeight();
                    //ftotal_lineas_hoja = pdfTableE.TotalHeight;
                    pdfTableE.CompleteRow();
                    //total_lineas_hoja++;
                }
                /* -------------------------------FIN DGVBOLETA_E */



            }

            return pdfTableE;
        }

    }
}
