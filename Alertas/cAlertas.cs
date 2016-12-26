using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;
using System.Windows.Forms;
using CapaDeNegocios;
namespace Alertas
{
    public class cAlertas
    {
        /* PROCEDIMIENTOS PARA EL SISTEMA DE ALERTAS*/
        public DataTable ListadeAlertasenBateria2(string tipo, string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertasBateria2", tipo, mes, año);
        }
        public DataTable AlertaGestanteAnemia2(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteAnemia2", mes, año);
        }
        public DataTable AlertaGestanteVIH2(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteVIH2", mes, año);
        }
        public DataTable AlertaGestanteSifilis2(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteSifilis2", mes, año);
        }
        public DataTable AlertaGestanteOrina2(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteOrina2", mes, año);
        }
        public DataTable AlertaGestanteSinFechaTratamiento2(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteSinFechaTratamiento2", mes, año);
        }
        public DataTable AlertaGestanteSinExamenOrina2(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteSinExamenOrina2", mes, año);
        }
        public DataTable AlertaGestanteSinBateria2()
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteBateria2");
        }
        //RN
        public DataTable AlertaRecienNacidoBajoPeso(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spReporteRecienNacidosBajoPeso2", mes, año);
        }
        //CITAS PRENATALES
        public DataTable AlertaGestanteNoAcudeCitas()
        {
            return Conexion.GDatos.TraerDataTable("spListarGestantesQueNoAcudenALasCitas2");
        }
        //GESTANTES CON PROBLEMAS DE PRESION ARTERIAL
        public DataTable AlertaGestantePresionPAalta(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spGestantePresionConPAalta", mes, año);
        }
        //GESTANTES SIN CONTROL PUERPERIO
        public DataTable AlertaPuerperaSinControlPuerperio(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaSinControlPuerperio", mes, año);
        }
        public DataTable AlertaPuerperaSin2doControlPuerperio(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaSinControlPuerperio2", mes, año);
        }
        public DataTable AlertaOdontologia()
        {
            return Conexion.GDatos.TraerDataTable("spAlertaOdontologia");
        }
        public DataTable AlertaEcografia()
        {
            return Conexion.GDatos.TraerDataTable("spAlertaEcografia");
        }
        public DataTable AlertaOdontologia2()
        {
            return Conexion.GDatos.TraerDataTable("spAlertaOdontologia2");
        }
        public DataTable AlertaEcografia2()
        {
            return Conexion.GDatos.TraerDataTable("spAlertaEcografia2");
        }
        public DataTable AlertaGestanteSinBateria3()
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteBateria3");
        }
        public DateTime determinar_1er_control(DataTable odtCitas)
        {

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
            catch (Exception X)
            {
                MessageBox.Show("Error:" + X.Message);
                return DateTime.Now;
            }

        }

        public DateTime determinar_2do_control(DataTable odtCitas)
        {
            try
            {
                DateTime segundo_control;
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
                    if (i != 0)
                    {
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

    }
}
