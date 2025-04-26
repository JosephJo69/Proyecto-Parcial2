namespace Parcial_002_Ahora_es_personal
{
    partial class FormRegistrarBloque
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
            LabelTipo = new Label();
            TBTipo = new TextBox();
            LabelNombreBloque = new Label();
            TBNombreBloque = new TextBox();
            LabelRareza = new Label();
            TBRareza = new TextBox();
            BotonvVolver = new Button();
            BotonRegistrarBloque = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Registrar_Bloque;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSize = true;
            LabelTipo.BackColor = Color.Transparent;
            LabelTipo.ForeColor = SystemColors.ButtonHighlight;
            LabelTipo.Location = new Point(69, 183);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(30, 15);
            LabelTipo.TabIndex = 8;
            LabelTipo.Text = "Tipo";
            // 
            // TBTipo
            // 
            TBTipo.Location = new Point(146, 180);
            TBTipo.Name = "TBTipo";
            TBTipo.Size = new Size(585, 23);
            TBTipo.TabIndex = 7;
            // 
            // LabelNombreBloque
            // 
            LabelNombreBloque.AutoSize = true;
            LabelNombreBloque.BackColor = Color.Transparent;
            LabelNombreBloque.ForeColor = SystemColors.ButtonHighlight;
            LabelNombreBloque.Location = new Point(69, 101);
            LabelNombreBloque.Name = "LabelNombreBloque";
            LabelNombreBloque.Size = new Size(51, 15);
            LabelNombreBloque.TabIndex = 6;
            LabelNombreBloque.Text = "Nombre";
            // 
            // TBNombreBloque
            // 
            TBNombreBloque.Location = new Point(146, 98);
            TBNombreBloque.Name = "TBNombreBloque";
            TBNombreBloque.Size = new Size(585, 23);
            TBNombreBloque.TabIndex = 5;
            // 
            // LabelRareza
            // 
            LabelRareza.AutoSize = true;
            LabelRareza.BackColor = Color.Transparent;
            LabelRareza.ForeColor = SystemColors.ButtonHighlight;
            LabelRareza.Location = new Point(69, 259);
            LabelRareza.Name = "LabelRareza";
            LabelRareza.Size = new Size(41, 15);
            LabelRareza.TabIndex = 10;
            LabelRareza.Text = "Rareza";
            // 
            // TBRareza
            // 
            TBRareza.Location = new Point(146, 256);
            TBRareza.Name = "TBRareza";
            TBRareza.Size = new Size(585, 23);
            TBRareza.TabIndex = 9;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(43, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 11;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // BotonRegistrarBloque
            // 
            BotonRegistrarBloque.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonRegistrarBloque.Location = new Point(286, 308);
            BotonRegistrarBloque.Name = "BotonRegistrarBloque";
            BotonRegistrarBloque.Size = new Size(212, 48);
            BotonRegistrarBloque.TabIndex = 12;
            BotonRegistrarBloque.Text = "Registrar";
            BotonRegistrarBloque.UseVisualStyleBackColor = true;
            BotonRegistrarBloque.Click += BotonRegistrarBloque_Click;
            // 
            // FormRegistrarBloque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonRegistrarBloque);
            Controls.Add(BotonvVolver);
            Controls.Add(LabelRareza);
            Controls.Add(TBRareza);
            Controls.Add(LabelTipo);
            Controls.Add(TBTipo);
            Controls.Add(LabelNombreBloque);
            Controls.Add(TBNombreBloque);
            Controls.Add(pictureBox1);
            Name = "FormRegistrarBloque";
            Text = "FormRegistrarBloque";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LabelTipo;
        private TextBox TBTipo;
        private Label LabelNombreBloque;
        private TextBox TBNombreBloque;
        private Label LabelRareza;
        private TextBox TBRareza;
        private Button BotonvVolver;
        private Button BotonRegistrarBloque;
    }
}