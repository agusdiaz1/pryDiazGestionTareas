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
    public partial class frmUsuarios : Form
    {
        ConexionBD conexion = new ConexionBD();

        public frmUsuarios()
        {
            InitializeComponent();
            conexion.listarUsuarios(dgvUsuarios);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuarios nuevoUsuario = new Usuarios();

            nuevoUsuario.id = int.Parse(txtId.Text);
            nuevoUsuario.nombre = txtNombreUsuario.Text;
            nuevoUsuario.categoria = cboCategoria.Text;

            try
            {
                conexion.AgregarUsuarios(nuevoUsuario);
                LimpiarCampos();
                conexion.listarUsuarios(dgvUsuarios);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            txtId.Clear();
            txtNombreUsuario.Clear();
            cboCategoria.Items.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuarios UsuarioModificado = new Usuarios();

            int codigo;
            if (!int.TryParse(txtId.Text, out codigo))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return;
            }

            UsuarioModificado.id = int.Parse(txtId.Text);
            UsuarioModificado.nombre = txtNombreUsuario.Text;
            UsuarioModificado.categoria = cboCategoria.Text;

            try
            {
                conexion.ModificarUsuarios(UsuarioModificado);
                LimpiarCampos();
                conexion.listarUsuarios(dgvUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Por favor, ingrese un ID de Contacto válido.");
                return;
            }

            try
            {
                conexion.EliminarUsuario(id);
                LimpiarCampos();
                conexion.listarUsuarios(dgvUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }
    }
}
