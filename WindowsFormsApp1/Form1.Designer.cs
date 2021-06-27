namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.administracion = new System.Windows.Forms.Button();
            this.ventas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // administracion
            // 
            this.administracion.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.administracion.Location = new System.Drawing.Point(305, 101);
            this.administracion.Name = "administracion";
            this.administracion.Size = new System.Drawing.Size(184, 73);
            this.administracion.TabIndex = 0;
            this.administracion.Text = "Administracion";
            this.administracion.UseVisualStyleBackColor = true;
            this.administracion.Click += new System.EventHandler(this.administracion_Click);
            // 
            // ventas
            // 
            this.ventas.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ventas.Location = new System.Drawing.Point(305, 206);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(184, 76);
            this.ventas.TabIndex = 1;
            this.ventas.Text = "Ventas";
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.hipertextual_marvel_revela_sera_final_universo_marvel_2019314666;
            this.pictureBox1.Location = new System.Drawing.Point(23, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(183, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas de Figuras de Accion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ventas);
            this.Controls.Add(this.administracion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button administracion;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

