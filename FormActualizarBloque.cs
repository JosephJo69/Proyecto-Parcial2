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
    public partial class FormActualizarBloque : Form
    {
        public FormActualizarBloque()
        {
            InitializeComponent();
        }

        private void BotonActualizarBloque_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID ingresado sea un número válido
                if (int.TryParse(TB_ID_Bloque.Text, out int id))
                {
                    // Validar que los campos no estén vacíos
                    if (string.IsNullOrWhiteSpace(TBNombreBloque.Text) ||
                        string.IsNullOrWhiteSpace(TBTipo.Text) ||
                        string.IsNullOrWhiteSpace(TBRareza.Text))
                    {
                        MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear una instancia de DatabaseManager
                    var dbManager = new DatabaseManager();

                    // Crear una instancia de BloqueService
                    var bloqueService = new BloqueService(dbManager);

                    // Crear un objeto Bloque con los datos ingresados
                    var bloque = new Bloque
                    {
                        Id = id,
                        Nombre = TBNombreBloque.Text,
                        Tipo = TBTipo.Text,
                        Rareza = TBRareza.Text
                    };

                    // Llamar al método Actualizar para actualizar el bloque en la base de datos
                    bloqueService.Actualizar(bloque);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("¡Bloque actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos del formulario
                    TB_ID_Bloque.Clear();
                    TBNombreBloque.Clear();
                    TBTipo.Clear();
                    TBRareza.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al actualizar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
