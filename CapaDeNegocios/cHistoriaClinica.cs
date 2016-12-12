using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cHistoriaClinica
    {
        public string Idthistoriaclinica { get; set; }
        public string Idtestablecimientosalud { get; set; }
        
        public string Tipollegada { get; set; }
        public string Tiempollegada { get; set; }
        public decimal Peso { get; set; }
        public decimal Talla { get; set; }
        public int Edad { get; set; }
        public int Gestas { get; set; }
        public int Partos { get; set; }
        public int Abortos { get; set; }
        public int Hijosvivos { get; set; }
        public int Hijosmuertos { get; set; }
        public DateTime Fur { get; set; }
        public DateTime Fpp { get; set; }
        public int Trimestreapn { get; set; }
        public string Semanaapn { get; set; }
        public string Observaciones { get; set; }
        public string Idtpaciente { get; set; }
        public string Idtobstetra { get; set; }
        public DateTime Fecha { get; set; }
        public int año { get; set; }
        public int mes { get; set; }
        public int Transeunte { get; set; }
        public string OrigenEESS { get; set; }
        public int Archivado { get; set; }
        public DateTime fecha_inicio{ get; set; }
        public DateTime fecha_fin { get; set; }

        public CapaDeNegocios.Paciente.cPaciente oPaciente;

        public List<CitaPreNatal.cCitaPrenatal> CitasPrenatales { get; set; }
        public List<VisitaDomiciliaria.cVisitaDomiciliariaGestante> VisitasDomiciliariasGestante { get; set; }
        public List<VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN> VisitasDomiciliariaPuerpera { get; set; }
        public List<cBateria> Baterias { get; set; }
        public TerminoGestacion.cTerminoGestacion TerminoGestacion { get; set; }
        public List<ControlPeuperio.cControlPeuperio> ControlesPuerpero { get; set; }
        public List<RecienNacido.cRecienNacido> ControlesRecienNacido { get; set; }


        public cHistoriaClinica()
        {
            oPaciente = new CapaDeNegocios.Paciente.cPaciente();
            CitasPrenatales = new List<CitaPreNatal.cCitaPrenatal>();
            VisitasDomiciliariaPuerpera = new List<VisitaDomiciliaria.cVisitaDomiciliariaPuerperaRN>();
            VisitasDomiciliariasGestante = new List<VisitaDomiciliaria.cVisitaDomiciliariaGestante>();
            Baterias = new List<cBateria>();
            ControlesPuerpero = new List<ControlPeuperio.cControlPeuperio>();
            ControlesRecienNacido = new List<RecienNacido.cRecienNacido>();
        }

        public DataTable CrearHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spCrearHistoriaClinica", Idtestablecimientosalud,  Tipollegada, Tiempollegada, Edad, Gestas, Partos, Abortos, Hijosvivos, Hijosmuertos, Fur, Fpp, Trimestreapn, Semanaapn, Observaciones, Idtpaciente, Idtobstetra, Fecha, Transeunte, OrigenEESS,Archivado,Peso,Talla);
        }

        public DataTable ModificarHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spModificarHistoriaClinica", Idthistoriaclinica,  Tipollegada, Tiempollegada, Edad, Gestas, Partos, Abortos, Hijosvivos, Hijosmuertos, Fur, Fpp, Trimestreapn, Semanaapn, Observaciones, Idtpaciente, Idtobstetra, Fecha,Transeunte,OrigenEESS,Archivado,Peso,Talla);
        }

        public DataTable ListarHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spListarHistoriaClinica", Idtestablecimientosalud, año, mes);
        }

        public DataTable ListarHistoriaClinicaLargo()
        {
            return Conexion.GDatos.TraerDataTable("spListarHistoriaClinicaLargo", Idthistoriaclinica, año, mes);
        }

        public DataTable ListarHistoriaClinicaXHistoriaClinica()
        {
            return Conexion.GDatos.TraerDataTable("spListarHistoriaClinicaXHistoriaClinica",Idtestablecimientosalud ,oPaciente.codigohistoriaclinica,Idtobstetra);
        }

        public DataTable ReporteHistoriaClinicaXObstetraXFechasYTranseuntesYArchivado()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaXObstetraXFechasYTranseuntesYArchivado", Idtobstetra, fecha_inicio, fecha_fin, Transeunte, Archivado );
        }
 

        public DataTable ReporteHistoriaClinicaParte1()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaParte1", Idthistoriaclinica);
        }

        public DataTable ReporteHistoriaClinicaParte2()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaParte2", Idthistoriaclinica);
        }

        public DataTable ReporteHistoriaClinicaParte3()
        {
            return Conexion.GDatos.TraerDataTable("spReporteHistoriaClinicaParte3", Idthistoriaclinica);
        }

        public DataTable ListarYear()
        {
            return Conexion.GDatos.TraerDataTable("spListarYear");
        }

        public void CargarDatos(string idHistoriaClinica)
        {
            DataTable aux;
            aux = Conexion.GDatos.TraerDataTableSql("select * from thistoriaclinica where idthistoriaclinica = '" + idHistoriaClinica + "'");
            if (aux.Rows.Count > 0)
            {
                this.Idthistoriaclinica = Convert.ToString(aux.Rows[0]["idthistoriaclinica"]);
                this.Tipollegada = Convert.ToString(aux.Rows[0]["tipollegada"]);
                this.Tiempollegada = Convert.ToString(aux.Rows[0]["tiempollegada"]);
                this.Edad = Convert.ToInt16(aux.Rows[0]["edad"]);
                this.Gestas = Convert.ToInt16(aux.Rows[0]["gestas"]);
                this.Partos = Convert.ToInt16(aux.Rows[0]["partos"]);
                this.Abortos = Convert.ToInt16(aux.Rows[0]["abortos"]);
                this.Hijosvivos = Convert.ToInt16(aux.Rows[0]["hijosvivos"]);
                this.Hijosmuertos = Convert.ToInt16(aux.Rows[0]["hijosmuertos"]);
                this.Fur = Convert.ToDateTime(aux.Rows[0]["fur"]);
                this.Fpp = Convert.ToDateTime(aux.Rows[0]["fpp"]);
                this.Trimestreapn = Convert.ToInt16(aux.Rows[0]["trimestreapn"]);
                this.Semanaapn = Convert.ToString(aux.Rows[0]["semanaapn"]);
                this.Observaciones = Convert.ToString(aux.Rows[0]["observaciones"]);
                this.oPaciente.idtpaciente = Convert.ToString(aux.Rows[0]["idtpaciente"]);
                this.Idtobstetra = Convert.ToString(aux.Rows[0]["idtobstetra"]);
                this.Fecha = Convert.ToDateTime(aux.Rows[0]["fecha"]);
                this.Transeunte = Convert.ToInt16(aux.Rows[0]["transeunte"]);
                this.OrigenEESS = Convert.ToString(aux.Rows[0]["origeneess"]);
                this.Archivado = Convert.ToInt16(aux.Rows[0]["archivado"]);

            }

            aux = Conexion.GDatos.TraerDataTableSql("select * from tcitaprenatal where idthistoriaclinica = '" + idHistoriaClinica + "'");
            for (int i = 0; i < aux.Rows.Count; i++)
            {
                CitaPreNatal.cCitaPrenatal miCitaPrenatal = new CitaPreNatal.cCitaPrenatal();
                miCitaPrenatal.CodigoCitaPrenatal = Convert.ToString(aux.Rows[i]["idtcitaprenatal"]);
                miCitaPrenatal.NumeroCita = Convert.ToInt16(aux.Rows[i]["numeroCita"]);
                miCitaPrenatal.FechaCitaPrenatal = Convert.ToDateTime(aux.Rows[i]["fechacita"]);
                miCitaPrenatal.EdadGestacional = Convert.ToInt16(aux.Rows[i]["edadgestacional"]);
                miCitaPrenatal.Fua = Convert.ToString(aux.Rows[i]["fua"]);
                miCitaPrenatal.PresionArterialS = Convert.ToInt16(aux.Rows[i]["presionarterials"]);
                miCitaPrenatal.PresionArterialD = Convert.ToInt16(aux.Rows[i]["presionarteriald"]);
                miCitaPrenatal.FechaProximaCitaPrenatal = Convert.ToDateTime(aux.Rows[i]["fechaProximacita"]);
                CitasPrenatales.Add(miCitaPrenatal);
            }

            aux = Conexion.GDatos.TraerDataTableSql("select * from tvisitadomiciliariagestante where idthistoriaclinica = '" + idHistoriaClinica + "'");
            for (int j = 0; j < aux.Rows.Count; j++)
            {
                VisitaDomiciliaria.cVisitaDomiciliariaGestante miVisitaGestante = new VisitaDomiciliaria.cVisitaDomiciliariaGestante();
                miVisitaGestante.idtvisitadomiciliariagestante = Convert.ToString(aux.Rows[j]["idtvisitadomiciliariagestante"]);
                miVisitaGestante.fecha = Convert.ToDateTime(aux.Rows[j]["fecha"]);
                miVisitaGestante.motivo = Convert.ToString(aux.Rows[j]["motivo"]);
                miVisitaGestante.fua = Convert.ToString(aux.Rows[j]["fua"]);
                miVisitaGestante.detalle = Convert.ToString(aux.Rows[j]["detalle"]);
                miVisitaGestante.idthistoriaclinica = Convert.ToString(aux.Rows[j]["idthistoriaclinica"]);
                VisitasDomiciliariasGestante.Add(miVisitaGestante);
            }



            aux = Conexion.GDatos.TraerDataTableSql("select * from tbateria where idthistoriaclinica = '" + idHistoriaClinica + "'");
            for (int h = 0; h < aux.Rows.Count; h++)
            {
                cBateria miBateria = new cBateria();
                miBateria.IdBateria = Convert.ToString(aux.Rows[h]["idtbateria"]);
                miBateria.Fecha = Convert.ToDateTime(aux.Rows[h]["fecha"]);
                miBateria.Hemoglobina = Convert.ToString(aux.Rows[h]["hemoglobina"]);
                miBateria.Vih = Convert.ToString(aux.Rows[h]["vih"]);
                miBateria.Sifilis = Convert.ToString(aux.Rows[h]["sifilis"]);
                miBateria.Glucosa = Convert.ToString(aux.Rows[h]["glucosa"]);
                miBateria.Orina = Convert.ToString(aux.Rows[h]["orina"]);
                miBateria.FechaExamenOrina = Convert.ToString(aux.Rows[h]["fechaexamenorina"]);
                miBateria.FechaTratamiento = Convert.ToString(aux.Rows[h]["fechatratamiento"]);
                Baterias.Add(miBateria);
            }

            aux = Conexion.GDatos.TraerDataTableSql("select * from tterminogestacion where idthistoriaclinica = '" + idHistoriaClinica + "'");
            for (int l = 0; l < aux.Rows.Count; l++)
            {
                CapaDeNegocios.TerminoGestacion.cTerminoGestacion miTerminoGestacion = new CapaDeNegocios.TerminoGestacion.cTerminoGestacion();

                miTerminoGestacion.idtterminogestacion = Convert.ToString(aux.Rows[l]["idtterminogestacion"]);
                miTerminoGestacion.gestacion = Convert.ToString(aux.Rows[l]["gestacion"]);
                miTerminoGestacion.lugar = Convert.ToString(aux.Rows[l]["lugar"]);
                miTerminoGestacion.reciennacido = Convert.ToString(aux.Rows[l]["reciennacido"]);
                miTerminoGestacion.fecha = Convert.ToDateTime(aux.Rows[l]["fecha"]);
                miTerminoGestacion.persona = Convert.ToString(aux.Rows[l]["persona"]);
                miTerminoGestacion.tipoparto = Convert.ToString(aux.Rows[l]["tipoparto"]);
                miTerminoGestacion.modoparto = Convert.ToString(aux.Rows[l]["modoparto"]);
                miTerminoGestacion.manejoalumbramiento = Convert.ToString(aux.Rows[l]["manejoalumbramiento"]);
                miTerminoGestacion.tipoinstitucion = Convert.ToString(aux.Rows[l]["tipoinstitucion"]);
                miTerminoGestacion.nombreinstitucion = Convert.ToString(aux.Rows[l]["nombreinstitucion"]);
                miTerminoGestacion.idthistoriaclinica = Convert.ToString(aux.Rows[l]["idthistoriaclinica"]);
                TerminoGestacion = miTerminoGestacion;
            }
        }
    }
}

