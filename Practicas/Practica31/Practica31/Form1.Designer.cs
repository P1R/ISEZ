namespace Practica31
{
    partial class Graficadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graficadora));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.Xf = new System.Windows.Forms.TextBox();
            this.Xi = new System.Windows.Forms.TextBox();
            this.Firma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Graficando = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic1.Location = new System.Drawing.Point(214, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(458, 521);
            this.pic1.TabIndex = 15;
            this.pic1.TabStop = false;
            // 
            // Xf
            // 
            this.Xf.Location = new System.Drawing.Point(53, 104);
            this.Xf.Name = "Xf";
            this.Xf.Size = new System.Drawing.Size(131, 20);
            this.Xf.TabIndex = 21;
            this.Xf.Text = "10";
            // 
            // Xi
            // 
            this.Xi.Location = new System.Drawing.Point(53, 56);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(131, 20);
            this.Xi.TabIndex = 20;
            this.Xi.Text = "-10";
            // 
            // Firma
            // 
            this.Firma.Location = new System.Drawing.Point(541, 546);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(131, 23);
            this.Firma.TabIndex = 22;
            this.Firma.Text = "Firma";
            this.Firma.UseVisualStyleBackColor = true;
            this.Firma.Click += new System.EventHandler(this.Firma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Xf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Xi";
            // 
            // Graficando
            // 
            this.Graficando.Location = new System.Drawing.Point(53, 194);
            this.Graficando.Name = "Graficando";
            this.Graficando.Size = new System.Drawing.Size(131, 23);
            this.Graficando.TabIndex = 26;
            this.Graficando.Text = "Graficar";
            this.Graficando.UseVisualStyleBackColor = true;
            this.Graficando.Click += new System.EventHandler(this.Graficando_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(53, 260);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(131, 23);
            this.Borrar.TabIndex = 27;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Graficadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 581);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Graficando);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Firma);
            this.Controls.Add(this.Xf);
            this.Controls.Add(this.Xi);
            this.Controls.Add(this.pic1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Graficadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficadora de Funciones Paramétricas";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.TextBox Xf;
        private System.Windows.Forms.TextBox Xi;
        private System.Windows.Forms.Button Firma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Graficando;
        private System.Windows.Forms.Button Borrar;
    }
}

