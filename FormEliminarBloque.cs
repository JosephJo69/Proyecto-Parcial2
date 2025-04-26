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
    public partial class FormEliminarBloque : Form
    {
        public FormEliminarBloque()
        {
            InitializeComponent();
        }

        private void BotonEliminarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID ingresado sea un número válido
                if (int.TryParse(TB_ID_Eliminar_Bloque.Text, out int id))
                {
                    // Crear una instancia de DatabaseManager
                    var dbManager = new DatabaseManager();

                    // Crear una instancia de BloqueService
                    var bloqueService = new BloqueService(dbManager);

                    // Llamar al método Eliminar para eliminar el bloque de la base de datos
                    bloqueService.Eliminar(id);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("¡Bloque eliminado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el campo de texto
                    TB_ID_Eliminar_Bloque.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al eliminar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonvVolver_Click(object sender, EventArgs e)
        {
            FormGestionarBloques formGestionarBloques = new FormGestionarBloques();
            formGestionarBloques.Show();
            this.Hide();
        }
    }
}
