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
    public partial class FormGestionarInventario : Form
    {
        public FormGestionarInventario()
        {
            InitializeComponent();
        }

        private void BotonvVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BotonListarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia de DatabaseManager
                var dbManager = new DatabaseManager();

                // Crear una instancia de InventarioService
                var inventarioService = new InventarioService(dbManager);

                // Obtener todos los elementos del inventario
                var inventario = inventarioService.ObtenerTodos();

                // Asignar los datos al DataGridView
                GridInventario.DataSource = inventario;

                // Hacer visible el DataGridView y el botón Cerrar Grid
                GridInventario.Visible = true;
                BotonCerrarGridBloques.Visible = true;

                // Ocultar todos los botones excepto el botón Volver
                BotonAgregaraInventario.Visible = false;
                BotonListarInventario.Visible = false;
                BotonInventarioJugador.Visible = false;
                BotonActualizarInventario.Visible = false;
                BotonEliminarInventario.Visible = false;
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al listar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCerrarGridBloques_Click(object sender, EventArgs e)
        {
            GridInventario.Visible = false;
            BotonCerrarGridBloques.Visible = false;
            BotonAgregaraInventario.Visible = true;
            BotonListarInventario.Visible = true;
            BotonInventarioJugador.Visible = true;
            BotonActualizarInventario.Visible = true;
            BotonEliminarInventario.Visible = true;

        }

        private void BotonInventarioJugador_Click(object sender, EventArgs e)
        {

            BotonAgregaraInventario.Visible = false;
            BotonListarInventario.Visible = false;
            BotonInventarioJugador.Visible = false;
            BotonActualizarInventario.Visible = false;
            BotonEliminarInventario.Visible = false;
            TB_Id_Jugador.Visible = true;
            LBIDDeljugador.Visible = true;
            BuscarInventarioJ.Visible = true;
        }

        private void BuscarInventarioJ_Click(object sender, EventArgs e)
        {
            
        }
    }
}
