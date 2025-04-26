namespace Parcial_002_Ahora_es_personal
{
    partial class FormGestionarInventario
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
            BotonAgregaraInventario = new Button();
            BotonListarInventario = new Button();
            BotonInventarioJugador = new Button();
            BotonActualizarInventario = new Button();
            BotonEliminarInventario = new Button();
            BotonvVolver = new Button();
            GridInventario = new DataGridView();
            BotonCerrarGridBloques = new Button();
            TB_Id_Jugador = new TextBox();
            BuscarInventarioJ = new Button();
            LBIDDeljugador = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridInventario).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Gestionar_Inventario;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotonAgregaraInventario
            // 
            BotonAgregaraInventario.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonAgregaraInventario.Location = new Point(93, 157);
            BotonAgregaraInventario.Name = "BotonAgregaraInventario";
            BotonAgregaraInventario.Size = new Size(161, 48);
            BotonAgregaraInventario.TabIndex = 2;
            BotonAgregaraInventario.Text = "Agregar Bloque al Inventario";
            BotonAgregaraInventario.UseVisualStyleBackColor = true;
            // 
            // BotonListarInventario
            // 
            BotonListarInventario.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonListarInventario.Location = new Point(316, 157);
            BotonListarInventario.Name = "BotonListarInventario";
            BotonListarInventario.Size = new Size(161, 48);
            BotonListarInventario.TabIndex = 3;
            BotonListarInventario.Text = "Listar Inventario";
            BotonListarInventario.UseVisualStyleBackColor = true;
            BotonListarInventario.Click += BotonListarInventario_Click;
            // 
            // BotonInventarioJugador
            // 
            BotonInventarioJugador.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonInventarioJugador.Location = new Point(543, 157);
            BotonInventarioJugador.Name = "BotonInventarioJugador";
            BotonInventarioJugador.Size = new Size(161, 48);
            BotonInventarioJugador.TabIndex = 4;
            BotonInventarioJugador.Text = "Ver Inventario de un Jugador";
            BotonInventarioJugador.UseVisualStyleBackColor = true;
            BotonInventarioJugador.Click += BotonInventarioJugador_Click;
            // 
            // BotonActualizarInventario
            // 
            BotonActualizarInventario.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonActualizarInventario.Location = new Point(208, 231);
            BotonActualizarInventario.Name = "BotonActualizarInventario";
            BotonActualizarInventario.Size = new Size(161, 57);
            BotonActualizarInventario.TabIndex = 5;
            BotonActualizarInventario.Text = "Actualizar Cantidad en Inventario";
            BotonActualizarInventario.UseVisualStyleBackColor = true;
            // 
            // BotonEliminarInventario
            // 
            BotonEliminarInventario.BackColor = Color.IndianRed;
            BotonEliminarInventario.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonEliminarInventario.Location = new Point(440, 231);
            BotonEliminarInventario.Name = "BotonEliminarInventario";
            BotonEliminarInventario.Size = new Size(161, 48);
            BotonEliminarInventario.TabIndex = 6;
            BotonEliminarInventario.Text = "Eliminar Elemento de Inventario";
            BotonEliminarInventario.UseVisualStyleBackColor = false;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(42, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 9;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // GridInventario
            // 
            GridInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInventario.Location = new Point(42, 82);
            GridInventario.Name = "GridInventario";
            GridInventario.Size = new Size(711, 262);
            GridInventario.TabIndex = 10;
            GridInventario.Visible = false;
            // 
            // BotonCerrarGridBloques
            // 
            BotonCerrarGridBloques.BackColor = Color.Red;
            BotonCerrarGridBloques.Location = new Point(354, 344);
            BotonCerrarGridBloques.Name = "BotonCerrarGridBloques";
            BotonCerrarGridBloques.Size = new Size(75, 23);
            BotonCerrarGridBloques.TabIndex = 18;
            BotonCerrarGridBloques.Text = "X";
            BotonCerrarGridBloques.UseVisualStyleBackColor = false;
            BotonCerrarGridBloques.Visible = false;
            BotonCerrarGridBloques.Click += BotonCerrarGridBloques_Click;
            // 
            // TB_Id_Jugador
            // 
            TB_Id_Jugador.Location = new Point(343, 148);
            TB_Id_Jugador.Name = "TB_Id_Jugador";
            TB_Id_Jugador.Size = new Size(100, 23);
            TB_Id_Jugador.TabIndex = 19;
            TB_Id_Jugador.Visible = false;
            // 
            // BuscarInventarioJ
            // 
            BuscarInventarioJ.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuscarInventarioJ.Location = new Point(316, 177);
            BuscarInventarioJ.Name = "BuscarInventarioJ";
            BuscarInventarioJ.Size = new Size(161, 48);
            BuscarInventarioJ.TabIndex = 20;
            BuscarInventarioJ.Text = "Buscar";
            BuscarInventarioJ.UseVisualStyleBackColor = true;
            BuscarInventarioJ.Visible = false;
            BuscarInventarioJ.Click += BuscarInventarioJ_Click;
            // 
            // LBIDDeljugador
            // 
            LBIDDeljugador.AutoSize = true;
            LBIDDeljugador.BackColor = Color.Transparent;
            LBIDDeljugador.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBIDDeljugador.ForeColor = SystemColors.Control;
            LBIDDeljugador.Location = new Point(325, 120);
            LBIDDeljugador.Name = "LBIDDeljugador";
            LBIDDeljugador.Size = new Size(143, 25);
            LBIDDeljugador.TabIndex = 21;
            LBIDDeljugador.Text = "ID del Jugador";
            LBIDDeljugador.Visible = false;
            // 
            // FormGestionarInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(LBIDDeljugador);
            Controls.Add(BuscarInventarioJ);
            Controls.Add(TB_Id_Jugador);
            Controls.Add(BotonCerrarGridBloques);
            Controls.Add(BotonvVolver);
            Controls.Add(BotonEliminarInventario);
            Controls.Add(BotonActualizarInventario);
            Controls.Add(BotonInventarioJugador);
            Controls.Add(BotonListarInventario);
            Controls.Add(BotonAgregaraInventario);
            Controls.Add(pictureBox1);
            Controls.Add(GridInventario);
            Name = "FormGestionarInventario";
            Text = "FormGestionarInventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BotonAgregaraInventario;
        private Button BotonListarInventario;
        private Button BotonInventarioJugador;
        private Button BotonActualizarInventario;
        private Button BotonEliminarInventario;
        private Button BotonvVolver;
        private DataGridView GridInventario;
        private Button BotonCerrarGridBloques;
        private TextBox TB_Id_Jugador;
        private Button BuscarInventarioJ;
        private Label LBIDDeljugador;
    }
}