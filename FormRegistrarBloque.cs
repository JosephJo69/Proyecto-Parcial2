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
    public partial class FormRegistrarBloque : Form
    {
        public FormRegistrarBloque()
        {
            InitializeComponent();
        }

        private void BotonRegistrarBloque_Click(object sender, EventArgs e)
        {
            try
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
                    Nombre = TBNombreBloque.Text,
                    Tipo = TBTipo.Text,
                    Rareza = TBRareza.Text
                };

                // Llamar al método Crear para registrar el bloque en la base de datos
                bloqueService.Crear(bloque);

                // Mostrar un mensaje de éxito
                MessageBox.Show("¡Bloque registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos del formulario
                TBNombreBloque.Clear();
                TBTipo.Clear();
                TBRareza.Clear();
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al registrar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
