﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDeDatos;

namespace CapaDeNegocios
{
    public class cPaciente
    {
        string sidtpaciente;
        string snombres;
        string sapellidopaterno;
        string sapellidomaterno;
        string sdni;
        DateTime sfechanacimiento;
        string sdireccion;
        string stelefono;
        string sidtestablecimientosalud;

        public string idtpaciente
        { get { return sidtpaciente; } set { sidtpaciente = value; } }
        public string nombres
        { get { return snombres; } set { snombres = value; } }
        public string apellidopaterno
        { get { return sapellidopaterno; } set { sapellidopaterno = value; } }
        public string apellidomaterno
        { get { return sapellidomaterno; } set { sapellidomaterno = value; } }
        public string dni
        { get { return sdni; } set { sdni = value; } }
        public DateTime fechanacimiento
        { get { return sfechanacimiento; } set { sfechanacimiento = value; } }
        public string direccion
        { get { return sdireccion; } set { sdireccion = value; } }
        public string telefono
        { get { return stelefono; } set { stelefono = value; } }
        public string idtestablecimientosalud
        { get { return sidtestablecimientosalud; } set { sidtestablecimientosalud = value; } }

        public DataTable ListarPaciente(string idtestablecimientosalud)
        {
            return Conexion.GDatos.TraerDataTable("spListarPaciente", idtestablecimientosalud);
        }

        public Boolean CrearPaciente(cPaciente mipaciente)
        {
            Conexion.GDatos.Ejecutar("spCrearPaciente", mipaciente.idtpaciente, mipaciente.nombres, mipaciente.apellidopaterno, mipaciente.apellidomaterno, mipaciente.dni, mipaciente.fechanacimiento, mipaciente.direccion, mipaciente.telefono, mipaciente.idtestablecimientosalud);
            return true;
        }

        public Boolean ModificarPaciente(cPaciente mipaciente)
        {
            Conexion.GDatos.Ejecutar("spModificarPaciente", mipaciente.idtpaciente, mipaciente.nombres, mipaciente.apellidopaterno, mipaciente.apellidomaterno, mipaciente.dni, mipaciente.fechanacimiento, mipaciente.direccion, mipaciente.telefono, mipaciente.idtestablecimientosalud);
            return true;
        }

        public Boolean EliminarPaciente(string idtpaciente)
        {
            Conexion.GDatos.Ejecutar("spELiminarPaciente", idtpaciente);
            return true;
        }
    }
}
