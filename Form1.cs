namespace Parcial_002_Ahora_es_personal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotonGestionarJugadores_Click(object sender, EventArgs e)
        {
            FormGestionarJugadores formGestionarJugadores = new FormGestionarJugadores();
            formGestionarJugadores.Show(); // Muestra el formulario de manera no modal

            this.Hide(); // Oculta el formulario actual (Form1)
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotonGestionarBloques_Click(object sender, EventArgs e)
        {
            FormGestionarBloques formGestionarBloques = new FormGestionarBloques();
            formGestionarBloques.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (Form1)
        }

        private void BotonGestionarInventario_Click(object sender, EventArgs e)
        {
            FormGestionarInventario formGestionarInventario = new FormGestionarInventario();
            formGestionarInventario.Show(); // Muestra el formulario de manera no modal
            this.Hide(); // Oculta el formulario actual (Form1)
        }
    }
}
