namespace Parcial_002_Ahora_es_personal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            BotonGestionarJugadores = new Button();
            BotonGestionarBloques = new Button();
            BotonGestionarInventario = new Button();
            BotonSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Minecraft_Manager;
            pictureBox1.Location = new Point(90, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(625, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotonGestionarJugadores
            // 
            BotonGestionarJugadores.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonGestionarJugadores.Location = new Point(131, 201);
            BotonGestionarJugadores.Name = "BotonGestionarJugadores";
            BotonGestionarJugadores.Size = new Size(161, 48);
            BotonGestionarJugadores.TabIndex = 1;
            BotonGestionarJugadores.Text = "Gestionar Jugadores";
            BotonGestionarJugadores.UseVisualStyleBackColor = true;
            BotonGestionarJugadores.Click += BotonGestionarJugadores_Click;
            // 
            // BotonGestionarBloques
            // 
            BotonGestionarBloques.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonGestionarBloques.Location = new Point(327, 200);
            BotonGestionarBloques.Name = "BotonGestionarBloques";
            BotonGestionarBloques.Size = new Size(161, 48);
            BotonGestionarBloques.TabIndex = 2;
            BotonGestionarBloques.Text = "Gestionar Bloques";
            BotonGestionarBloques.UseVisualStyleBackColor = true;
            BotonGestionarBloques.Click += BotonGestionarBloques_Click;
            // 
            // BotonGestionarInventario
            // 
            BotonGestionarInventario.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonGestionarInventario.Location = new Point(525, 201);
            BotonGestionarInventario.Name = "BotonGestionarInventario";
            BotonGestionarInventario.Size = new Size(161, 48);
            BotonGestionarInventario.TabIndex = 3;
            BotonGestionarInventario.Text = "Gestionar Inventario";
            BotonGestionarInventario.UseVisualStyleBackColor = true;
            BotonGestionarInventario.Click += BotonGestionarInventario_Click;
            // 
            // BotonSalir
            // 
            BotonSalir.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonSalir.Location = new Point(90, 355);
            BotonSalir.Name = "BotonSalir";
            BotonSalir.Size = new Size(625, 48);
            BotonSalir.TabIndex = 4;
            BotonSalir.Text = "Salir";
            BotonSalir.UseVisualStyleBackColor = true;
            BotonSalir.Click += BotonSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(801, 450);
            Controls.Add(BotonSalir);
            Controls.Add(BotonGestionarInventario);
            Controls.Add(BotonGestionarBloques);
            Controls.Add(BotonGestionarJugadores);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BotonGestionarJugadores;
        private Button BotonGestionarBloques;
        private Button BotonGestionarInventario;
        private Button BotonSalir;
    }
}
