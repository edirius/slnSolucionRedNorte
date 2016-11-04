using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CapaDeNegocios;
using CapaDeNegocios.Exportacion;
namespace CapaUsuario.Exportacion
{
    public partial class frmExportacion : Form
    {
        public frmExportacion()
        {
            InitializeComponent();
        }

        cExportar oExportar = new cExportar();

        public string NombreObstetra { get; set; }
        public string IdObstetra { get; set; }
        public string NombreEstablecimientoSalud { get; set; }
        public string IdEstablecimientoSalud { get; set; }

        private void frmExportacion_Load(object sender, EventArgs e)
        {
            lblEstablecimiento.Text = NombreEstablecimientoSalud;
            lblObstetra.Text = NombreObstetra;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.DarkBlue,
                                                                       Color.Aquamarine,
                                                                       45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //dlgGuardar.Filter = "Archivos de Exportacion de GESSYS (*.gsys)|*.gsys";
            //dlgGuardar.DefaultExt = ".gsys";
            //dlgGuardar.ShowDialog();
            //MessageBox.Show(dlgGuardar.FileName);

            List<string> Caracteres = new List<string>();
            Caracteres = oExportar.TraerDatosTabla("tobstetra");
            for (int i = 0; i < Caracteres.Count; i++)
            {
                textBox1.Text = textBox1.Text + Caracteres[i] + System.Environment.NewLine;
            }
            
        }
    }
}
