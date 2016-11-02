using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUsuario
{
    public partial class frmTranseunte : Form
    {
        public frmTranseunte()
        {
            InitializeComponent();
        }

        public string CodigoEstablecimiento { get; set; }

        private void frmTranseunte_Load(object sender, EventArgs e)
        {

        }
    }
}
