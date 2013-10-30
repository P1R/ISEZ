namespace Practica18
{
    partial class repetidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repetidor));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.firma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(21, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(558, 380);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // firma
            // 
            this.firma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firma.ForeColor = System.Drawing.Color.Brown;
            this.firma.Location = new System.Drawing.Point(958, 585);
            this.firma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(129, 49);
            this.firma.TabIndex = 41;
            this.firma.Text = "Firma";
            this.firma.UseVisualStyleBackColor = true;
            this.firma.Click += new System.EventHandler(this.firma_Click);
            // 
            // repetidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1099, 647);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.pic1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repetidor";
            this.Text = "Repetidor en tiempo real ";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button firma;
    }
}

