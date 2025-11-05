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
    public partial class frmAgregarTareas : Form
    {
        ConexionBD conexion = new ConexionBD();
        public frmAgregarTareas()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("Ingrese el título.");
                    return;
                }

                Tareas nueva = new Tareas();
                nueva.titulo = txtTitulo.Text.Trim();
                nueva.descripcion = txtDescripcion.Text.Trim();
                nueva.categoria = cboCategoria.Text;
                nueva.prioridad = cboPrioridad.Text;
                nueva.fechaVencimiento = dtpVencimiento.Value;
                nueva.usuario = cboUsuario.Text;
                                                               

                conexion.AgregarTarea(nueva);
                //conexion.listarTareasPendientes(dgvPendientes);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la tarea: " + ex.Message);
            }
        }

        public void CargarCombos()
        {
            cboPrioridad.Items.Add("Alta");
            cboPrioridad.Items.Add("Media");
            cboPrioridad.Items.Add("Baja");

            cboUsuario.Items.Clear();
            List<string> listaUsuarios = conexion.ObtenerUsuarios();

            foreach (var usu in listaUsuarios)
            {
                cboUsuario.Items.Add(usu);
            }

            cboCategoria.Items.Clear();
            List<string> listaCategorias = conexion.ObtenerCategoriasUsuario();

            foreach (var cat in listaCategorias)
            {
                cboCategoria.Items.Add(cat);
            }

        }

        public void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            cboCategoria.SelectedIndex = -1;
            cboPrioridad.SelectedIndex = -1;
            cboUsuario.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
