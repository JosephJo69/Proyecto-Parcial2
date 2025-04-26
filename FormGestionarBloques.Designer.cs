namespace Parcial_002_Ahora_es_personal
{
    partial class FormGestionarBloques
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
            BotonvVolver = new Button();
            BotonRegistrarBloque = new Button();
            BotonListarBloques = new Button();
            BotonBloquePorId = new Button();
            BotonBloquePorTipo = new Button();
            BotonBloquePorRareza = new Button();
            BotonActualizarBloque = new Button();
            BotonEliminarBloque = new Button();
            dataGridView1 = new DataGridView();
            BotonCerrarGridBloques = new Button();
            BotonBuscarIDBloque = new Button();
            TBIDBloque = new TextBox();
            TBTipoBloque = new TextBox();
            BotonBuscarTipo = new Button();
            BotonBuscarRareza = new Button();
            TBRareza = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Gestionar_Bloques;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BotonvVolver
            // 
            BotonvVolver.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonvVolver.Location = new Point(43, 390);
            BotonvVolver.Name = "BotonvVolver";
            BotonvVolver.Size = new Size(711, 48);
            BotonvVolver.TabIndex = 8;
            BotonvVolver.Text = "Volver";
            BotonvVolver.UseVisualStyleBackColor = true;
            BotonvVolver.Click += BotonvVolver_Click;
            // 
            // BotonRegistrarBloque
            // 
            BotonRegistrarBloque.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonRegistrarBloque.Location = new Point(100, 128);
            BotonRegistrarBloque.Name = "BotonRegistrarBloque";
            BotonRegistrarBloque.Size = new Size(161, 48);
            BotonRegistrarBloque.TabIndex = 9;
            BotonRegistrarBloque.Text = "Registrar Bloque";
            BotonRegistrarBloque.UseVisualStyleBackColor = true;
            BotonRegistrarBloque.Click += BotonRegistrarBloque_Click;
            // 
            // BotonListarBloques
            // 
            BotonListarBloques.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonListarBloques.Location = new Point(310, 128);
            BotonListarBloques.Name = "BotonListarBloques";
            BotonListarBloques.Size = new Size(161, 48);
            BotonListarBloques.TabIndex = 10;
            BotonListarBloques.Text = "Listar Bloques";
            BotonListarBloques.UseVisualStyleBackColor = true;
            BotonListarBloques.Click += BotonListarBloques_Click;
            // 
            // BotonBloquePorId
            // 
            BotonBloquePorId.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBloquePorId.Location = new Point(528, 128);
            BotonBloquePorId.Name = "BotonBloquePorId";
            BotonBloquePorId.Size = new Size(161, 48);
            BotonBloquePorId.TabIndex = 11;
            BotonBloquePorId.Text = "Buscar Bloque Por ID";
            BotonBloquePorId.UseVisualStyleBackColor = true;
            BotonBloquePorId.Click += BotonBloquePorId_Click;
            // 
            // BotonBloquePorTipo
            // 
            BotonBloquePorTipo.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBloquePorTipo.Location = new Point(100, 204);
            BotonBloquePorTipo.Name = "BotonBloquePorTipo";
            BotonBloquePorTipo.Size = new Size(161, 48);
            BotonBloquePorTipo.TabIndex = 12;
            BotonBloquePorTipo.Text = "Buscar Bloque por Tipo";
            BotonBloquePorTipo.UseVisualStyleBackColor = true;
            BotonBloquePorTipo.Click += BotonBloquePorTipo_Click;
            // 
            // BotonBloquePorRareza
            // 
            BotonBloquePorRareza.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBloquePorRareza.Location = new Point(310, 204);
            BotonBloquePorRareza.Name = "BotonBloquePorRareza";
            BotonBloquePorRareza.Size = new Size(161, 48);
            BotonBloquePorRareza.TabIndex = 13;
            BotonBloquePorRareza.Text = "Buscar Bloque por Rareza";
            BotonBloquePorRareza.UseVisualStyleBackColor = true;
            BotonBloquePorRareza.Click += BotonBloquePorRareza_Click;
            // 
            // BotonActualizarBloque
            // 
            BotonActualizarBloque.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonActualizarBloque.Location = new Point(528, 204);
            BotonActualizarBloque.Name = "BotonActualizarBloque";
            BotonActualizarBloque.Size = new Size(161, 48);
            BotonActualizarBloque.TabIndex = 14;
            BotonActualizarBloque.Text = "Actualizar Bloque";
            BotonActualizarBloque.UseVisualStyleBackColor = true;
            BotonActualizarBloque.Click += BotonActualizarBloque_Click;
            // 
            // BotonEliminarBloque
            // 
            BotonEliminarBloque.BackColor = Color.IndianRed;
            BotonEliminarBloque.Font = new Font("MS Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BotonEliminarBloque.Location = new Point(310, 278);
            BotonEliminarBloque.Name = "BotonEliminarBloque";
            BotonEliminarBloque.Size = new Size(161, 48);
            BotonEliminarBloque.TabIndex = 15;
            BotonEliminarBloque.Text = "ELIMINAR BLOQUE";
            BotonEliminarBloque.UseVisualStyleBackColor = false;
            BotonEliminarBloque.Click += BotonEliminarBloque_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(711, 262);
            dataGridView1.TabIndex = 16;
            dataGridView1.Visible = false;
            // 
            // BotonCerrarGridBloques
            // 
            BotonCerrarGridBloques.BackColor = Color.Red;
            BotonCerrarGridBloques.Location = new Point(356, 343);
            BotonCerrarGridBloques.Name = "BotonCerrarGridBloques";
            BotonCerrarGridBloques.Size = new Size(75, 23);
            BotonCerrarGridBloques.TabIndex = 17;
            BotonCerrarGridBloques.Text = "X";
            BotonCerrarGridBloques.UseVisualStyleBackColor = false;
            BotonCerrarGridBloques.Visible = false;
            BotonCerrarGridBloques.Click += BotonCerrarGrid_Click;
            // 
            // BotonBuscarIDBloque
            // 
            BotonBuscarIDBloque.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarIDBloque.Location = new Point(43, 113);
            BotonBuscarIDBloque.Name = "BotonBuscarIDBloque";
            BotonBuscarIDBloque.Size = new Size(161, 48);
            BotonBuscarIDBloque.TabIndex = 18;
            BotonBuscarIDBloque.Text = "Buscar ID";
            BotonBuscarIDBloque.UseVisualStyleBackColor = true;
            BotonBuscarIDBloque.Visible = false;
            BotonBuscarIDBloque.Click += BotonBuscarIDBloque_Click;
            // 
            // TBIDBloque
            // 
            TBIDBloque.Location = new Point(69, 84);
            TBIDBloque.Name = "TBIDBloque";
            TBIDBloque.Size = new Size(100, 23);
            TBIDBloque.TabIndex = 19;
            TBIDBloque.Visible = false;
            // 
            // TBTipoBloque
            // 
            TBTipoBloque.Location = new Point(69, 175);
            TBTipoBloque.Name = "TBTipoBloque";
            TBTipoBloque.Size = new Size(100, 23);
            TBTipoBloque.TabIndex = 20;
            TBTipoBloque.Visible = false;
            // 
            // BotonBuscarTipo
            // 
            BotonBuscarTipo.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarTipo.Location = new Point(43, 204);
            BotonBuscarTipo.Name = "BotonBuscarTipo";
            BotonBuscarTipo.Size = new Size(161, 48);
            BotonBuscarTipo.TabIndex = 21;
            BotonBuscarTipo.Text = "Buscar Tipo";
            BotonBuscarTipo.UseVisualStyleBackColor = true;
            BotonBuscarTipo.Visible = false;
            BotonBuscarTipo.Click += BotonBuscarTipo_Click;
            // 
            // BotonBuscarRareza
            // 
            BotonBuscarRareza.Font = new Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonBuscarRareza.Location = new Point(43, 295);
            BotonBuscarRareza.Name = "BotonBuscarRareza";
            BotonBuscarRareza.Size = new Size(161, 48);
            BotonBuscarRareza.TabIndex = 22;
            BotonBuscarRareza.Text = "Buscar Rareza";
            BotonBuscarRareza.UseVisualStyleBackColor = true;
            BotonBuscarRareza.Visible = false;
            BotonBuscarRareza.Click += BotonBuscarRareza_Click;
            // 
            // TBRareza
            // 
            TBRareza.Location = new Point(69, 266);
            TBRareza.Name = "TBRareza";
            TBRareza.Size = new Size(100, 23);
            TBRareza.TabIndex = 23;
            TBRareza.Visible = false;
            // 
            // FormGestionarBloques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_dirt_minecraft_minimalistic_wallpaper_preview;
            ClientSize = new Size(800, 450);
            Controls.Add(TBRareza);
            Controls.Add(BotonBuscarRareza);
            Controls.Add(BotonBuscarTipo);
            Controls.Add(TBTipoBloque);
            Controls.Add(TBIDBloque);
            Controls.Add(BotonBuscarIDBloque);
            Controls.Add(BotonCerrarGridBloques);
            Controls.Add(BotonEliminarBloque);
            Controls.Add(BotonActualizarBloque);
            Controls.Add(BotonBloquePorRareza);
            Controls.Add(BotonBloquePorTipo);
            Controls.Add(BotonBloquePorId);
            Controls.Add(BotonListarBloques);
            Controls.Add(BotonRegistrarBloque);
            Controls.Add(BotonvVolver);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "FormGestionarBloques";
            Text = "FormGestionarBloques";
            Load += FormGestionarBloques_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BotonvVolver;
        private Button BotonRegistrarBloque;
        private Button BotonListarBloques;
        private Button BotonBloquePorId;
        private Button BotonBloquePorTipo;
        private Button BotonBloquePorRareza;
        private Button BotonActualizarBloque;
        private Button BotonEliminarBloque;
        private DataGridView dataGridView1;
        private Button BotonCerrarGridBloques;
        private Button BotonBuscarIDBloque;
        private TextBox TBIDBloque;
        private TextBox TBTipoBloque;
        private Button BotonBuscarTipo;
        private Button BotonBuscarRareza;
        private TextBox TBRareza;
    }
}