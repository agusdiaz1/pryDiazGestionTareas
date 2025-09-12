using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiazGestionTareas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.ShowDialog();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarTareas frm = new frmAgregarTareas();
            frm.ShowDialog();
        }
    }
}
