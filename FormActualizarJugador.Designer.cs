namespace Parcial_002_Ahora_es_personal
{
    partial class FormActualizarJugador
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
            BotonActualizarJugador = new Button();
            LB_UPD_Nivel = new Label();
            TB_UPD_Nivel = new TextBox();
            LB_UPD_Nombre = new Label();
            TB_UPD_Nombre = new TextBox();
            LB_UPD_ID = new Label();
            TB_UPD_Jugador = new TextBox();
            BotonvVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Actualizar_Jugador;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BotonActualizarJugador
            // 
            BotonActualizarJugador.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonActualizarJugador.Location = new Point(46, 318);
            BotonActualizarJugador.Name = "BotonActualizarJugador";
            BotonActualizarJugador.Size = new Size(212, 48);
            BotonActualizarJugador.TabIndex = 14;
            BotonActualizarJugador.Text = "Actualizar";
            BotonActualizarJugador.UseVisualStyleBackColor = true;
            BotonActualizarJugador.Click += BotonActualizarJugador_Click;
            // 
            // LB_UPD_Nivel
            // 
            LB_UPD_Nivel.AutoSize = true;
            LB_UPD_Nivel.BackColor = Color.Transparent;
            LB_UPD_Nivel.ForeColor = SystemColors.ButtonHighlight;
            LB_UPD_Nivel.Location = new Point(80, 274);
            LB_UPD_Nivel.Name = "LB_UPD_Nivel";
            LB_UPD_Nivel.Size = new Size(34, 15);
            LB_UPD_Nivel.TabIndex = 13;
            LB_UPD_Nivel.Text = "Nivel";
            // 
            // TB_UPD_Nivel
            // 
            TB_UPD_Nivel.Location = new Point(157, 271);
            TB_UPD_Nivel.Name = "TB_UPD_Nivel";
            TB_UPD_Nivel.Size = new Size(585, 23);
            TB_UPD_Nivel.TabIndex = 12;
            // 
            // LB_UPD_Nombre
            // 
            LB_UPD_Nombre.AutoSize = true;
            LB_UPD_Nombre.BackColor = Color.Transparent;
            LB_UPD_Nombre.ForeColor = SystemColors.ButtonHighlight;
            LB_UPD_Nombre.Location = new Point(80, 192);
            LB_UPD_Nombre.Name = "LB_UPD_Nombre";
            LB_UPD_Nombre.Size = new Size(51, 15);
            LB_UPD_Nombre.TabIndex = 11;
            LB_UPD_Nombre.Text = "Nombre";
            // 
            // TB_UPD_Nombre
            // 
            TB_UPD_Nombre.Location = new Point(157, 189);
            TB_UPD_Nombre.Name = "TB_UPD_Nombre";
            TB_UPD_Nombre.Size = new Size(585, 23);
            TB_UPD_Nombre.TabIndex = 10;
            // 
            // LB_UPD_ID
            // 
            LB_UPD_ID.AutoSize = true;
            LB_UPD_ID.BackColor = Color.Transparent;
            LB_UPD_ID.ForeColor = SystemColors.ButtonHighlight;
            LB_UPD_ID.Location = new Point(80, 115);
            LB_UPD_ID.Name = "LB_UPD_ID";
            LB_UPD_ID.Size = new Size(18, 15);
            LB_UPD_ID.TabIndex = 16;
            LB_UPD_ID.Text = "ID";
            // 
            // TB_UPD_Jugador
            // 
            TB_UPD_Jugador.Location = new Point(157, 112);
            TB_UPD_Jugador.Name = "TB_UPD_Jugador";
            TB_UPD_Jugador.Size = new Size(585, 23);
            TB_UPD_Jugador.TabIndex = 15;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(46, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 17;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // FormActualizarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonvVolver);
            Controls.Add(LB_UPD_ID);
            Controls.Add(TB_UPD_Jugador);
            Controls.Add(BotonActualizarJugador);
            Controls.Add(LB_UPD_Nivel);
            Controls.Add(TB_UPD_Nivel);
            Controls.Add(LB_UPD_Nombre);
            Controls.Add(TB_UPD_Nombre);
            Controls.Add(pictureBox1);
            Name = "FormActualizarJugador";
            Text = "FormActualizarJugador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BotonActualizarJugador;
        private Label LB_UPD_Nivel;
        private TextBox TB_UPD_Nivel;
        private Label LB_UPD_Nombre;
        private TextBox TB_UPD_Nombre;
        private Label LB_UPD_ID;
        private TextBox TB_UPD_Jugador;
        private Button BotonvVolver;
    }
}