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


        public void listarTareasPendientes(DataGridView dgvPendientes)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                using (OleDbCommand comando = new OleDbCommand("SELECT * FROM Tareas WHERE Estado = 'Pendiente'", conexion))
                using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                {
                    DataTable tablaTareas = new DataTable();
                    adaptador.Fill(tablaTareas);
                    dgvPendientes.DataSource = tablaTareas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void listarTareasCompletadas(DataGridView dgvCompletadas)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                using (OleDbCommand comando = new OleDbCommand("SELECT * FROM Tareas WHERE Estado = 'Completada'", conexion))
                using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                {
                    DataTable tablaTareas = new DataTable();
                    adaptador.Fill(tablaTareas);
                    dgvCompletadas.DataSource = tablaTareas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AgregarTarea(Tareas tareanueva)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                string sql = @"INSERT INTO Tareas 
                       (Titulo, Descripcion, Categoria, Prioridad, Vencimiento, Estado, Usuario) 
                       VALUES (@titulo, @descripcion, @categoria, @prioridad, @vencimiento, @estado, @usuario)";

                using (OleDbCommand cmd = new OleDbCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@titulo", tareanueva.titulo);
                    cmd.Parameters.AddWithValue("@descripcion", tareanueva.descripcion);
                    cmd.Parameters.AddWithValue("@categoria", tareanueva.categoria);
                    cmd.Parameters.AddWithValue("@prioridad", tareanueva.prioridad);
                    cmd.Parameters.AddWithValue("@vencimiento", tareanueva.fechaVencimiento);
                    cmd.Parameters.AddWithValue("@estado", "Pendiente");
                    cmd.Parameters.AddWithValue("@usuario", tareanueva.usuario);

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tarea agregada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar la tarea: " + ex.Message);
                    }
                }
            }
        }


        public void CompletarTarea(int idTarea)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                string sql = "UPDATE Tareas SET Estado = 'Completada' WHERE Id = @id";
                using (OleDbCommand cmd = new OleDbCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idTarea);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ReabrirTarea(int idTarea)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                string sql = "UPDATE Tareas SET Estado = 'Pendiente' WHERE Id = @id";
                using (OleDbCommand cmd = new OleDbCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", idTarea);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<string> ObtenerUsuarios()
        {
            List<string> usuarios = new List<string>();

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    string sql = "SELECT DISTINCT Nombre FROM Usuarios";
                    using (OleDbCommand comando = new OleDbCommand(sql, conexion))
                    {
                        conexion.Open();
                        OleDbDataReader lector = comando.ExecuteReader();

                        while (lector.Read())
                        {
                            usuarios.Add(lector["Nombre"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
            }

            return usuarios;
        }
    }
}
