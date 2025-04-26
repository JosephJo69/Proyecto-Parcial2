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
    public partial class FormActualizarJugador : Form
    {
        public FormActualizarJugador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotonActualizarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID ingresado sea un número válido
                if (int.TryParse(TB_UPD_Jugador.Text, out int id))
                {
                    // Validar que el nivel ingresado sea un número válido
                    if (int.TryParse(TB_UPD_Nivel.Text, out int nivel))
                    {
                        // Crear una instancia de DatabaseManager
                        var dbManager = new DatabaseManager();

                        // Crear una instancia de JugadorService
                        var jugadorService = new JugadorService(dbManager);

                        // Crear un objeto Jugador con los datos ingresados
                        var jugador = new Jugador
                        {
                            Id = id,
                            Nombre = TB_UPD_Nombre.Text,
                            Nivel = nivel
                        };

                        // Llamar al método Actualizar para actualizar el jugador en la base de datos
                        jugadorService.Actualizar(jugador);

                        // Mostrar un mensaje de éxito
                        MessageBox.Show("¡Jugador actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos del formulario
                        TB_UPD_Jugador.Clear();
                        TB_UPD_Nombre.Clear();
                        TB_UPD_Nivel.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingresa un nivel válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Error al actualizar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonvVolver_Click(object sender, EventArgs e)
        {
            FormGestionarJugadores formGestionarJugadores = new FormGestionarJugadores();
            formGestionarJugadores.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormActualizarJugador)
        }
    }
}
