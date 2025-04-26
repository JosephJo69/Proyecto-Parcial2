namespace Parcial_002_Ahora_es_personal
{
    partial class FormEliminarBloque
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
            BotonEliminarBloque = new Button();
            label1 = new Label();
            TB_ID_Eliminar_Bloque = new TextBox();
            BotonvVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Eliminar_Bloque;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotonEliminarBloque
            // 
            BotonEliminarBloque.BackColor = Color.Red;
            BotonEliminarBloque.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonEliminarBloque.Location = new Point(330, 246);
            BotonEliminarBloque.Name = "BotonEliminarBloque";
            BotonEliminarBloque.Size = new Size(140, 42);
            BotonEliminarBloque.TabIndex = 22;
            BotonEliminarBloque.Text = "ELIMINAR";
            BotonEliminarBloque.UseVisualStyleBackColor = false;
            BotonEliminarBloque.Click += BotonEliminarBloque_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(379, 163);
            label1.Name = "label1";
            label1.Size = new Size(40, 32);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // TB_ID_Eliminar_Bloque
            // 
            TB_ID_Eliminar_Bloque.Location = new Point(350, 198);
            TB_ID_Eliminar_Bloque.Name = "TB_ID_Eliminar_Bloque";
            TB_ID_Eliminar_Bloque.Size = new Size(100, 23);
            TB_ID_Eliminar_Bloque.TabIndex = 20;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(42, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 23;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // FormEliminarBloque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonvVolver);
            Controls.Add(BotonEliminarBloque);
            Controls.Add(label1);
            Controls.Add(TB_ID_Eliminar_Bloque);
            Controls.Add(pictureBox1);
            Name = "FormEliminarBloque";
            Text = "FormEliminarBloque";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BotonEliminarBloque;
        private Label label1;
        private TextBox TB_ID_Eliminar_Bloque;
        private Button BotonvVolver;
    }
}