namespace Practica25
{
    partial class Trazo
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
            this.label1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.Firma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Con el mause da click y sin soltar traza lienas ";
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic1.Location = new System.Drawing.Point(24, 84);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(937, 429);
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            this.pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseDown);
            this.pic1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseMove);
            this.pic1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic1_MouseUp);
            // 
            // Firma
            // 
            this.Firma.Location = new System.Drawing.Point(886, 519);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(75, 23);
            this.Firma.TabIndex = 12;
            this.Firma.Text = "Firma";
            this.Firma.UseVisualStyleBackColor = true;
            this.Firma.Click += new System.EventHandler(this.Firma_Click);
            // 
            // Trazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 554);
            this.Controls.Add(this.Firma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic1);
            this.Name = "Trazo";
            this.Text = "Trazo de linea con el mause";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button Firma;
    }
}

