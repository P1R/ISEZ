namespace Practica22
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firma = new System.Windows.Forms.Button();
            this.Circulos = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.Puntos = new System.Windows.Forms.Button();
            this.Lineas = new System.Windows.Forms.Button();
            this.Cuadros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // firma
            // 
            this.firma.Location = new System.Drawing.Point(400, 490);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(75, 23);
            this.firma.TabIndex = 5;
            this.firma.Text = "Firma";
            this.firma.UseVisualStyleBackColor = true;
            this.firma.Click += new System.EventHandler(this.firma_Click);
            // 
            // Circulos
            // 
            this.Circulos.Location = new System.Drawing.Point(39, 419);
            this.Circulos.Name = "Circulos";
            this.Circulos.Size = new System.Drawing.Size(110, 44);
            this.Circulos.TabIndex = 4;
            this.Circulos.Text = "Circulos";
            this.Circulos.UseVisualStyleBackColor = true;
            this.Circulos.Click += new System.EventHandler(this.circulos_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic1.Location = new System.Drawing.Point(39, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(436, 401);
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // Puntos
            // 
            this.Puntos.Location = new System.Drawing.Point(39, 469);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(110, 44);
            this.Puntos.TabIndex = 6;
            this.Puntos.Text = "Puntos";
            this.Puntos.UseVisualStyleBackColor = true;
            this.Puntos.Click += new System.EventHandler(this.puntos_Click);
            // 
            // Lineas
            // 
            this.Lineas.Location = new System.Drawing.Point(183, 419);
            this.Lineas.Name = "Lineas";
            this.Lineas.Size = new System.Drawing.Size(110, 44);
            this.Lineas.TabIndex = 7;
            this.Lineas.Text = "Lineas";
            this.Lineas.UseVisualStyleBackColor = true;
            this.Lineas.Click += new System.EventHandler(this.lineas_Click);
            // 
            // Cuadros
            // 
            this.Cuadros.Location = new System.Drawing.Point(183, 472);
            this.Cuadros.Name = "Cuadros";
            this.Cuadros.Size = new System.Drawing.Size(110, 44);
            this.Cuadros.TabIndex = 8;
            this.Cuadros.Text = "Cuadros";
            this.Cuadros.UseVisualStyleBackColor = true;
            this.Cuadros.Click += new System.EventHandler(this.Cuadros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 526);
            this.Controls.Add(this.Cuadros);
            this.Controls.Add(this.Lineas);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.Circulos);
            this.Controls.Add(this.pic1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficos";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firma;
        private System.Windows.Forms.Button Circulos;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button Puntos;
        private System.Windows.Forms.Button Lineas;
        private System.Windows.Forms.Button Cuadros;
    }
}

