namespace Practica11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cx1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cy1 = new System.Windows.Forms.TextBox();
            this.sen1 = new System.Windows.Forms.Button();
            this.firma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cx1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS";
            // 
            // cx1
            // 
            this.cx1.Location = new System.Drawing.Point(60, 34);
            this.cx1.Name = "cx1";
            this.cx1.Size = new System.Drawing.Size(100, 20);
            this.cx1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cy1);
            this.groupBox2.Location = new System.Drawing.Point(279, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTADO";
            // 
            // cy1
            // 
            this.cy1.Location = new System.Drawing.Point(6, 42);
            this.cy1.Name = "cy1";
            this.cy1.Size = new System.Drawing.Size(188, 20);
            this.cy1.TabIndex = 1;
            // 
            // sen1
            // 
            this.sen1.BackColor = System.Drawing.Color.Aquamarine;
            this.sen1.Location = new System.Drawing.Point(45, 153);
            this.sen1.Name = "sen1";
            this.sen1.Size = new System.Drawing.Size(177, 24);
            this.sen1.TabIndex = 2;
            this.sen1.Text = "Sen";
            this.sen1.UseVisualStyleBackColor = false;
            this.sen1.Click += new System.EventHandler(this.sen1_Click);
            // 
            // firma
            // 
            this.firma.BackColor = System.Drawing.Color.MediumTurquoise;
            this.firma.Location = new System.Drawing.Point(404, 214);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(75, 23);
            this.firma.TabIndex = 12;
            this.firma.Text = "Firma";
            this.firma.UseVisualStyleBackColor = false;
            this.firma.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(500, 252);
            this.Controls.Add(this.sen1);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cy1;
        private System.Windows.Forms.Button sen1;
        private System.Windows.Forms.Button firma;
    }
}

