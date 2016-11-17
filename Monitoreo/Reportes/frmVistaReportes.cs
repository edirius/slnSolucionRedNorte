using System;
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

namespace Monitoreo.Reportes
{
    public partial class frmVistaReportes : Form
    {
        TableLogOnInfos crTableLogonInfos;
        TableLogOnInfo crTableLogonInfo;
        ConnectionInfo crConnectionInfo;
        ParameterFieldDefinitions crParameterFieldDefinitions;
        ParameterFieldDefinition crParameterFieldDefinition;
        ParameterValues crParameterValues = new ParameterValues();
        ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
        string Reporte = "";
        string saño; string smes; string sidtmicrored;

        public frmVistaReportes()
        {
            InitializeComponent();
        }

        private void frmVistaReportes_Load(object sender, EventArgs e)
        {
            try
            {
                if (Reporte == "rptReportesObstetras")
                {
                    Reportes.rptReportesObstetras rptReportesObstetras = new Reportes.rptReportesObstetras();

                    //crParameterDiscreteValue.Value = cVariables.v_idobstetra;
                    //crParameterFieldDefinitions = rptAlertaControlPeuperio.DataDefinition.ParameterFields;
                    //crParameterFieldDefinition = crParameterFieldDefinitions["pidtobstetra"];
                    //crParameterValues.Add(crParameterDiscreteValue);
                    //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    //crParameterDiscreteValue.Value = cVariables.v_idestablecimientosalud;
                    //crParameterFieldDefinitions = rptAlertaControlPeuperio.DataDefinition.ParameterFields;
                    //crParameterFieldDefinition = crParameterFieldDefinitions["pidtestablecimientosalud"];
                    //crParameterValues.Add(crParameterDiscreteValue);
                    //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rptReportesObstetras;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteNominalGestanteMicroRED")
                {
                    Reportes.rptReporteNominalGestanteMicroRED rReporteNominalGestanteMicroRED = new Reportes.rptReporteNominalGestanteMicroRED();

                    crParameterDiscreteValue.Value = saño;
                    crParameterFieldDefinitions = rReporteNominalGestanteMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["paño"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = smes;
                    crParameterFieldDefinitions = rReporteNominalGestanteMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pmes"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = sidtmicrored;
                    crParameterFieldDefinitions = rReporteNominalGestanteMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rReporteNominalGestanteMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesFechaPPMicroRED")
                {
                    Reportes.rptReporteGestantesFechaPPMicroRED rReporteGestantesFechaPPMicroRED = new Reportes.rptReporteGestantesFechaPPMicroRED();

                    crParameterDiscreteValue.Value = saño;
                    crParameterFieldDefinitions = rReporteGestantesFechaPPMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["paño"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = smes;
                    crParameterFieldDefinitions = rReporteGestantesFechaPPMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pmes"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = sidtmicrored;
                    crParameterFieldDefinitions = rReporteGestantesFechaPPMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rReporteGestantesFechaPPMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestanteDadoPartoMicroRED")
                {
                    Reportes.rptReporteGestanteDadoPartoMicroRED rReporteGestanteDadoPartoMicroRED = new Reportes.rptReporteGestanteDadoPartoMicroRED();

                    crParameterDiscreteValue.Value = saño;
                    crParameterFieldDefinitions = rReporteGestanteDadoPartoMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["paño"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = smes;
                    crParameterFieldDefinitions = rReporteGestanteDadoPartoMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pmes"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = sidtmicrored;
                    crParameterFieldDefinitions = rReporteGestanteDadoPartoMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rReporteGestanteDadoPartoMicroRED;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void ReporteObstetra(string tipo)
        {
            Reporte = tipo;
        }

        public void ReporteNominalGestanteMicroRED(string ptipo, string paño, string pmes, string pidtmicrored)
        {
            Reporte = ptipo;
            saño = paño;
            smes = pmes;
            sidtmicrored = pidtmicrored;
        }

        public void ReporteGestantesFechaPPMicroRED(string ptipo, string paño, string pmes, string pidtmicrored)
        {
            Reporte = ptipo;
            saño = paño;
            smes = pmes;
            sidtmicrored = pidtmicrored;
        }

        public void ReporteGestanteDadoPartoMicroRED(string ptipo, string paño, string pmes, string pidtmicrored)
        {
            Reporte = ptipo;
            saño = paño;
            smes = pmes;
            sidtmicrored = pidtmicrored;
        }
    }
}
