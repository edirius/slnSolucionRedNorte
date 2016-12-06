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
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

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
                if (Reporte == "rptReporteObstetras")
                {
                    Reportes.rptReporteObstetraMicroRED rptReporteObstetras = new Reportes.rptReporteObstetraMicroRED();

                    crParameterDiscreteValue.Value = sidtmicrored;
                    crParameterFieldDefinitions = rptReporteObstetras.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rptReporteObstetras;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesNominalMicroRED")
                {
                    Reportes.rptReporteGestantesNominalMicroRED rReporteGestantesNominalMicroRED = new Reportes.rptReporteGestantesNominalMicroRED();

                    crParameterDiscreteValue.Value = saño;
                    crParameterFieldDefinitions = rReporteGestantesNominalMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["paño"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = smes;
                    crParameterFieldDefinitions = rReporteGestantesNominalMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pmes"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = sidtmicrored;
                    crParameterFieldDefinitions = rReporteGestantesNominalMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rReporteGestantesNominalMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesMorbilidadMicroRED")
                {
                    Reportes.rptReporteGestantesMorbilidadMicroRED rReporteGestantesMorbilidadMicroRED = new Reportes.rptReporteGestantesMorbilidadMicroRED();

                    crParameterDiscreteValue.Value = saño;
                    crParameterFieldDefinitions = rReporteGestantesMorbilidadMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["paño"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = smes;
                    crParameterFieldDefinitions = rReporteGestantesMorbilidadMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pmes"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = sidtmicrored;
                    crParameterFieldDefinitions = rReporteGestantesMorbilidadMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rReporteGestantesMorbilidadMicroRED;
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
                else if (Reporte == "rptReporteGestantesDadoPartoMicroRED")
                {
                    Reportes.rptReporteGestantesDadoPartoMicroRED rReporteGestantesDadoPartoMicroRED = new Reportes.rptReporteGestantesDadoPartoMicroRED();

                    crParameterDiscreteValue.Value = saño;
                    crParameterFieldDefinitions = rReporteGestantesDadoPartoMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["paño"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = smes;
                    crParameterFieldDefinitions = rReporteGestantesDadoPartoMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pmes"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crParameterDiscreteValue.Value = sidtmicrored;
                    crParameterFieldDefinitions = rReporteGestantesDadoPartoMicroRED.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    crystalReportViewer1.ReportSource = rReporteGestantesDadoPartoMicroRED;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void ReporteObstetra(string tipo, string pidtmicrored)
        {
            Reporte = tipo;
            sidtmicrored = pidtmicrored;
        }

        public void ReporteGestantesNominalMicroRED(string ptipo, string paño, string pmes, string pidtmicrored)
        {
            Reporte = ptipo;
            saño = paño;
            smes = pmes;
            sidtmicrored = pidtmicrored;
        }

        public void ReporteGestantesMorbilidadMicroRED(string ptipo, string paño, string pmes, string pidtmicrored)
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

        public void ReporteGestantesDadoPartoMicroRED(string ptipo, string paño, string pmes, string pidtmicrored)
        {
            Reporte = ptipo;
            saño = paño;
            smes = pmes;
            sidtmicrored = pidtmicrored;
        }
    }
}
