using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//referencia System.Drawing
using System.Drawing;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using CapaDeDatos;
using System.Data;

namespace CapaDeNegocios
{
    public class cUtilitarios
    {

        public DateTime determinar_1er_control(DataTable odtCitas) {

            try
            {
                DateTime primer_control;
                primer_control = DateTime.Now;
                DataTable odtcitas2 = new DataTable();
                odtcitas2 = odtCitas;
                primer_control = encontrar_semana_16(odtcitas2);

                if (primer_control.Date == Convert.ToDateTime("01/01/1920"))
                {
                    if (odtCitas.Columns.Count >= 2)
                        primer_control = Convert.ToDateTime(odtCitas.Rows[0][1]);
                    if (odtCitas.Columns.Count == 1)
                        primer_control = Convert.ToDateTime(odtCitas.Rows[0][0]);
                }

                return primer_control;

            }
            catch (Exception X) {
                MessageBox.Show("Error:"+X.Message);
                return DateTime.Now;
            }
            
        }

        public DateTime determinar_2do_control(DataTable odtCitas)
        {
            try
            {
                DateTime segundo_control ;
                segundo_control = DateTime.Now;
                DateTime fecha = new DateTime();
                int edad_gestacional = -1;
                segundo_control = encontrar_semana_36(odtCitas);

                if (segundo_control.Date == Convert.ToDateTime("01/01/1920"))
                {
                    /*
                    for (int i = 0; i < odtCitas.Columns.Count; i++) {
                        edad_gestacional = Convert.ToInt16(odtCitas.Rows[2][i]);
                        if (edad_gestacional <= 36) {
                            fecha = Convert.ToDateTime( odtCitas.Rows[0][i] );
                        }
                    }
                    */

                    if (odtCitas.Columns.Count >= 2)
                        segundo_control = Convert.ToDateTime(odtCitas.Rows[0][1]);
                    if (odtCitas.Columns.Count == 1)
                        segundo_control = Convert.ToDateTime(odtCitas.Rows[0][0]);
                }

                return segundo_control;
            }
            catch (Exception X)
            {
                MessageBox.Show("Error:" + X.Message);
                return DateTime.Now;
            }
        }

        public DataTable realizar_citas(DateTime FPP, DateTime Fecha_Registro, int edad_gestacional_citas)
        {
            CapaDeNegocios.CitaPreNatal.cCitaPrenatal oCitaPrenatal = new CapaDeNegocios.CitaPreNatal.cCitaPrenatal();
            DataTable odtCitaPrenatal = new DataTable();
            DataTable odtCitas = new DataTable();
            DateTime fecha_cita, fecha_prox_cita;
            int semana_gestacional = 0;
            DataRow odrCitas = odtCitas.NewRow();
            int k = 0;
            bool ocupado = false;
            /*calculando numero de cita*/

            fecha_cita = Fecha_Registro;
            fecha_prox_cita = Fecha_Registro.AddMonths(1);
            //fecha_fin = Fecha_Registro.AddDays(28);
            semana_gestacional = edad_gestacional_citas;

            while (semana_gestacional <= 42 && Fecha_Registro.Date < FPP.Date)
            {

                /*nº cita, fecha cita, edad gestacional */



                if (k != 0)
                {
                    if (edad_gestacional_citas <= 28 && !ocupado)
                    {
                        edad_gestacional_citas += +4;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 29 && edad_gestacional_citas <= 36 && !ocupado)
                    {
                        edad_gestacional_citas = ((edad_gestacional_citas * 7) + 14) / 7;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 37 && edad_gestacional_citas <= 42 && !ocupado)
                    {
                        edad_gestacional_citas += +1;
                        ocupado = true;
                    }
                    ocupado = false;

                    if (edad_gestacional_citas <= 28 && !ocupado)
                    {
                        //Fecha_Registro = Fecha_Registro.AddDays(28);

                        fecha_cita = fecha_prox_cita;
                        fecha_prox_cita = Fecha_Registro.AddDays(28);
                        Fecha_Registro = fecha_prox_cita;
                        //fecha_prox_cita = Fecha_Registro.AddDays(28);
                        //edad_gestacional_citas += +4;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 29 && edad_gestacional_citas <= 36 && !ocupado)
                    {
                        //Fecha_Registro = fecha_prox_cita.AddDays(15);
                        fecha_cita = fecha_prox_cita;
                        //fecha_prox_cita = Fecha_Registro;
                        fecha_prox_cita = fecha_prox_cita.AddDays(14);
                        Fecha_Registro = fecha_prox_cita;
                        //edad_gestacional_citas = ((edad_gestacional_citas * 7) + 15) / 7;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 37 && edad_gestacional_citas <= 42 && !ocupado)
                    {
                        //Fecha_Registro = fecha_prox_cita.AddDays(7);
                        fecha_cita = fecha_prox_cita;
                        fecha_prox_cita = fecha_prox_cita.AddDays(7);
                        Fecha_Registro = fecha_prox_cita;
                        //edad_gestacional_citas += +1;
                        ocupado = true;
                    }
                }
                else
                {
                    if (edad_gestacional_citas <= 28 && !ocupado)
                    {
                        fecha_cita = Fecha_Registro;
                        fecha_prox_cita = Fecha_Registro.AddDays(28);
                        Fecha_Registro = fecha_prox_cita;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 29 && edad_gestacional_citas <= 36 && !ocupado)
                    {
                        fecha_cita = Fecha_Registro;
                        fecha_prox_cita = Fecha_Registro.AddDays(14);
                        Fecha_Registro = fecha_prox_cita;
                        ocupado = true;
                    }
                    if (edad_gestacional_citas >= 37 && edad_gestacional_citas <= 42 && !ocupado)
                    {
                        fecha_cita = Fecha_Registro;
                        fecha_prox_cita = Fecha_Registro.AddDays(7);
                        Fecha_Registro = fecha_prox_cita;
                        ocupado = true;
                    }
                }
                ocupado = false;
                semana_gestacional = edad_gestacional_citas;
                k++;
                odtCitas.Columns.Add(k + "°", typeof(string));

                if (k == 1)
                {
                    odrCitas = odtCitas.NewRow();
                    odrCitas[odtCitas.Columns.Count - 1] = Fecha_Registro;
                    odtCitas.Rows.InsertAt(odrCitas, 0);

                    odrCitas = odtCitas.NewRow();
                    odrCitas[odtCitas.Columns.Count - 1] = edad_gestacional_citas;
                    odtCitas.Rows.InsertAt(odrCitas, 1);

                    odrCitas = odtCitas.NewRow();
                    odtCitas.Rows.InsertAt(odrCitas, 2);
                }

                odtCitas.Rows[0][odtCitas.Columns.Count - 1] = fecha_cita.ToString("dd/MM/yyyy");
                odtCitas.Rows[1][odtCitas.Columns.Count - 1] = "EG: " + edad_gestacional_citas + "sm";
                odtCitas.Rows[2][odtCitas.Columns.Count - 1] = edad_gestacional_citas;
            }

            return odtCitas;


        }


        public DateTime encontrar_semana_16(DataTable odtcitas)
        {
            DateTime semana_16 = Convert.ToDateTime("01/01/1920");
            int edad_gestacional = -1;
            DateTime fecha = DateTime.Now;
            int i = 0;
            edad_gestacional = Convert.ToInt16(odtcitas.Rows[2][0]);
            fecha = Convert.ToDateTime(odtcitas.Rows[0][0]).Date;
            
            do
            {
                if (edad_gestacional == 16)
                {
                    if (i != 0)
                    {
                        semana_16 = fecha;
                        break;
                    }
                }
                fecha = fecha.AddDays(7);
                edad_gestacional++;
                i++;
            } while (edad_gestacional <= 16);

            return semana_16;
        }

        public DateTime encontrar_semana_36(DataTable odtcitas)
        {
            DateTime semana_36 = Convert.ToDateTime("01/01/1920");
            int edad_gestacional = -1;
            DateTime fecha = DateTime.Now;
            int i = 0;
            edad_gestacional = Convert.ToInt16(odtcitas.Rows[2][0]);
            fecha = Convert.ToDateTime(odtcitas.Rows[0][0]).Date;

            do
            {
                if (edad_gestacional == 36)
                {
                    if (i!=0){ 
                        semana_36 = fecha;
                        break;
                    }
                }
                fecha = fecha.AddDays(7);
                edad_gestacional++;
                i++;
            } while (edad_gestacional <= 36);

            return semana_36;
        }


        /* ===========================Ingreso de solo numeros y solo letras========*/
        //ingresar solo numeros
        public void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        //ingresar solo letras
        public void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        //Devuelve false cuando abriste mas de una ventana
        public bool verificarventanaabierta(string windowName)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name.Equals(windowName))
                {
                    Application.OpenForms[i].BringToFront();
                    return false;
                }
            }
            return true;
        }

        /*devuelve true cuando el archivo esta en uso en el S.O.*/
        public virtual bool archivoenuso(FileInfo file, string path)
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

        public bool es_numerico(String s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public bool es_fecha(String date)
        {
            DateTime Temp;

            if (DateTime.TryParse(date, out Temp) == true)
                return true;
            else
                return false;
        }

        public DataTable enumerar_datatable(DataTable dt, int posicion)
        {
            DataColumnCollection columns = dt.Columns;

            if (!columns.Contains("NRO"))
            {
                dt.Columns.Add("NRO", typeof(string)).SetOrdinal(posicion);
            }
                
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][posicion] = i + 1;
            }
            return dt;
        }


        public string GenerarNumeroMasculino(int N)
        {

            String[] Unidad = { "", "PRIMER", "SEGUNDO", "TERCER",
            "CUARTO", "QUINTO", "SEXTO", "SEPTIMO", "OCTAVO",
            "NOVENO" };
            String[] Decena = { "", "DECIMO", "VIGESIMO", "TRIGESIMO",
            "CUADRAGESIMO", "QUINCUAGESIMO", "SEXAGESIMO",
            "SEPTUAGESIMO", "OCTOGESIMO", "NONAGESIMO" };
            String[] Centena = {"", "centesimo", "ducentesimo",
            "tricentesimo", " cuadringentesimo", " quingentesimo",
            " sexcentesimo", " septingentesimo", " octingentesimo",
            " noningentesimo"};

            string Num = "";
            int u = N % 10;
            int d = (N / 10) % 10;
            int c = N / 100;
            if (N >= 100)
            {
                Num = Centena[c] + " " + Decena[d] + " " + Unidad[u];
            }
            else
            {
                if (N >= 10)
                {
                    Num = Decena[d] + " " + Unidad[u];
                }
                else
                {
                    Num = Unidad[N];
                }
            }
            return Num;
        }

        public string GenerarNumero(int N)
        {
            String[] Unidad = { "", "PRIMERA", "SEGUNDA", "TERCERA",
            "CUARTA", "QUINTA", "SEXTA", "SEPTIMA", "OCTAVA",
            "NOVENA" };
            String[] Decena = { "", "DECIMA", "VIGESIMA", "TRIGESIMA",
            "CUADRAGESIMA", "QUINCUAGESIMA", "SEXAGESIMA",
            "SEPTUAGESIMA", "OCTOGESIMA", "NONAGESIMA" };
            String[] Centena = {"", "centesimo", "ducentesimo",
            "tricentesimo", " cuadringentesimo", " quingentesimo",
            " sexcentesimo", " septingentesimo", " octingentesimo",
            " noningentesimo"};

            string Num = "";
            int u = N % 10;
            int d = (N / 10) % 10;
            int c = N / 100;
            if (N >= 100)
            {
                Num = Centena[c] + " " + Decena[d] + " " + Unidad[u];
            }
            else
            {
                if (N >= 10)
                {
                    Num = Decena[d] + " " + Unidad[u];
                }
                else
                {
                    Num = Unidad[N];
                }
            }
            return Num;
        }

        public virtual bool esta_en_uso(FileInfo file, string path)
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

    }
}
