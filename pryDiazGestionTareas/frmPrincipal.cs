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
        ConexionBD conexion = new ConexionBD();
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

        public void LimpiarCampos()
        {
            txtIdPendientes.Clear();
            txtIdCompletadas.Clear();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtIdPendientes.Text, out id))
            {
                MessageBox.Show("Por favor, ingrese un ID de Contacto válido.");
                return;
            }

            try
            {
                conexion.CompletarTarea(id);
                LimpiarCampos();
                conexion.listarTareasPendientes(dgvPendientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            conexion.listarTareasPendientes(dgvPendientes);

        }

        
    }
}
