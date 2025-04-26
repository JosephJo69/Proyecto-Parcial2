namespace Parcial_002_Ahora_es_personal
{
    partial class FormRegistrarJugador
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
            TBNombre = new TextBox();
            LabelNombre = new Label();
            LabelNivel = new Label();
            TBNivel = new TextBox();
            BotonvVolver = new Button();
            BotonRegistrar = new Button();
            LabelJugadorRegistrado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Registrar_Jugador;
            pictureBox1.Location = new Point(49, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(711, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(147, 161);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(585, 23);
            TBNombre.TabIndex = 1;
            TBNombre.TextChanged += textBox1_TextChanged;
            // 
            // LabelNombre
            // 
            LabelNombre.AutoSize = true;
            LabelNombre.BackColor = Color.Transparent;
            LabelNombre.ForeColor = SystemColors.ButtonHighlight;
            LabelNombre.Location = new Point(70, 164);
            LabelNombre.Name = "LabelNombre";
            LabelNombre.Size = new Size(51, 15);
            LabelNombre.TabIndex = 2;
            LabelNombre.Text = "Nombre";
            LabelNombre.Click += label1_Click;
            // 
            // LabelNivel
            // 
            LabelNivel.AutoSize = true;
            LabelNivel.BackColor = Color.Transparent;
            LabelNivel.ForeColor = SystemColors.ButtonHighlight;
            LabelNivel.Location = new Point(70, 246);
            LabelNivel.Name = "LabelNivel";
            LabelNivel.Size = new Size(34, 15);
            LabelNivel.TabIndex = 4;
            LabelNivel.Text = "Nivel";
            // 
            // TBNivel
            // 
            TBNivel.Location = new Point(147, 243);
            TBNivel.Name = "TBNivel";
            TBNivel.Size = new Size(585, 23);
            TBNivel.TabIndex = 3;
            TBNivel.TextChanged += textBox1_TextChanged_1;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(49, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 8;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // BotonRegistrar
            // 
            BotonRegistrar.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonRegistrar.Location = new Point(49, 304);
            BotonRegistrar.Name = "BotonRegistrar";
            BotonRegistrar.Size = new Size(212, 48);
            BotonRegistrar.TabIndex = 9;
            BotonRegistrar.Text = "Registrar";
            BotonRegistrar.UseVisualStyleBackColor = true;
            BotonRegistrar.Click += BotonRegistrar_Click;
            // 
            // LabelJugadorRegistrado
            // 
            LabelJugadorRegistrado.BackColor = Color.Transparent;
            LabelJugadorRegistrado.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJugadorRegistrado.ForeColor = Color.Lime;
            LabelJugadorRegistrado.Location = new Point(512, 314);
            LabelJugadorRegistrado.Name = "LabelJugadorRegistrado";
            LabelJugadorRegistrado.Size = new Size(220, 23);
            LabelJugadorRegistrado.TabIndex = 10;
            LabelJugadorRegistrado.Text = "Jugador Registrado";
            LabelJugadorRegistrado.Visible = false;
            // 
            // FormRegistrarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelJugadorRegistrado);
            Controls.Add(BotonRegistrar);
            Controls.Add(BotonvVolver);
            Controls.Add(LabelNivel);
            Controls.Add(TBNivel);
            Controls.Add(LabelNombre);
            Controls.Add(TBNombre);
            Controls.Add(pictureBox1);
            Name = "FormRegistrarJugador";
            Text = "Registrar Jugador";
            Load += FormRegistrarJugador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TBNombre;
        private Label LabelNombre;
        private Label LabelNivel;
        private TextBox TBNivel;
        private Button BotonvVolver;
        private Button BotonRegistrar;
        private Label LabelJugadorRegistrado;
    }
}