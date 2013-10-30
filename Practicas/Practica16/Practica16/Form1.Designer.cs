namespace Practica16
{
    partial class Temporizador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temporizador));
            this.label1 = new System.Windows.Forms.Label();
            this.Alarma = new System.Windows.Forms.TextBox();
            this.activar = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tiempo = new System.Windows.Forms.Label();
            this.firma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Alarma
            // 
            this.Alarma.Location = new System.Drawing.Point(146, 98);
            this.Alarma.Name = "Alarma";
            this.Alarma.Size = new System.Drawing.Size(202, 20);
            this.Alarma.TabIndex = 1;
            // 
            // activar
            // 
            this.activar.AutoSize = true;
            this.activar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activar.Location = new System.Drawing.Point(75, 93);
            this.activar.Name = "activar";
            this.activar.Size = new System.Drawing.Size(65, 25);
            this.activar.TabIndex = 2;
            this.activar.TabStop = true;
            this.activar.Text = "Activar";
            this.activar.UseCompatibleTextRendering = true;
            this.activar.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tiempo
            // 
            this.tiempo.AutoEllipsis = true;
            this.tiempo.AutoSize = true;
            this.tiempo.BackColor = System.Drawing.Color.DarkGray;
            this.tiempo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.ForeColor = System.Drawing.Color.Cornsilk;
            this.tiempo.Location = new System.Drawing.Point(72, 60);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(45, 20);
            this.tiempo.TabIndex = 3;
            this.tiempo.Text = "label2";
            // 
            // firma
            // 
            this.firma.ForeColor = System.Drawing.Color.Brown;
            this.firma.Location = new System.Drawing.Point(297, 139);
            this.firma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(51, 26);
            this.firma.TabIndex = 4;
            this.firma.Text = "Firma";
            this.firma.UseVisualStyleBackColor = true;
            this.firma.Click += new System.EventHandler(this.firma_Click);
            // 
            // Temporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 178);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.activar);
            this.Controls.Add(this.Alarma);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Temporizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarma Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Alarma;
        private System.Windows.Forms.RadioButton activar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Button firma;
    }
}

