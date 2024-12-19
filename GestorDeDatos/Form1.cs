using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeDatos
{
    public partial class Form1 : Form
    {
        private string cadenaConexion = "Server=localhost;Database=GestionVehiculos;Uid=root;Pwd=PEntAKilL1;";
        private MySqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
            conexion = new MySqlConnection(cadenaConexion);

            // Probar la conexión al iniciar
            ProbarConexion();

            // Cargar los clientes en el DataGridView
            CargarClientes();
        }

        private void ProbarConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarClientes()
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM clientes";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos antes de insertar
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
                return;
            }

            try
            {
                conexion.Open();
                string query = "INSERT INTO clientes (nombre, telefono, email, direccion) VALUES (@nombre, @telefono, @email, @direccion)";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            // Refrescar la lista de clientes
            CargarClientes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDEliminar.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del cliente a eliminar.");
                return;
            }

            try
            {
                conexion.Open();
                string query = "DELETE FROM clientes WHERE id_cliente = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", int.Parse(txtIDEliminar.Text));

                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                    MessageBox.Show("Cliente eliminado correctamente.");
                else
                    MessageBox.Show("No se encontró un cliente con ese ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            CargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM clientes WHERE nombre LIKE @nombre";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", "%" + txtBuscarNombre.Text + "%");

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            // Evento opcional
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento opcional
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Evento opcional
        }
    }
}
