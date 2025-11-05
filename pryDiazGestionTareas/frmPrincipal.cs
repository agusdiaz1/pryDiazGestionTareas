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
    //Agregar y completar tareas funciona
    //Agrgar modificar y editar Usuarios funciona
    //Filtrar Tareas y hacer reporte no funciona
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
            if (dgvPendientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una tarea para completar.");
                return;
            }

            int idTarea = Convert.ToInt32(dgvPendientes.CurrentRow.Cells["Id"].Value);
            conexion.CompletarTarea(idTarea);

            // Refrescar grillas
            conexion.listarTareasPendientes(dgvPendientes);
            conexion.listarTareasCompletadas(dgvCompletadas);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Agregar y completar tareas funciona. Agregar, modificar y editar Usuarios funciona. Filtrar Tareas y hacer reporte no funciona");
            conexion.listarTareasPendientes(dgvPendientes);
            conexion.listarTareasCompletadas(dgvCompletadas);

        }

        private void btnReabrir_Click(object sender, EventArgs e)
        {
            if (dgvCompletadas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una tarea para reabrir.");
                return;
            }

            int idTarea = Convert.ToInt32(dgvCompletadas.CurrentRow.Cells["Id"].Value);

            conexion.ReabrirTarea(idTarea);

            // Refrescar grillas
            conexion.listarTareasCompletadas(dgvCompletadas);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.listarTareasPendientes(dgvPendientes);
        }

        private void crearYAsignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
