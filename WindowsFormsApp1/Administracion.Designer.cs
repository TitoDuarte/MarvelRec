namespace WindowsFormsApp1
{
    partial class Administracion
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
            this.franquiciaBox = new System.Windows.Forms.ComboBox();
            this.franquicia = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.precionumeric = new System.Windows.Forms.NumericUpDown();
            this.tbFiguras = new System.Windows.Forms.DataGridView();
            this.existencias = new System.Windows.Forms.Label();
            this.existencianumeric = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.descripcionBox = new System.Windows.Forms.RichTextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.precionumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFiguras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existencianumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // franquiciaBox
            // 
            this.franquiciaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.franquiciaBox.FormattingEnabled = true;
            this.franquiciaBox.Items.AddRange(new object[] {
            "Marvel",
            "DC",
            "Capcom"});
            this.franquiciaBox.Location = new System.Drawing.Point(92, 37);
            this.franquiciaBox.Name = "franquiciaBox";
            this.franquiciaBox.Size = new System.Drawing.Size(194, 21);
            this.franquiciaBox.TabIndex = 1;
            // 
            // franquicia
            // 
            this.franquicia.AutoSize = true;
            this.franquicia.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.franquicia.Location = new System.Drawing.Point(8, 37);
            this.franquicia.Name = "franquicia";
            this.franquicia.Size = new System.Drawing.Size(78, 13);
            this.franquicia.TabIndex = 2;
            this.franquicia.Text = "Franquicia:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(27, 78);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(60, 13);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre:";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(92, 75);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(194, 20);
            this.nombreBox.TabIndex = 4;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(-1, 203);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(88, 13);
            this.descripcion.TabIndex = 5;
            this.descripcion.Text = "Descripcion:";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(27, 116);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(63, 13);
            this.precio.TabIndex = 7;
            this.precio.Text = "Precio:";
            // 
            // precionumeric
            // 
            this.precionumeric.Location = new System.Drawing.Point(92, 114);
            this.precionumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.precionumeric.Name = "precionumeric";
            this.precionumeric.Size = new System.Drawing.Size(194, 20);
            this.precionumeric.TabIndex = 8;
            this.precionumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbFiguras
            // 
            this.tbFiguras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFiguras.Location = new System.Drawing.Point(318, 78);
            this.tbFiguras.Name = "tbFiguras";
            this.tbFiguras.Size = new System.Drawing.Size(439, 312);
            this.tbFiguras.TabIndex = 9;
            this.tbFiguras.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbFiguras_RowHeaderMouseDoubleClick);
            // 
            // existencias
            // 
            this.existencias.AutoSize = true;
            this.existencias.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existencias.Location = new System.Drawing.Point(5, 155);
            this.existencias.Name = "existencias";
            this.existencias.Size = new System.Drawing.Size(85, 13);
            this.existencias.TabIndex = 10;
            this.existencias.Text = "Existencias:";
            this.existencias.Click += new System.EventHandler(this.label5_Click);
            // 
            // existencianumeric
            // 
            this.existencianumeric.Location = new System.Drawing.Point(92, 153);
            this.existencianumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.existencianumeric.Name = "existencianumeric";
            this.existencianumeric.Size = new System.Drawing.Size(194, 20);
            this.existencianumeric.TabIndex = 11;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(29, 306);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(130, 39);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.crear_Click);
            // 
            // descripcionBox
            // 
            this.descripcionBox.Location = new System.Drawing.Point(92, 200);
            this.descripcionBox.Name = "descripcionBox";
            this.descripcionBox.Size = new System.Drawing.Size(194, 86);
            this.descripcionBox.TabIndex = 13;
            this.descripcionBox.Text = "";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(165, 306);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 39);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(29, 351);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(257, 39);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(365, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Administracion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.descripcionBox);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.existencianumeric);
            this.Controls.Add(this.existencias);
            this.Controls.Add(this.tbFiguras);
            this.Controls.Add(this.precionumeric);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.franquicia);
            this.Controls.Add(this.franquiciaBox);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.precionumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFiguras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existencianumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox franquiciaBox;
        private System.Windows.Forms.Label franquicia;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.NumericUpDown precionumeric;
        private System.Windows.Forms.DataGridView tbFiguras;
        private System.Windows.Forms.Label existencias;
        private System.Windows.Forms.NumericUpDown existencianumeric;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RichTextBox descripcionBox;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
    }
}