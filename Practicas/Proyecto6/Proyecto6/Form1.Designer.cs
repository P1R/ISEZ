namespace Proyecto6
{
    partial class graficos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cuadros = new System.Windows.Forms.Button();
            this.Lineas = new System.Windows.Forms.Button();
            this.firma = new System.Windows.Forms.Button();
            this.Circulos = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.circulos_relleno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cuadros
            // 
            this.Cuadros.Location = new System.Drawing.Point(684, 463);
            this.Cuadros.Name = "Cuadros";
            this.Cuadros.Size = new System.Drawing.Size(239, 44);
            this.Cuadros.TabIndex = 14;
            this.Cuadros.Text = "Cuadros rellenos ";
            this.Cuadros.UseVisualStyleBackColor = true;
            this.Cuadros.Click += new System.EventHandler(this.Cuadros_Click);
            // 
            // Lineas
            // 
            this.Lineas.Location = new System.Drawing.Point(684, 86);
            this.Lineas.Name = "Lineas";
            this.Lineas.Size = new System.Drawing.Size(239, 44);
            this.Lineas.TabIndex = 13;
            this.Lineas.Text = "Lineas";
            this.Lineas.UseVisualStyleBackColor = true;
            this.Lineas.Click += new System.EventHandler(this.Lineas_Click);
            // 
            // firma
            // 
            this.firma.Location = new System.Drawing.Point(684, 545);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(75, 23);
            this.firma.TabIndex = 11;
            this.firma.Text = "Firma";
            this.firma.UseVisualStyleBackColor = true;
            this.firma.Click += new System.EventHandler(this.firma_Click);
            // 
            // Circulos
            // 
            this.Circulos.Location = new System.Drawing.Point(684, 36);
            this.Circulos.Name = "Circulos";
            this.Circulos.Size = new System.Drawing.Size(239, 44);
            this.Circulos.TabIndex = 10;
            this.Circulos.Text = "Circulos";
            this.Circulos.UseVisualStyleBackColor = true;
            this.Circulos.Click += new System.EventHandler(this.Circulos_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic1.Location = new System.Drawing.Point(12, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(633, 556);
            this.pic1.TabIndex = 9;
            this.pic1.TabStop = false;
            this.pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseDown);
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            this.pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseUp);
            // 
            // circulos_relleno
            // 
            this.circulos_relleno.Location = new System.Drawing.Point(684, 413);
            this.circulos_relleno.Name = "circulos_relleno";
            this.circulos_relleno.Size = new System.Drawing.Size(239, 44);
            this.circulos_relleno.TabIndex = 15;
            this.circulos_relleno.Text = "Circulos rellenos ";
            this.circulos_relleno.UseVisualStyleBackColor = true;
            this.circulos_relleno.Click += new System.EventHandler(this.circulos_relleno_Click);
            // 
            // graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 580);
            this.Controls.Add(this.circulos_relleno);
            this.Controls.Add(this.Cuadros);
            this.Controls.Add(this.Lineas);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.Circulos);
            this.Controls.Add(this.pic1);
            this.Name = "graficos";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cuadros;
        private System.Windows.Forms.Button Lineas;
        private System.Windows.Forms.Button firma;
        private System.Windows.Forms.Button Circulos;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button circulos_relleno;
    }
}

