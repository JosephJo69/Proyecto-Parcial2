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
    public partial class FormGestionarBloques : Form
    {
        public FormGestionarBloques()
        {
            InitializeComponent();
        }

        private void BotonvVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BotonListarBloques_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de DatabaseManager
                var dbManager = new DatabaseManager();

                // Crear una instancia de BloqueService
                var bloqueService = new BloqueService(dbManager);

                // Obtener la lista de bloques desde la base de datos
                var bloques = bloqueService.ObtenerTodos();

                // Asignar la lista de bloques como fuente de datos del DataGridView
                dataGridView1.DataSource = bloques;

                // Hacer visible el DataGridView
                dataGridView1.Visible = true;
                BotonCerrarGridBloques.Visible = true;

                // Ocultar todos los botones excepto el botón Volver
                BotonRegistrarBloque.Visible = false;
                BotonListarBloques.Visible = false;
                BotonBloquePorId.Visible = false;
                BotonBloquePorTipo.Visible = false;
                BotonBloquePorRareza.Visible = false;
                BotonActualizarBloque.Visible = false;
                BotonEliminarBloque.Visible = false;
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al listar bloques: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCerrarGrid_Click(object sender, EventArgs e)
        {
            // Ocultar el DataGridView
            dataGridView1.Visible = false;
            BotonCerrarGridBloques.Visible = false;

            // Hacer visibles los demás botones
            BotonRegistrarBloque.Visible = true;
            BotonListarBloques.Visible = true;
            BotonBloquePorId.Visible = true;
            BotonBloquePorTipo.Visible = true;
            BotonBloquePorRareza.Visible = true;
            BotonActualizarBloque.Visible = true;
            BotonEliminarBloque.Visible = true;
        }

        private void BotonBloquePorId_Click(object sender, EventArgs e)
        {
            // Ocultar todos los botones excepto el botón Volver
            BotonRegistrarBloque.Visible = false;
            BotonListarBloques.Visible = false;
            BotonBloquePorId.Visible = false;
            BotonBloquePorTipo.Visible = false;
            BotonBloquePorRareza.Visible = false;
            BotonActualizarBloque.Visible = false;
            BotonEliminarBloque.Visible = false;

            // Mostrar el botón de buscar por ID y el TextBox para el ID
            BotonBuscarIDBloque.Visible = true;
            TBIDBloque.Visible = true;
        }

        private void BotonBuscarIDBloque_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID ingresado sea un número válido
                if (int.TryParse(TBIDBloque.Text, out int id))
                {
                    // Crear una instancia de DatabaseManager
                    var dbManager = new DatabaseManager();

                    // Crear una instancia de BloqueService
                    var bloqueService = new BloqueService(dbManager);

                    // Obtener el bloque por ID
                    var bloque = bloqueService.ObtenerPorId(id);

                    if (bloque != null)
                    {
                        // Mostrar el bloque en el DataGridView
                        dataGridView1.DataSource = new List<object> { bloque };

                        // Hacer visible el DataGridView y el botón Cerrar Grid
                        dataGridView1.Visible = true;
                        BotonCerrarGridBloques.Visible = true;

                        // Ocultar el botón de buscar por ID y el TextBox
                        BotonBuscarIDBloque.Visible = false;
                        TBIDBloque.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un bloque con el ID ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Error al buscar el bloque: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonBloquePorTipo_Click(object sender, EventArgs e)
        {
            // Ocultar todos los botones excepto el botón Volver
            BotonRegistrarBloque.Visible = false;
            BotonListarBloques.Visible = false;
            BotonBloquePorId.Visible = false;
            BotonBloquePorTipo.Visible = false;
            BotonBloquePorRareza.Visible = false;
            BotonActualizarBloque.Visible = false;
            BotonEliminarBloque.Visible = false;

            // Mostrar el botón de buscar por tipo y el TextBox para el tipo
            BotonBuscarTipo.Visible = true;
            TBTipoBloque.Visible = true;
        }

        private void BotonBuscarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el tipo ingresado no esté vacío
                if (!string.IsNullOrWhiteSpace(TBTipoBloque.Text))
                {
                    // Crear una instancia de DatabaseManager
                    var dbManager = new DatabaseManager();

                    // Crear una instancia de BloqueService
                    var bloqueService = new BloqueService(dbManager);

                    // Obtener los bloques por tipo
                    var bloques = bloqueService.BuscarPorTipo(TBTipoBloque.Text);

                    if (bloques != null && bloques.Any())
                    {
                        // Mostrar los bloques en el DataGridView
                        dataGridView1.DataSource = bloques;

                        // Hacer visible el DataGridView y el botón Cerrar Grid
                        dataGridView1.Visible = true;
                        BotonCerrarGridBloques.Visible = true;

                        // Ocultar el botón de buscar por tipo y el TextBox
                        BotonBuscarTipo.Visible = false;
                        TBTipoBloque.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron bloques con el tipo ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un tipo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al buscar bloques por tipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormGestionarBloques_Load(object sender, EventArgs e)
        {

        }

        private void BotonBloquePorRareza_Click(object sender, EventArgs e)
        {
            // Ocultar todos los botones excepto el botón Volver
            BotonRegistrarBloque.Visible = false;
            BotonListarBloques.Visible = false;
            BotonBloquePorId.Visible = false;
            BotonBloquePorTipo.Visible = false;
            BotonBloquePorRareza.Visible = false;
            BotonActualizarBloque.Visible = false;
            BotonEliminarBloque.Visible = false;

            // Mostrar el botón de buscar por rareza y el TextBox para la rareza
            BotonBuscarRareza.Visible = true;
            TBRareza.Visible = true;
        }

        private void BotonBuscarRareza_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que la rareza ingresada no esté vacía
                if (!string.IsNullOrWhiteSpace(TBRareza.Text))
                {
                    // Crear una instancia de DatabaseManager
                    var dbManager = new DatabaseManager();

                    // Crear una instancia de BloqueService
                    var bloqueService = new BloqueService(dbManager);

                    // Obtener los bloques por rareza
                    var bloques = bloqueService.BuscarPorRareza(TBRareza.Text);

                    if (bloques != null && bloques.Any())
                    {
                        // Mostrar los bloques en el DataGridView
                        dataGridView1.DataSource = bloques;

                        // Hacer visible el DataGridView y el botón Cerrar Grid
                        dataGridView1.Visible = true;
                        BotonCerrarGridBloques.Visible = true;

                        // Ocultar el botón de buscar por rareza y el TextBox
                        BotonBuscarRareza.Visible = false;
                        TBRareza.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron bloques con la rareza ingresada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una rareza válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al buscar bloques por rareza: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonRegistrarBloque_Click(object sender, EventArgs e)
        {
            FormRegistrarBloque formRegistrarBloque = new FormRegistrarBloque();
            formRegistrarBloque.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormGestionarBloques)
        }

        private void BotonActualizarBloque_Click(object sender, EventArgs e)
        {
            FormActualizarBloque formActualizarBloque = new FormActualizarBloque();
            formActualizarBloque.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormGestionarBloques)
        }

        private void BotonEliminarBloque_Click(object sender, EventArgs e)
        {
            FormEliminarBloque formEliminarBloque = new FormEliminarBloque();
            formEliminarBloque.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (FormGestionarBloques)
        }
    }
}
