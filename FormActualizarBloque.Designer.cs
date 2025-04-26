namespace Parcial_002_Ahora_es_personal
{
    partial class FormActualizarBloque
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
            LabelRareza = new Label();
            TBRareza = new TextBox();
            LabelTipo = new Label();
            TBTipo = new TextBox();
            LabelNombreBloque = new Label();
            TBNombreBloque = new TextBox();
            LBID = new Label();
            TB_ID_Bloque = new TextBox();
            BotonActualizarBloque = new Button();
            BotonvVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Actualizar_Bloque;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LabelRareza
            // 
            LabelRareza.AutoSize = true;
            LabelRareza.BackColor = Color.Transparent;
            LabelRareza.ForeColor = SystemColors.ButtonHighlight;
            LabelRareza.Location = new Point(66, 258);
            LabelRareza.Name = "LabelRareza";
            LabelRareza.Size = new Size(41, 15);
            LabelRareza.TabIndex = 16;
            LabelRareza.Text = "Rareza";
            // 
            // TBRareza
            // 
            TBRareza.Location = new Point(143, 255);
            TBRareza.Name = "TBRareza";
            TBRareza.Size = new Size(585, 23);
            TBRareza.TabIndex = 15;
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSize = true;
            LabelTipo.BackColor = Color.Transparent;
            LabelTipo.ForeColor = SystemColors.ButtonHighlight;
            LabelTipo.Location = new Point(66, 209);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(30, 15);
            LabelTipo.TabIndex = 14;
            LabelTipo.Text = "Tipo";
            // 
            // TBTipo
            // 
            TBTipo.Location = new Point(143, 206);
            TBTipo.Name = "TBTipo";
            TBTipo.Size = new Size(585, 23);
            TBTipo.TabIndex = 13;
            // 
            // LabelNombreBloque
            // 
            LabelNombreBloque.AutoSize = true;
            LabelNombreBloque.BackColor = Color.Transparent;
            LabelNombreBloque.ForeColor = SystemColors.ButtonHighlight;
            LabelNombreBloque.Location = new Point(66, 153);
            LabelNombreBloque.Name = "LabelNombreBloque";
            LabelNombreBloque.Size = new Size(51, 15);
            LabelNombreBloque.TabIndex = 12;
            LabelNombreBloque.Text = "Nombre";
            // 
            // TBNombreBloque
            // 
            TBNombreBloque.Location = new Point(143, 150);
            TBNombreBloque.Name = "TBNombreBloque";
            TBNombreBloque.Size = new Size(585, 23);
            TBNombreBloque.TabIndex = 11;
            // 
            // LBID
            // 
            LBID.AutoSize = true;
            LBID.BackColor = Color.Transparent;
            LBID.ForeColor = SystemColors.ButtonHighlight;
            LBID.Location = new Point(66, 109);
            LBID.Name = "LBID";
            LBID.Size = new Size(18, 15);
            LBID.TabIndex = 18;
            LBID.Text = "ID";
            // 
            // TB_ID_Bloque
            // 
            TB_ID_Bloque.Location = new Point(143, 106);
            TB_ID_Bloque.Name = "TB_ID_Bloque";
            TB_ID_Bloque.Size = new Size(585, 23);
            TB_ID_Bloque.TabIndex = 17;
            // 
            // BotonActualizarBloque
            // 
            BotonActualizarBloque.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonActualizarBloque.Location = new Point(305, 299);
            BotonActualizarBloque.Name = "BotonActualizarBloque";
            BotonActualizarBloque.Size = new Size(212, 48);
            BotonActualizarBloque.TabIndex = 19;
            BotonActualizarBloque.Text = "Actualizar";
            BotonActualizarBloque.UseVisualStyleBackColor = true;
            BotonActualizarBloque.Click += BotonActualizarBloque_Click;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(37, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 20;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // FormActualizarBloque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonvVolver);
            Controls.Add(BotonActualizarBloque);
            Controls.Add(LBID);
            Controls.Add(TB_ID_Bloque);
            Controls.Add(LabelRareza);
            Controls.Add(TBRareza);
            Controls.Add(LabelTipo);
            Controls.Add(TBTipo);
            Controls.Add(LabelNombreBloque);
            Controls.Add(TBNombreBloque);
            Controls.Add(pictureBox1);
            Name = "FormActualizarBloque";
            Text = "FormActualizarBloque";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LabelRareza;
        private TextBox TBRareza;
        private Label LabelTipo;
        private TextBox TBTipo;
        private Label LabelNombreBloque;
        private TextBox TBNombreBloque;
        private Label LBID;
        private TextBox TB_ID_Bloque;
        private Button BotonActualizarBloque;
        private Button BotonvVolver;
    }
}