using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios.Cronograma;

namespace CapaUsuario.ControlGestante
{
    public partial class frmCronograma : Form
    {
        public frmCronograma()
        {
            InitializeComponent();
        }
        public CapaDeNegocios.cHistoriaClinica miCicloGestante = new CapaDeNegocios.cHistoriaClinica();
        cCronograma miCronograma; 

        private void button1_Click(object sender, EventArgs e)
        {
            miCronograma = new cCronograma(miCicloGestante);
            dtgCronograma.Columns.Add("FUR", "FUR");
            dtgCronograma.Rows[0].Cells["FUR"].Value = miCronograma.FechaFur;

            for (int i = 0; i < miCronograma.misFechasPrenatales.Count  ; i++)
            {
                dtgCronograma.Columns.Add(miCronograma.misFechasPrenatales[i].nombre , miCronograma.misFechasPrenatales[i].nombre);
                dtgCronograma.Rows[0].Cells[miCronograma.misFechasPrenatales[i].nombre].Value = miCronograma.misFechasPrenatales[i].fechaCita;
                dtgCronograma.Columns[i+ 1].DefaultCellStyle.BackColor = Color.LawnGreen;
            }

            for (int i = 0; i < miCronograma.misFechasProbalesOdontologias.Count  ; i++)
            {
                dtgCronograma.Columns.Add(miCronograma.misFechasProbalesOdontologias[i].Nombre, miCronograma.misFechasProbalesOdontologias[i].Nombre);
                dtgCronograma.Rows[0].Cells[miCronograma.misFechasProbalesOdontologias[i].Nombre].Value = miCronograma.misFechasProbalesOdontologias[i].FechaAtencionProbable;
                dtgCronograma.Columns[miCronograma.misFechasPrenatales.Count + i + 1].DefaultCellStyle.BackColor = Color.Aqua;   
            }

            for (int i = 0; i < miCronograma.misFechasProbablesEcogafrias.Count ; i++)
            {
                dtgCronograma.Columns.Add(miCronograma.misFechasProbablesEcogafrias[i].Nombre, miCronograma.misFechasProbablesEcogafrias[i].Nombre);
                dtgCronograma.Rows[0].Cells[miCronograma.misFechasProbablesEcogafrias[i].Nombre].Value = miCronograma.misFechasProbablesEcogafrias[i].FechaProbableAtencion;
                dtgCronograma.Columns[miCronograma.misFechasProbablesEcogafrias[i].Nombre].DefaultCellStyle.BackColor = Color.Azure;    
            }

            for (int i = 0; i < miCronograma.misFechasProbablesBateria.Count ; i++)
            {
                dtgCronograma.Columns.Add(miCronograma.misFechasProbablesBateria[i].Nombre, miCronograma.misFechasProbablesBateria[i].Nombre);
                dtgCronograma.Rows[0].Cells[miCronograma.misFechasProbablesBateria[i].Nombre].Value = miCronograma.misFechasProbablesBateria[i].FechaMaxima;
                dtgCronograma.Columns[miCronograma.misFechasProbablesBateria[i].Nombre].DefaultCellStyle.BackColor = Color.Cyan;
                   
            }

            for (int i = 0; i < miCronograma.misFechasProbablesControlPuerperio.Count ; i++)
            {
                dtgCronograma.Columns.Add(miCronograma.misFechasProbablesControlPuerperio[i].Nombre, miCronograma.misFechasProbablesControlPuerperio[i].Nombre);
                dtgCronograma.Rows[0].Cells[miCronograma.misFechasProbablesControlPuerperio[i].Nombre].Value = miCronograma.misFechasProbablesControlPuerperio[i].FechaControlPuerperio;
                dtgCronograma.Columns[miCronograma.misFechasProbablesControlPuerperio[i].Nombre].DefaultCellStyle.BackColor  = Color.LightYellow;   
            }
        }


    }
}
