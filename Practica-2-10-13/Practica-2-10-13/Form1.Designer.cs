namespace Practica_2_10_13
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxi = new System.Windows.Forms.TextBox();
            this.tbxf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(24, 27);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(370, 430);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Grafica";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxi
            // 
            this.tbxi.Location = new System.Drawing.Point(442, 75);
            this.tbxi.Name = "tbxi";
            this.tbxi.Size = new System.Drawing.Size(58, 20);
            this.tbxi.TabIndex = 2;
            // 
            // tbxf
            // 
            this.tbxf.Location = new System.Drawing.Point(442, 129);
            this.tbxf.Name = "tbxf";
            this.tbxf.Size = new System.Drawing.Size(58, 20);
            this.tbxf.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 485);
            this.Controls.Add(this.tbxf);
            this.Controls.Add(this.tbxi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxi;
        private System.Windows.Forms.TextBox tbxf;
    }
}

