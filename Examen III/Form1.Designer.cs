namespace Examen_III
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.A = new System.Windows.Forms.DataGridView();
            this.B = new System.Windows.Forms.DataGridView();
            this.C = new System.Windows.Forms.DataGridView();
            this.tamaño = new System.Windows.Forms.Button();
            this.filas = new System.Windows.Forms.TextBox();
            this.columnas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).BeginInit();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A.Location = new System.Drawing.Point(135, 48);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(240, 211);
            this.A.TabIndex = 0;
            // 
            // B
            // 
            this.B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B.Location = new System.Drawing.Point(440, 48);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(240, 211);
            this.B.TabIndex = 1;
            // 
            // C
            // 
            this.C.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C.Location = new System.Drawing.Point(736, 48);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(240, 211);
            this.C.TabIndex = 2;
            // 
            // tamaño
            // 
            this.tamaño.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tamaño.Location = new System.Drawing.Point(208, 312);
            this.tamaño.Name = "tamaño";
            this.tamaño.Size = new System.Drawing.Size(98, 32);
            this.tamaño.TabIndex = 3;
            this.tamaño.Text = "Tamaño";
            this.tamaño.UseVisualStyleBackColor = true;
            this.tamaño.Click += new System.EventHandler(this.tamaño_Click);
            // 
            // filas
            // 
            this.filas.Location = new System.Drawing.Point(163, 275);
            this.filas.Name = "filas";
            this.filas.Size = new System.Drawing.Size(69, 20);
            this.filas.TabIndex = 4;
            this.filas.TextChanged += new System.EventHandler(this.filas_TextChanged);
            // 
            // columnas
            // 
            this.columnas.Location = new System.Drawing.Point(303, 276);
            this.columnas.Name = "columnas";
            this.columnas.Size = new System.Drawing.Size(72, 20);
            this.columnas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(133, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "m:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(277, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(241, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(542, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "B^t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(833, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "P";
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calcular.FlatAppearance.BorderSize = 2;
            this.calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcular.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.calcular.Location = new System.Drawing.Point(612, 312);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(200, 32);
            this.calcular.TabIndex = 11;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1119, 420);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnas);
            this.Controls.Add(this.filas);
            this.Controls.Add(this.tamaño);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView A;
        private System.Windows.Forms.DataGridView B;
        private System.Windows.Forms.DataGridView C;
        private System.Windows.Forms.Button tamaño;
        private System.Windows.Forms.TextBox filas;
        private System.Windows.Forms.TextBox columnas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcular;
    }
}

