namespace Practica14
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cy2 = new System.Windows.Forms.TextBox();
            this.cx2 = new System.Windows.Forms.TextBox();
            this.cy1 = new System.Windows.Forms.TextBox();
            this.cx1 = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Imaginario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Real";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Imaginario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Real";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Complejo 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Complejo 1";
            // 
            // cy2
            // 
            this.cy2.Location = new System.Drawing.Point(323, 88);
            this.cy2.Name = "cy2";
            this.cy2.Size = new System.Drawing.Size(100, 20);
            this.cy2.TabIndex = 13;
            // 
            // cx2
            // 
            this.cx2.Location = new System.Drawing.Point(323, 51);
            this.cx2.Name = "cx2";
            this.cx2.Size = new System.Drawing.Size(100, 20);
            this.cx2.TabIndex = 12;
            // 
            // cy1
            // 
            this.cy1.Location = new System.Drawing.Point(105, 84);
            this.cy1.Name = "cy1";
            this.cy1.Size = new System.Drawing.Size(100, 20);
            this.cy1.TabIndex = 11;
            // 
            // cx1
            // 
            this.cx1.Location = new System.Drawing.Point(105, 51);
            this.cx1.Name = "cx1";
            this.cx1.Size = new System.Drawing.Size(100, 20);
            this.cx1.TabIndex = 10;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(160, 141);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(128, 55);
            this.Calcular.TabIndex = 20;
            this.Calcular.Text = "Calcular Cos(Z1)";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 208);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cy2);
            this.Controls.Add(this.cx2);
            this.Controls.Add(this.cy1);
            this.Controls.Add(this.cx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Números Imaginarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cy2;
        private System.Windows.Forms.TextBox cx2;
        private System.Windows.Forms.TextBox cy1;
        private System.Windows.Forms.TextBox cx1;
        private System.Windows.Forms.Button Calcular;
    }
}

