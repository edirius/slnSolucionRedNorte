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

namespace Prueba.Reportes
{
    public partial class frmReporteObstetras : Form
    {
        TableLogOnInfos crTableLogonInfos;
        TableLogOnInfo crTableLogonInfo;
        ConnectionInfo crConnectionInfo;
        ParameterFieldDefinitions crParameterFieldDefinitions;
        ParameterFieldDefinition crParameterFieldDefinition;
        ParameterValues crParameterValues = new ParameterValues();
        ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
        string sidtmicrored;

        public frmReporteObstetras()
        {
            InitializeComponent();
        }

        private void frmReporteObstetras_Load(object sender, EventArgs e)
        {
            try
            {
                Reportes.rptReportesObstetras rptReportesObstetras = new Reportes.rptReportesObstetras();

                crParameterDiscreteValue.Value = sidtmicrored;
                crParameterFieldDefinitions = rptReportesObstetras.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["pidtmicrored"];
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = rptReportesObstetras;
                crystalReportViewer1.Refresh();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void ReporteObstetra(string pidtmicrored)
        {
            sidtmicrored = pidtmicrored;
        }
    }
}
