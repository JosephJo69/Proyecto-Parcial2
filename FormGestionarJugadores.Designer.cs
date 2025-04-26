namespace Parcial_002_Ahora_es_personal
{
    partial class FormGestionarJugadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            BotonRegistrarJugadore = new Button();
            BotonListarJugadores = new Button();
            BotonBuscarID = new Button();
            BotonActualizarJugador = new Button();
            BotonEliminarJugador = new Button();
            BotonvVolver = new Button();
            GridListaJugadores = new DataGridView();
            BotonCerrarGrid = new Button();
            LabelIngreseID = new Label();
            TBID = new TextBox();
            BotonBuscar001 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListaJugadores).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Gestionar_Jugadores;
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(711, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotonRegistrarJugadore
            // 
            BotonRegistrarJugadore.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonRegistrarJugadore.Location = new Point(105, 164);
            BotonRegistrarJugadore.Name = "BotonRegistrarJugadore";
            BotonRegistrarJugadore.Size = new Size(161, 48);
            BotonRegistrarJugadore.TabIndex = 2;
            BotonRegistrarJugadore.Text = "Registrar Jugador";
            BotonRegistrarJugadore.UseVisualStyleBackColor = true;
            BotonRegistrarJugadore.Click += BotonRegistrarJugadore_Click;
            // 
            // BotonListarJugadores
            // 
            BotonListarJugadores.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonListarJugadores.Location = new Point(315, 164);
            BotonListarJugadores.Name = "BotonListarJugadores";
            BotonListarJugadores.Size = new Size(161, 48);
            BotonListarJugadores.TabIndex = 3;
            BotonListarJugadores.Text = "Listar Jugadores";
            BotonListarJugadores.UseVisualStyleBackColor = true;
            BotonListarJugadores.Click += BotonListarJugadores_Click;
            // 
            // BotonBuscarID
            // 
            BotonBuscarID.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarID.Location = new Point(533, 164);
            BotonBuscarID.Name = "BotonBuscarID";
            BotonBuscarID.Size = new Size(161, 48);
            BotonBuscarID.TabIndex = 4;
            BotonBuscarID.Text = "Buscar ID de Jugador";
            BotonBuscarID.UseVisualStyleBackColor = true;
            BotonBuscarID.Click += BotonBuscarID_Click;
            // 
            // BotonActualizarJugador
            // 
            BotonActualizarJugador.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonActualizarJugador.Location = new Point(207, 242);
            BotonActualizarJugador.Name = "BotonActualizarJugador";
            BotonActualizarJugador.Size = new Size(161, 48);
            BotonActualizarJugador.TabIndex = 5;
            BotonActualizarJugador.Text = "Actualizar Jugador";
            BotonActualizarJugador.UseVisualStyleBackColor = true;
            BotonActualizarJugador.Click += BotonActualizarJugador_Click;
            // 
            // BotonEliminarJugador
            // 
            BotonEliminarJugador.BackColor = Color.IndianRed;
            BotonEliminarJugador.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonEliminarJugador.Location = new Point(425, 242);
            BotonEliminarJugador.Name = "BotonEliminarJugador";
            BotonEliminarJugador.Size = new Size(161, 48);
            BotonEliminarJugador.TabIndex = 6;
            BotonEliminarJugador.Text = "Eliminar Jugador";
            BotonEliminarJugador.UseVisualStyleBackColor = false;
            BotonEliminarJugador.Click += BotonEliminarJugador_Click;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(45, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 7;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // GridListaJugadores
            // 
            GridListaJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListaJugadores.Location = new Point(45, 108);
            GridListaJugadores.Name = "GridListaJugadores";
            GridListaJugadores.Size = new Size(711, 240);
            GridListaJugadores.TabIndex = 8;
            GridListaJugadores.Visible = false;
            GridListaJugadores.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BotonCerrarGrid
            // 
            BotonCerrarGrid.BackColor = Color.Red;
            BotonCerrarGrid.Location = new Point(362, 348);
            BotonCerrarGrid.Name = "BotonCerrarGrid";
            BotonCerrarGrid.Size = new Size(75, 23);
            BotonCerrarGrid.TabIndex = 9;
            BotonCerrarGrid.Text = "X";
            BotonCerrarGrid.UseVisualStyleBackColor = false;
            BotonCerrarGrid.Visible = false;
            BotonCerrarGrid.Click += BotonCerrarGrid_Click;
            // 
            // LabelIngreseID
            // 
            LabelIngreseID.BackColor = Color.Transparent;
            LabelIngreseID.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelIngreseID.ForeColor = SystemColors.Control;
            LabelIngreseID.Location = new Point(45, 215);
            LabelIngreseID.Name = "LabelIngreseID";
            LabelIngreseID.Size = new Size(130, 23);
            LabelIngreseID.TabIndex = 11;
            LabelIngreseID.Text = "Ingrese ID";
            LabelIngreseID.Visible = false;
            // 
            // TBID
            // 
            TBID.Location = new Point(207, 213);
            TBID.Name = "TBID";
            TBID.Size = new Size(100, 23);
            TBID.TabIndex = 12;
            TBID.Visible = false;
            // 
            // BotonBuscar001
            // 
            BotonBuscar001.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscar001.Location = new Point(45, 257);
            BotonBuscar001.Name = "BotonBuscar001";
            BotonBuscar001.Size = new Size(161, 48);
            BotonBuscar001.TabIndex = 13;
            BotonBuscar001.Text = "Buscar";
            BotonBuscar001.UseVisualStyleBackColor = true;
            BotonBuscar001.Visible = false;
            BotonBuscar001.Click += BotonBuscar001_Click;
            // 
            // FormGestionarJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonBuscar001);
            Controls.Add(TBID);
            Controls.Add(LabelIngreseID);
            Controls.Add(BotonCerrarGrid);
            Controls.Add(BotonvVolver);
            Controls.Add(BotonEliminarJugador);
            Controls.Add(BotonActualizarJugador);
            Controls.Add(BotonBuscarID);
            Controls.Add(BotonListarJugadores);
            Controls.Add(BotonRegistrarJugadore);
            Controls.Add(pictureBox1);
            Controls.Add(GridListaJugadores);
            Name = "FormGestionarJugadores";
            Text = "FormGestionarJugadores";
            Load += FormGestionarJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListaJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BotonRegistrarJugadore;
        private Button BotonListarJugadores;
        private Button BotonBuscarID;
        private Button BotonActualizarJugador;
        private Button BotonEliminarJugador;
        private Button BotonvVolver;
        private DataGridView GridListaJugadores;
        private Button BotonCerrarGrid;
        private Label LabelIngreseID;
        private TextBox TBID;
        private Button BotonBuscar001;
    }
}