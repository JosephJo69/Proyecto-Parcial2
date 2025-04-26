using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial_002_Ahora_es_personal.Services;
using Parcial_002_Ahora_es_personal.Utils;

namespace Parcial_002_Ahora_es_personal
{
    public partial class FormEliminarJugador : Form
    {
        public FormEliminarJugador()
        {
            InitializeComponent();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID ingresado sea un número válido
                if (int.TryParse(TB_ID_Eliminar.Text, out int id))
                {
                    // Crear una instancia de DatabaseManager
                    var dbManager = new DatabaseManager();

                    // Crear una instancia de JugadorService
                    var jugadorService = new JugadorService(dbManager);

                    // Llamar al método Eliminar para eliminar el jugador de la base de datos
                    jugadorService.Eliminar(id);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("¡Jugador eliminado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el campo de texto
                    TB_ID_Eliminar.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al eliminar el jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonvVolver_Click(object sender, EventArgs e)
        {
            FormGestionarJugadores formGestionarJugadores = new FormGestionarJugadores();
            formGestionarJugadores.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormEliminarJugador)
        }
    }
}
