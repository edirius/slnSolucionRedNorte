﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.Shared;
using CrystalDecisions.Windows;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Data.SqlClient;
//using System.Data.SqlClient.SqlConnection;
using System.Data.OleDb;
//using System.Web.UI.Page;

namespace CapaUsuario.Alertas
{
    public partial class frmAlertaControlPuerperio : Form
    {
        TableLogOnInfos crTableLogonInfos;
        TableLogOnInfo crTableLogonInfo;
        ConnectionInfo crConnectionInfo;
        ParameterFieldDefinitions crParameterFieldDefinitions;
        ParameterFieldDefinition crParameterFieldDefinition;
        ParameterValues crParameterValues = new ParameterValues();
        ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
        string Reporte = ""; string sestado; int sidtplanilla;

        public frmAlertaControlPuerperio()
        {
            InitializeComponent();
        }

        private void frmAlertaControlPuerperio_Load(object sender, EventArgs e)
        {
            try
            {
                if (Reporte == "")
                {
                    CapaUsuario.Alertas.rptAlertaControlPuerperio rptAlertaControlPeuperio = new rptAlertaControlPuerperio();

                    crParameterDiscreteValue.Value = cVariables.v_idobstetra;
                    crParameterFieldDefinitions = rptAlertaControlPeuperio.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtobstetra"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = cVariables.v_idestablecimientosalud;
                    crParameterFieldDefinitions = rptAlertaControlPeuperio.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtestablecimientosalud"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rptAlertaControlPeuperio;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
