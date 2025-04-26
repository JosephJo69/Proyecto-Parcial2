using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_002_Ahora_es_personal.Models;
using Parcial_002_Ahora_es_personal.Services;
using Parcial_002_Ahora_es_personal.Utils;

namespace Parcial_002_Ahora_es_personal
{
    public partial class FormRegistrarJugador : Form
    {
        private Jugador jugador; // Instancia de Jugador

        public FormRegistrarJugador()
        {
            InitializeComponent();
            jugador = new Jugador(); // Inicializar la instancia de Jugador
        }

        private void FormRegistrarJugador_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            jugador.Nombre = TBNombre.Text; // Asignar el texto del TextBox a la propiedad Nombre del objeto jugador
        }

        private void BotonvVolver_Click(object sender, EventArgs e)
        {
            FormGestionarJugadores formGestionarJugadores = new FormGestionarJugadores();
            formGestionarJugadores.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormRegistrarJugador)
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(TBNivel.Text, out int nivel))
            {
                jugador.Nivel = nivel; // Asignar el valor convertido a la propiedad Nivel
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido para el nivel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBNivel.Clear(); // Limpiar el TextBox si el valor no es válido
            }
        }

        private void BotonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Configurar la fecha de creación del jugador
                jugador.FechaCreacion = DateTime.Now;

                // Crear una instancia de DatabaseManager
                var dbManager = new DatabaseManager();

                // Crear una instancia de JugadorService
                var jugadorService = new JugadorService(dbManager);

                // Llamar al método Crear para registrar el jugador en la base de datos
                jugadorService.Crear(jugador);

                // Mostrar un mensaje de éxito
                MessageBox.Show("¡Jugador registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos del formulario
                TBNombre.Clear();
                TBNivel.Clear();

                LabelJugadorRegistrado.Show();
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al registrar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
