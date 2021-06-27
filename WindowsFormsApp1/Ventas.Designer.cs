namespace WindowsFormsApp1
{
    partial class Ventas
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
            this.franquiciav = new System.Windows.Forms.Label();
            this.franquiciaBox = new System.Windows.Forms.ComboBox();
            this.figuradeaccion = new System.Windows.Forms.Label();
            this.figuraBox = new System.Windows.Forms.ComboBox();
            this.comprar = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.precioBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcionBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridventas = new System.Windows.Forms.DataGridView();
            this.franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridventas)).BeginInit();
            this.SuspendLayout();
            // 
            // franquiciav
            // 
            this.franquiciav.AutoSize = true;
            this.franquiciav.Font = new System.Drawing.Font("MS Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.franquiciav.Location = new System.Drawing.Point(3, 201);
            this.franquiciav.Name = "franquiciav";
            this.franquiciav.Size = new System.Drawing.Size(75, 12);
            this.franquiciav.TabIndex = 0;
            this.franquiciav.Text = "Franquicia";
            // 
            // franquiciaBox
            // 
            this.franquiciaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.franquiciaBox.FormattingEnabled = true;
            this.franquiciaBox.Items.AddRange(new object[] {
            "Marvel",
            "DC",
            "Capcom"});
            this.franquiciaBox.Location = new System.Drawing.Point(84, 197);
            this.franquiciaBox.Name = "franquiciaBox";
            this.franquiciaBox.Size = new System.Drawing.Size(145, 21);
            this.franquiciaBox.TabIndex = 1;
            this.franquiciaBox.SelectedIndexChanged += new System.EventHandler(this.franquiciaBoxv_SelectedIndexChanged);
            // 
            // figuradeaccion
            // 
            this.figuradeaccion.AutoSize = true;
            this.figuradeaccion.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figuradeaccion.Location = new System.Drawing.Point(246, 201);
            this.figuradeaccion.Name = "figuradeaccion";
            this.figuradeaccion.Size = new System.Drawing.Size(56, 13);
            this.figuradeaccion.TabIndex = 2;
            this.figuradeaccion.Text = "Figura:";
            // 
            // figuraBox
            // 
            this.figuraBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figuraBox.FormattingEnabled = true;
            this.figuraBox.Location = new System.Drawing.Point(305, 198);
            this.figuraBox.Name = "figuraBox";
            this.figuraBox.Size = new System.Drawing.Size(163, 21);
            this.figuraBox.TabIndex = 3;
            this.figuraBox.SelectedIndexChanged += new System.EventHandler(this.figuraBox_SelectedIndexChanged);
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(25, 370);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(204, 40);
            this.comprar.TabIndex = 5;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(12, 328);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(48, 16);
            this.Total.TabIndex = 6;
            this.Total.Text = "Total";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(84, 328);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(145, 20);
            this.totalBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(84, 243);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.ReadOnly = true;
            this.nombreBox.Size = new System.Drawing.Size(145, 20);
            this.nombreBox.TabIndex = 9;
            // 
            // precioBox
            // 
            this.precioBox.Location = new System.Drawing.Point(84, 281);
            this.precioBox.Name = "precioBox";
            this.precioBox.ReadOnly = true;
            this.precioBox.Size = new System.Drawing.Size(145, 20);
            this.precioBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Precio";
            // 
            // descripcionBox
            // 
            this.descripcionBox.Location = new System.Drawing.Point(308, 237);
            this.descripcionBox.Name = "descripcionBox";
            this.descripcionBox.ReadOnly = true;
            this.descripcionBox.Size = new System.Drawing.Size(160, 111);
            this.descripcionBox.TabIndex = 13;
            this.descripcionBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre";
            // 
            // dataGridventas
            // 
            this.dataGridventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.franquicia,
            this.nombre,
            this.descripcion,
            this.precio});
            this.dataGridventas.Location = new System.Drawing.Point(25, 26);
            this.dataGridventas.Name = "dataGridventas";
            this.dataGridventas.Size = new System.Drawing.Size(443, 139);
            this.dataGridventas.TabIndex = 15;
            // 
            // franquicia
            // 
            this.franquicia.HeaderText = "Franquicia";
            this.franquicia.Name = "franquicia";
            this.franquicia.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 427);
            this.Controls.Add(this.dataGridventas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripcionBox);
            this.Controls.Add(this.precioBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.figuraBox);
            this.Controls.Add(this.figuradeaccion);
            this.Controls.Add(this.franquiciaBox);
            this.Controls.Add(this.franquiciav);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label franquiciav;
        private System.Windows.Forms.ComboBox franquiciaBox;
        private System.Windows.Forms.Label figuradeaccion;
        private System.Windows.Forms.ComboBox figuraBox;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox precioBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descripcionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}