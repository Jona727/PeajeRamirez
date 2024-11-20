using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace PeajeRamirez
{
    public partial class Form1 : Form
    {

        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=;database=registrovehicular";
            connection = new MySqlConnection(connectionString);
            dataGridView1.Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadData();


        }

        //CARGAR REGISTROS DE LA BASE DE DATOS
        private void LoadData()
        {
            string query = "SELECT * FROM vehiculos";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
                connection.Close();
            }
            dataGridView1.Visible = true;
        }

        //INGRESO DE UN NUEVO REGISTRO
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //verificar que no haya campos vacios para ingresar un nuevo vehiculo

            if (string.IsNullOrWhiteSpace(txtbMarca.Text) ||
                string.IsNullOrWhiteSpace(txtbModelo.Text) ||
                string.IsNullOrWhiteSpace(txtbPersonas.Text) ||
                string.IsNullOrWhiteSpace(txtbCarril.Text) ||
                string.IsNullOrWhiteSpace(txtbPatente.Text))
            {
                MessageBox.Show("Campos incompletos. Por favor verifique");
                return;

            }

            //Ingresar nuevo vehiculo
            string query = "INSERT INTO vehiculos (marca, modelo, patente, cantidadPersonas, carril) VALUES (@marca, @modelo, @patente, @cantidadPersonas, @carril)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@marca", txtbMarca.Text);
            command.Parameters.AddWithValue("@modelo", txtbModelo.Text);
            command.Parameters.AddWithValue("@patente", txtbPatente.Text);
            command.Parameters.AddWithValue("@cantidadPersonas", int.Parse(txtbPersonas.Text));
            command.Parameters.AddWithValue("@carril", txtbCarril.Text);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            LoadData();
            dataGridView1.Enabled = true;
            dataGridView1.Visible = true;

            //Limpiamos los campos cada vez que iniciamos una nueva carga
            txtbBuscar.Clear();
            txtbCarril.Clear();
            txtbMarca.Clear();
            txtbPatente.Clear();
            txtbPersonas.Clear();
            txtbModelo.Clear();
        }

        //Busqueda de un registro mediante marca o patente
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vehiculos WHERE patente LIKE @Buscar OR marca LIKE @buscar";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Buscar", "%" + txtbBuscar.Text + "%");
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            connection.Close();


            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Vehículo no encontrado. Intente nuevamente. ");    //No existe el registro buscado

            }
            else
            {
                dataGridView1.DataSource = dataTable; //mostramos el registro buscado en la tabla
                btnBuscar.Enabled = false;
                btnBuscar.Visible = false; //deshabilitamos el boton buscar
                btnVolver.Visible = true;
                btnVolver.Enabled = true; // habilitamos el boton volver
            }
        }

        //Cargamos los campos con los registros de la celda seleccionada en el DataGrid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtbMarca.Text = row.Cells["marca"].Value.ToString();
                txtbModelo.Text = row.Cells["modelo"].Value.ToString();
                txtbPatente.Text = row.Cells["patente"].Value.ToString();
                txtbMarca.Text = row.Cells["marca"].Value.ToString();
                txtbPersonas.Text = row.Cells["cantidadPersonas"].Value.ToString();
                txtbCarril.Text = row.Cells["carril"].Value.ToString();

            }
        }

        //Actualizamos un registro ya cargado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea modificar este registro?.", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //validamos que los datos sean correctos y completos
                if
                    (string.IsNullOrWhiteSpace(txtbMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtbModelo.Text) ||
                    string.IsNullOrWhiteSpace(txtbPersonas.Text) ||
                    string.IsNullOrWhiteSpace(txtbCarril.Text) ||
                    string.IsNullOrWhiteSpace(txtbPatente.Text))
                {
                    MessageBox.Show("Campos incompletos. Por favor verifique");
                    return;
                }

                //Verificamos que haya una celda seleccionada
                if (dataGridView1.SelectedCells.Count > 0)

                {   //obtenemos el Id del registro seleccionado
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    int selectedRowId = (int)dataGridView1.Rows[selectedRowIndex].Cells["id"].Value;


                    //actualizamos tambien el registro en la base de datos
                    string query = "UPDATE vehiculos SET marca = @marca, modelo = @modelo, patente = @patente, cantidadPersonas = @cantidadPersonas, carril =@carril WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@marca", txtbMarca.Text);
                    command.Parameters.AddWithValue("@modelo", txtbModelo.Text);
                    command.Parameters.AddWithValue("@patente", txtbPatente.Text);
                    command.Parameters.AddWithValue("@cantidadPersonas", int.Parse(txtbPersonas.Text));
                    command.Parameters.AddWithValue("@carril", txtbCarril.Text);
                    command.Parameters.AddWithValue("id", selectedRowId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    LoadData();

                    //Limpiamos los campos cada vez que iniciamos una nueva carga
                    txtbBuscar.Clear();
                    txtbCarril.Clear();
                    txtbMarca.Clear();
                    txtbPatente.Clear();
                    txtbPersonas.Clear();
                    txtbModelo.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro para actualizar.");
                }
            }
        }

        //Boton Volver (Muestra grilla completa nuevamente luego de una busqueda)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            txtbBuscar.Clear();
            dataGridView1.Visible = false;
            btnVolver.Enabled = false;
            btnVolver.Visible = false;
            btnBuscar.Enabled = true;
            btnBuscar.Visible = true;

            LoadData();
            return;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dateTimeLabel.Text = DateTime.Now.ToString("dd/M/yyyy HH:mm:ss");
        }

        
    }
}
