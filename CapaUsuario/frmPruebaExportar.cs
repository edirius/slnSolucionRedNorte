using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
namespace CapaUsuario
{
    public partial class frmPruebaExportar : Form
    {
        cPruebaExportar miPrueba = new cPruebaExportar();
        public string NombreArchivoExcel;
        public frmPruebaExportar()
        {
            InitializeComponent();
        }
        private void CargarListas()
        {
            dgvListarMicrored.DataSource = miPrueba.ListarMicroRed();
            dgvListarEstablecimientos.DataSource = miPrueba.ListarEstablecimientoSalud();
        }

        private void frmPruebaExportar_Load(object sender, EventArgs e)
        {
            CargarListas();
        }
        private void JuntarTablas()
        {
            for (int i = 0; i < dgvListarMicrored.Rows.Count; i++)
            {
                dgvListarTodo.Rows.Add(new string[]
                {  Convert.ToString(dgvListarMicrored[0, i].Value),
                   Convert.ToString(dgvListarMicrored[1, i].Value),
                   Convert.ToString(dgvListarMicrored[2, i].Value),
                });
            }
            for (int j = 0; j < dgvListarEstablecimientos.Rows.Count; j++)
            {
                dgvListarTodo.Rows.Add(new string[]
                { Convert.ToString(dgvListarEstablecimientos[0, j].Value),
                  Convert.ToString(dgvListarEstablecimientos[1, j].Value),
                  Convert.ToString(dgvListarEstablecimientos[2, j].Value),
                  Convert.ToString(dgvListarEstablecimientos[3, j].Value),
                });
            }
        }
        private void ExportarDataGridViewExcel(DataGridView datagrid)
        {
            //añadir la siguiente referencia al proyecto de tipo COM:
            //Microsoft Excel 12.0 Object Library
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            NombreArchivoExcel = txtCadenaInicial.Text + txtCadenaFinal.Text;
            fichero.FileName = NombreArchivoExcel;
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                int headr = 1;
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dgvListarTodo.Rows.Count; i++)
                {

                    for (int j = 0; j < dgvListarTodo.Columns.Count; j++)
                    {
                        //if (headr <= datagrid.Columns.Count)//añadimos cabecera de excel
                        //{
                        //    string cabesa = datagrid.Columns[j].HeaderCell.Value.ToString();
                        //    hoja_trabajo.Cells[i + 1, j + 1] = datagrid.Columns[j].HeaderCell.Value.ToString();
                        //    headr++;
                        //}
                        //añadimos contenido de excel
                        hoja_trabajo.Cells[i + 1, j + 1] = dgvListarTodo.Rows[i].Cells[j].Value.ToString();
                    }

                }
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                MessageBox.Show("Los datos fueron exportados exitosamente.");
                aplicacion.Quit();
            }
        }
        private void ExportarExcel()
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;
            //Para poner Título en la cabecera de las Columnas del Excel
            ws.Cells[1, 1] = "1";
            ws.Cells[1, 2] = "2";
            for (int j = 2; j <= dgvListarTodo.Rows.Count; j++)//J debe ser igual a 2 en caso de que tenga titulo en las columnas
            {
                for (int i = 1; i <= dgvListarTodo.Columns.Count; i++)
                {
                    ws.Cells[j, i] = cSeguridad.Encriptar(Convert.ToString(dgvListarTodo.Rows[j - 1].Cells[i - 1].Value));
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            JuntarTablas();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //ExportarDataGridViewExcel(dgvListarTodo);
            ExportarExcel();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Como usar la clase anterior
            //encriptamos la cadena inicial       
            txtCadenaEncriptada.Text = cSeguridad.Encriptar(txtCadenaInicial.Text);
            //Vereis que despues de estas instrucciones txtcadenainial y txtcadenafinal contienen lo mismo.
            txtCadenaFinal.Text = txtCadenaEncriptada.Text;
        }
        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            txtCadenaDesencriptada.Text = cSeguridad.DesEncriptar(txtCadenaFinal.Text);
            for (int j = 0; j < dgvListarEstablecimientos.Rows.Count; j++)
            {
                dgvDesencriptado.Rows.Add(new string[]
                { cSeguridad.DesEncriptar(Convert.ToString(dgvListaImportada[0, j].Value)),
                  cSeguridad.DesEncriptar(Convert.ToString(dgvListaImportada[1, j].Value)),
                  cSeguridad.DesEncriptar(Convert.ToString(dgvListaImportada[2, j].Value)),
                  cSeguridad.DesEncriptar(Convert.ToString(dgvListaImportada[3, j].Value)),
                });
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView datagrid = new DataGridView();
            OpenFileDialog fichero = new OpenFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls|Excel (*.xlsx)|*.xlsx";
            NombreArchivoExcel = txtCadenaInicial.Text + txtCadenaFinal.Text;
            fichero.FileName = NombreArchivoExcel;
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                LLenarGrid(fichero.FileName, "Hoja1");
            }
        }
        private void LLenarGrid(string archivo, string hoja)
        {
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer. ¿Esta abriendo el archivo correcto?");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dgvListaImportada.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dgvListaImportada.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                    //DarFormato();
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }
    }
}
