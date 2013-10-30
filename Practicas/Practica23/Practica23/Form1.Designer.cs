namespace Practica23
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
            this.Cuadros = new System.Windows.Forms.Button();
            this.Lineas = new System.Windows.Forms.Button();
            this.Puntos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Circulos = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.Lineas_aleatorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cuadros
            // 
            this.Cuadros.Location = new System.Drawing.Point(303, 482);
            this.Cuadros.Name = "Cuadros";
            this.Cuadros.Size = new System.Drawing.Size(110, 47);
            this.Cuadros.TabIndex = 14;
            this.Cuadros.Text = "Cuadros";
            this.Cuadros.UseVisualStyleBackColor = true;
            this.Cuadros.Click += new System.EventHandler(this.Cuadros_Click);
            // 
            // Lineas
            // 
            this.Lineas.Location = new System.Drawing.Point(159, 548);
            this.Lineas.Name = "Lineas";
            this.Lineas.Size = new System.Drawing.Size(110, 47);
            this.Lineas.TabIndex = 13;
            this.Lineas.Text = "Lineas";
            this.Lineas.UseVisualStyleBackColor = true;
            this.Lineas.Click += new System.EventHandler(this.Lineas_Click);
            // 
            // Puntos
            // 
            this.Puntos.Location = new System.Drawing.Point(159, 482);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(110, 47);
            this.Puntos.TabIndex = 12;
            this.Puntos.Text = "Puntos";
            this.Puntos.UseVisualStyleBackColor = true;
            this.Puntos.Click += new System.EventHandler(this.Puntos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Firma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Circulos
            // 
            this.Circulos.Location = new System.Drawing.Point(23, 482);
            this.Circulos.Name = "Circulos";
            this.Circulos.Size = new System.Drawing.Size(110, 47);
            this.Circulos.TabIndex = 10;
            this.Circulos.Text = "Circulos";
            this.Circulos.UseVisualStyleBackColor = true;
            this.Circulos.Click += new System.EventHandler(this.Circulos_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic1.Location = new System.Drawing.Point(23, 13);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(507, 463);
            this.pic1.TabIndex = 9;
            this.pic1.TabStop = false;
            // 
            // Lineas_aleatorias
            // 
            this.Lineas_aleatorias.Location = new System.Drawing.Point(23, 548);
            this.Lineas_aleatorias.Name = "Lineas_aleatorias";
            this.Lineas_aleatorias.Size = new System.Drawing.Size(110, 47);
            this.Lineas_aleatorias.TabIndex = 15;
            this.Lineas_aleatorias.Text = "Lineas aleatorias";
            this.Lineas_aleatorias.UseVisualStyleBackColor = true;
            this.Lineas_aleatorias.Click += new System.EventHandler(this.Lineas_aleatorias_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 601);
            this.Controls.Add(this.Lineas_aleatorias);
            this.Controls.Add(this.Cuadros);
            this.Controls.Add(this.Lineas);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Circulos);
            this.Controls.Add(this.pic1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficos";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cuadros;
        private System.Windows.Forms.Button Lineas;
        private System.Windows.Forms.Button Puntos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Circulos;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button Lineas_aleatorias;
    }
}

