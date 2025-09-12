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
            Tareas tareanueva = new Tareas();

            tareanueva.titulo = txtTitulo.Text;
            tareanueva.descripcion = txtDescripcion.Text;
            tareanueva.categoria = cboCategoria.Text;
            tareanueva.prioridad = cboPrioridad.Text;
            tareanueva.fechaVencimiento = dtpVencimiento.Value;
            tareanueva.estado = "Pendiente";
            tareanueva.usuario = cboUsuario.Text;

            try
            {
                conexion.AgregarTarea(tareanueva);
                LimpiarCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
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
    }
}
