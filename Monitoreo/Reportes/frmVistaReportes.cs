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
                    MicroRed(rptReporteObstetras, sidtmicrored);
                    crystalReportViewer1.ReportSource = rptReporteObstetras;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesNominalMicroRED")
                {
                    Reportes.rptReporteGestantesNominalMicroRED rReporteGestantesNominalMicroRED = new Reportes.rptReporteGestantesNominalMicroRED();
                    Año(rReporteGestantesNominalMicroRED, saño);
                    Mes(rReporteGestantesNominalMicroRED, smes);
                    MicroRed(rReporteGestantesNominalMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesNominalMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesTranseuntesMicroRED")
                {
                    Reportes.rptReporteGestantesTranseuntesMicroRED rReporteGestantesTranseuntesMicroRED = new Reportes.rptReporteGestantesTranseuntesMicroRED();
                    Año(rReporteGestantesTranseuntesMicroRED, saño);
                    Mes(rReporteGestantesTranseuntesMicroRED, smes);
                    MicroRed(rReporteGestantesTranseuntesMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesTranseuntesMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesFechaPPMicroRED")
                {
                    Reportes.rptReporteGestantesFechaPPMicroRED rReporteGestantesFechaPPMicroRED = new Reportes.rptReporteGestantesFechaPPMicroRED();
                    Año(rReporteGestantesFechaPPMicroRED, saño);
                    Mes(rReporteGestantesFechaPPMicroRED, smes);
                    MicroRed(rReporteGestantesFechaPPMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesFechaPPMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesDadoPartoMicroRED")
                {
                    Reportes.rptReporteGestantesDadoPartoMicroRED rReporteGestantesDadoPartoMicroRED = new Reportes.rptReporteGestantesDadoPartoMicroRED();
                    Año(rReporteGestantesDadoPartoMicroRED, saño);
                    Mes(rReporteGestantesDadoPartoMicroRED, smes);
                    MicroRed(rReporteGestantesDadoPartoMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesDadoPartoMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteRNBajoPesoMicroRED")
                {
                    Reportes.rptReporteRNBajoPesoMicroRED rReporteRNBajoPesoMicroRED = new Reportes.rptReporteRNBajoPesoMicroRED();
                    Año(rReporteRNBajoPesoMicroRED, saño);
                    Mes(rReporteRNBajoPesoMicroRED, smes);
                    MicroRed(rReporteRNBajoPesoMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteRNBajoPesoMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesMorbilidadMicroRED")
                {
                    Reportes.rptReporteGestantesMorbilidadMicroRED rReporteGestantesMorbilidadMicroRED = new Reportes.rptReporteGestantesMorbilidadMicroRED();
                    Año(rReporteGestantesMorbilidadMicroRED, saño);
                    Mes(rReporteGestantesMorbilidadMicroRED, smes);
                    MicroRed(rReporteGestantesMorbilidadMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesMorbilidadMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesConPresionAltaMicroRED")
                {
                    Reportes.rptReporteGestantesConPresionAltaMicroRED rReporteGestantesConPresionAltaMicroRED = new Reportes.rptReporteGestantesConPresionAltaMicroRED();
                    Año(rReporteGestantesConPresionAltaMicroRED, saño);
                    Mes(rReporteGestantesConPresionAltaMicroRED, smes);
                    MicroRed(rReporteGestantesConPresionAltaMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesConPresionAltaMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesNoAcudenCitasMicroRED")
                {
                    Reportes.rptReporteGestantesNoAcudenCitasMicroRED rReporteGestantesNoAcudenCitasMicroRED = new Reportes.rptReporteGestantesNoAcudenCitasMicroRED();
                    Año(rReporteGestantesNoAcudenCitasMicroRED, saño);
                    Mes(rReporteGestantesNoAcudenCitasMicroRED, smes);
                    MicroRed(rReporteGestantesNoAcudenCitasMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesNoAcudenCitasMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesSinBateriaMicroRED")
                {
                    Reportes.rptReporteGestantesSinBateriaMicroRED rReporteGestantesSinBateriaMicroRED = new Reportes.rptReporteGestantesSinBateriaMicroRED();
                    Año(rReporteGestantesSinBateriaMicroRED, saño);
                    Mes(rReporteGestantesSinBateriaMicroRED, smes);
                    MicroRed(rReporteGestantesSinBateriaMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesSinBateriaMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesConAnemiaMicroRED")
                {
                    Reportes.rptReporteGestantesConAnemiaMicroRED rReporteGestantesConAnemiaMicroRED = new Reportes.rptReporteGestantesConAnemiaMicroRED();
                    Año(rReporteGestantesConAnemiaMicroRED, saño);
                    Mes(rReporteGestantesConAnemiaMicroRED, smes);
                    MicroRed(rReporteGestantesConAnemiaMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesConAnemiaMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesConSifilisMicroRED")
                {
                    Reportes.rptReporteGestantesConSifilisMicroRED rReporteGestantesConSifilisMicroRED = new Reportes.rptReporteGestantesConSifilisMicroRED();
                    Año(rReporteGestantesConSifilisMicroRED, saño);
                    Mes(rReporteGestantesConSifilisMicroRED, smes);
                    MicroRed(rReporteGestantesConSifilisMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesConSifilisMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesConVIHMicroRED")
                {
                    Reportes.rptReporteGestantesConVIHMicroRED rReporteGestantesConVIHMicroRED = new Reportes.rptReporteGestantesConVIHMicroRED();
                    Año(rReporteGestantesConVIHMicroRED, saño);
                    Mes(rReporteGestantesConVIHMicroRED, smes);
                    MicroRed(rReporteGestantesConVIHMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesConVIHMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesConInfeccionUrinariaMicroRED")
                {
                    Reportes.rptReporteGestantesConInfeccionUrinariaMicroRED rReporteGestantesConInfeccionUrinariaMicroRED = new Reportes.rptReporteGestantesConInfeccionUrinariaMicroRED();
                    Año(rReporteGestantesConInfeccionUrinariaMicroRED, saño);
                    Mes(rReporteGestantesConInfeccionUrinariaMicroRED, smes);
                    MicroRed(rReporteGestantesConInfeccionUrinariaMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesConInfeccionUrinariaMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesSinTratamientoMicroRED")
                {
                    Reportes.rptReporteGestantesSinTratamientoMicroRED rReporteGestantesSinTratamientoMicroRED = new Reportes.rptReporteGestantesSinTratamientoMicroRED();
                    Año(rReporteGestantesSinTratamientoMicroRED, saño);
                    Mes(rReporteGestantesSinTratamientoMicroRED, smes);
                    MicroRed(rReporteGestantesSinTratamientoMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesSinTratamientoMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReporteGestantesSinExamenOrinaMicroRED")
                {
                    Reportes.rptReporteGestantesSinExamenOrinaMicroRED rReporteGestantesSinExamenOrinaMicroRED = new Reportes.rptReporteGestantesSinExamenOrinaMicroRED();
                    Año(rReporteGestantesSinExamenOrinaMicroRED, saño);
                    Mes(rReporteGestantesSinExamenOrinaMicroRED, smes);
                    MicroRed(rReporteGestantesSinExamenOrinaMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReporteGestantesSinExamenOrinaMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReportePuerperaSinControlPuerperioMicroRED")
                {
                    Reportes.rptReportePuerperaSinControlPuerperioMicroRED rReportePuerperaSinControlPuerperioMicroRED = new Reportes.rptReportePuerperaSinControlPuerperioMicroRED();
                    Año(rReportePuerperaSinControlPuerperioMicroRED, saño);
                    Mes(rReportePuerperaSinControlPuerperioMicroRED, smes);
                    MicroRed(rReportePuerperaSinControlPuerperioMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReportePuerperaSinControlPuerperioMicroRED;
                    crystalReportViewer1.Refresh();
                }
                else if (Reporte == "rptReportePuerperaSin2ControlPuerperioMicroRED")
                {
                    Reportes.rptReportePuerperaSin2ControlPuerperioMicroRED rReportePuerperaSin2ControlPuerperioMicroRED = new Reportes.rptReportePuerperaSin2ControlPuerperioMicroRED();
                    Año(rReportePuerperaSin2ControlPuerperioMicroRED, saño);
                    Mes(rReportePuerperaSin2ControlPuerperioMicroRED, smes);
                    MicroRed(rReportePuerperaSin2ControlPuerperioMicroRED, sidtmicrored);
                    crystalReportViewer1.ReportSource = rReportePuerperaSin2ControlPuerperioMicroRED;
                    crystalReportViewer1.Refresh();
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void MicroRed(ReportClass rpt, string pidtmicrored)
        {
            crParameterDiscreteValue.Value = pidtmicrored;
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
        }

        private void Año(ReportClass rpt, string paño)
        {
            crParameterDiscreteValue.Value = paño;
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["paño"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
        }

        private void Mes(ReportClass rpt, string pmes)
        {
            crParameterDiscreteValue.Value = pmes;
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["pmes"];
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
        }

        public void Reportes(string ptipo, string paño, string pmes, string pidtmicrored)
        {
            Reporte = ptipo;
            saño = paño;
            smes = pmes;
            sidtmicrored = pidtmicrored;
        }
    }
}
