using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.Obstetra
{
    public class cObstetra
    {
        string sidtobstetra;
        string snombres;
        string sapellidopaterno;
        string sapellidomaterno;
        string ssexo;
        string sdni;
        DateTime sfechanacimiento;
        string sdireccion;
        string stelefono;
        string stituloprofesional;
        string sidtestablecimientosalud;
        string susuario;
        string spassword;

        public string idtobstetra
        { get { return sidtobstetra; } set { sidtobstetra = value; } }
        public string nombres
        { get { return snombres; } set { snombres = value; } }
        public string apellidopaterno
        { get { return sapellidopaterno; } set { sapellidopaterno = value; } }
        public string apellidomaterno
        { get { return sapellidomaterno; } set { sapellidomaterno = value; } }
        public string sexo
        { get { return ssexo; } set { ssexo = value; } }
        public string dni
        { get { return sdni; } set { sdni = value; } }
        public DateTime fechanacimiento
        { get { return sfechanacimiento; } set { sfechanacimiento = value; } }
        public string direccion
        { get { return sdireccion; } set { sdireccion = value; } }
        public string telefono
        { get { return stelefono; } set { stelefono = value; } }
        public string tituloprofesional
        { get { return stituloprofesional; } set { stituloprofesional = value; } }
        public string idtestablecimientosalud
        { get { return sidtestablecimientosalud; } set { sidtestablecimientosalud = value; } }
        public string usuario
        { get { return susuario; } set { susuario = value; } }
        public string password
        { get { return spassword; } set { spassword = value; } }

        public DataTable ListarObstetra(string idtestablecimientosalud)
        {
            return Conexion.GDatos.TraerDataTable("spListarObstetra", idtestablecimientosalud);
        }

        public Boolean CrearObstetra(cObstetra miObstetra)
        {
            Conexion.GDatos.Ejecutar("spCrearObstetra", miObstetra.idtobstetra, miObstetra.nombres, miObstetra.apellidopaterno, miObstetra.apellidomaterno, miObstetra.sexo, miObstetra.dni, miObstetra.fechanacimiento, miObstetra.direccion, miObstetra.telefono, miObstetra.tituloprofesional, miObstetra.idtestablecimientosalud, miObstetra.usuario, miObstetra.password);
            return true;
        }

        public Boolean ModificarObstetra(cObstetra miObstetra)
        {
            Conexion.GDatos.Ejecutar("spModificarObstetra", miObstetra.idtobstetra, miObstetra.nombres, miObstetra.apellidopaterno, miObstetra.apellidomaterno, miObstetra.sexo, miObstetra.dni, miObstetra.fechanacimiento, miObstetra.direccion, miObstetra.telefono, miObstetra.tituloprofesional, miObstetra.idtestablecimientosalud, miObstetra.usuario, miObstetra.password);
            return true;
        }

        public Boolean EliminarObstetra(string idtObstetra)
        {
            Conexion.GDatos.Ejecutar("spELiminarObstetra", idtObstetra);
            return true;
        }
    }
}
