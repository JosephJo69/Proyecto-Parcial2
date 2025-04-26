using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Parcial_002_Ahora_es_personal.Models;
using Parcial_002_Ahora_es_personal.Services;
using Parcial_002_Ahora_es_personal.Utils;

namespace Parcial_002_Ahora_es_personal
{
    public partial class FormGestionarJugadores : Form
    {
        public FormGestionarJugadores()
        {
            InitializeComponent();
        }

        private void FormGestionarJugadores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotonvVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormGestionarJugadores)
        }

        private void BotonListarJugadores_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de DatabaseManager
                var dbManager = new DatabaseManager();

                // Crear una instancia de JugadorService
                var jugadorService = new JugadorService(dbManager);

                // Obtener la lista de jugadores desde la base de datos
                var jugadores = jugadorService.ObtenerTodos();

                // Asignar la lista de jugadores como fuente de datos del DataGridView
                GridListaJugadores.DataSource = jugadores;

                // Hacer visible el DataGridView si está oculto
                GridListaJugadores.Visible = true;

                BotonCerrarGrid.Visible = true;

                BotonRegistrarJugadore.Visible = false;

                BotonListarJugadores.Visible = false;

                BotonBuscarID.Visible = false;

                BotonActualizarJugador.Visible = false;

                BotonEliminarJugador.Visible = false;
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al listar jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonRegistrarJugadore_Click(object sender, EventArgs e)
        {
            FormRegistrarJugador formRegistrarJugador = new FormRegistrarJugador();
            formRegistrarJugador.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormGestionarJugadores)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonCerrarGrid_Click(object sender, EventArgs e)
        {
            GridListaJugadores.Visible = false;

            BotonRegistrarJugadore.Visible = true;

            BotonListarJugadores.Visible = true;

            BotonBuscarID.Visible = true;

            BotonActualizarJugador.Visible = true;

            BotonEliminarJugador.Visible = true;

            BotonCerrarGrid.Visible = false;
        }

        private void BotonBuscarID_Click(object sender, EventArgs e)
        {
            BotonRegistrarJugadore.Visible = false;

            BotonListarJugadores.Visible = false;

            BotonBuscarID.Visible = false;

            BotonActualizarJugador.Visible = false;

            BotonEliminarJugador.Visible = false;

            LabelIngreseID.Visible = true;

            TBID.Visible = true;

            BotonBuscar001.Visible = true;
        }

        private void BotonBuscar001_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID ingresado sea un número válido
                if (int.TryParse(TBID.Text, out int id))
                {
                    // Crear una instancia de DatabaseManager
                    var dbManager = new DatabaseManager();

                    // Crear una instancia de JugadorService
                    var jugadorService = new JugadorService(dbManager);

                    // Obtener el jugador por ID
                    var jugador = jugadorService.ObtenerPorId(id);

                    if (jugador != null)
                    {
                        // Mostrar el jugador en el DataGridView
                        GridListaJugadores.DataSource = new List<Jugador> { jugador };


                        GridListaJugadores.Visible = true;

                        BotonCerrarGrid.Visible = true;

                        LabelIngreseID.Visible = false;
                        TBID.Visible = false;
                        BotonBuscar001.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un jugador con el ID ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al buscar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonActualizarJugador_Click(object sender, EventArgs e)
        {
            FormActualizarJugador formActualizarJugador = new FormActualizarJugador();
            formActualizarJugador.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormGestionarJugadores)
        }

        private void BotonEliminarJugador_Click(object sender, EventArgs e)
        {
            FormEliminarJugador formEliminarJugador = new FormEliminarJugador();
            formEliminarJugador.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormGestionarJugadores)
        }
    }
}
