﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;
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
        public DataTable AlertaGestanteSinBateria2(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spAlertaGestanteBateria2", mes, año);
        }
        
        public DataTable AlertaGestantePresionArterial()
        {
            return Conexion.GDatos.TraerDataTable("spListarGestantesConRiesgoXPresionArterial");
        }

        public DataTable AlertaRecienNacidoBajoPeso(string mes, string año)
        {
            return Conexion.GDatos.TraerDataTable("spReporteRecienNacidosBajoPeso2", mes, año);
        }

    }
}