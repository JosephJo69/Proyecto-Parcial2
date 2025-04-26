namespace Parcial_002_Ahora_es_personal
{
    partial class FormEliminarJugador
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
            TB_ID_Eliminar = new TextBox();
            label1 = new Label();
            BotonvVolver = new Button();
            BotonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Eliminar_Jugador;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TB_ID_Eliminar
            // 
            TB_ID_Eliminar.Location = new Point(358, 146);
            TB_ID_Eliminar.Name = "TB_ID_Eliminar";
            TB_ID_Eliminar.Size = new Size(100, 23);
            TB_ID_Eliminar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(387, 111);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(50, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 18;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.Red;
            BotonEliminar.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonEliminar.Location = new Point(338, 194);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(140, 42);
            BotonEliminar.TabIndex = 19;
            BotonEliminar.Text = "ELIMINAR";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // FormEliminarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonvVolver);
            Controls.Add(label1);
            Controls.Add(TB_ID_Eliminar);
            Controls.Add(pictureBox1);
            Name = "FormEliminarJugador";
            Text = "FormEliminarJugador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TB_ID_Eliminar;
        private Label label1;
        private Button BotonvVolver;
        private Button BotonEliminar;
    }
}