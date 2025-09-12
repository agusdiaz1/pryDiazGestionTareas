using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiazGestionTareas
{
    public class ConexionBD
    {

        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;

        string cadena;
        public ConexionBD() 
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source= ../../../BD/GestionTareas.accdb";
        }

        public List<string> ObtenerCategoriasUsuario()
        {
            List<string> categorias = new List<string>();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string sql = "SELECT DISTINCT Categoria FROM Usuarios";
                    using (OleDbCommand comando = new OleDbCommand(sql, conexion))
                    {
                        conexion.Open();
                        OleDbDataReader lector = comando.ExecuteReader();

                        while (lector.Read())
                        {
                            categorias.Add(lector["Categoria"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener categorías: " + ex.Message);
            }

            return categorias;
        }

        public DataTable ObtenerUsuariosPorCategoria()
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                using (OleDbCommand comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT * FROM Usuarios ORDER BY Categoria";
                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }
        }

        public void listarUsuarios(DataGridView dgvUsuarios)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Usuarios";

                DataTable tablaUsuarios = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                dgvUsuarios.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void AgregarUsuarios(Usuarios nuevoUsuario)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                using (OleDbCommand comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO Usuarios (Nombre, Categoria) " +
                               "VALUES (@Nombre, @Categoria)";

                    comando.Parameters.AddWithValue("@Nombre", nuevoUsuario.nombre);
                    comando.Parameters.AddWithValue("@Categoria", nuevoUsuario.categoria);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejar la excepción (por ejemplo, mostrar un mensaje de error al usuario)
                        MessageBox.Show("Error al agregar el usuario: " + ex.Message);
                    }
                }
            }

        }

        public void ModificarUsuarios(Usuarios usuario)
        {

            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                using (OleDbCommand comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText
                         = @"UPDATE Usuarios
                                 SET 
                                     Categoria = @nuevaCategoria
                                     WHERE Id = @id";

                    comando.Parameters.AddWithValue("@nuevoNombre", usuario.nombre);
                    comando.Parameters.AddWithValue("@nuevaCategoria", usuario.categoria);
                    comando.Parameters.AddWithValue("@id", usuario.id);

                    try
                    {

                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {

                            MessageBox.Show("Usuario modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún usuario con el ID especificado.");
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al modificar el usuario: " + ex.Message);
                    }
                }
            }

        }

        public void EliminarUsuario(int id)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                using (OleDbCommand comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = @"DELETE FROM Usuarios WHERE Id = @id";

                    // Agregar el parámetro
                    comando.Parameters.AddWithValue("@id", id);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente.");

                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún con usuario con el ID especificado.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                    }
                }
            }
        }
    }
}
