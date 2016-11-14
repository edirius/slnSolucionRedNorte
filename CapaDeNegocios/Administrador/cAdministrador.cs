using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios.Administrador
{
    public class cAdministrador
    {
        string sidtadministrador;
        string snombres;
        string sapellidopaterno;
        string sapellidomaterno;
        string ssexo;
        string sdni;
        DateTime sfechanacimiento;
        string sdireccion;
        string stelefono;
        string susuario;
        string spassword;

        public string idtadministrador
        { get { return sidtadministrador; } set { sidtadministrador = value; } }
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
        public string usuario
        { get { return susuario; } set { susuario = value; } }
        public string password
        { get { return spassword; } set { spassword = value; } }

        public DataTable ListarAdministrador()
        {
            return Conexion.GDatos.TraerDataTable("spListarAdministrador");
        }

        public Boolean CrearAdministrador(cAdministrador miAdministrador)
        {
            Conexion.GDatos.Ejecutar("spCrearAdministrador", miAdministrador.idtadministrador, miAdministrador.nombres, miAdministrador.apellidopaterno, miAdministrador.apellidomaterno, miAdministrador.sexo, miAdministrador.dni, miAdministrador.fechanacimiento, miAdministrador.direccion, miAdministrador.telefono, miAdministrador.usuario, miAdministrador.password);
            return true;
        }

        public Boolean ModificarAdministrador(cAdministrador miAdministrador)
        {
            Conexion.GDatos.Ejecutar("spModificarAdministrador", miAdministrador.idtadministrador, miAdministrador.nombres, miAdministrador.apellidopaterno, miAdministrador.apellidomaterno, miAdministrador.sexo, miAdministrador.dni, miAdministrador.fechanacimiento, miAdministrador.direccion, miAdministrador.telefono, miAdministrador.usuario, miAdministrador.password);
            return true;
        }

        public Boolean EliminarAdministrador(string idtAdministrador)
        {
            Conexion.GDatos.Ejecutar("spELiminarAdministrador", idtAdministrador);
            return true;
        }
    }
}
