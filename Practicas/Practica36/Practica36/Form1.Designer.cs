namespace Practica36
{
    partial class OperacionesMatrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperacionesMatrices));
            this.cm = new System.Windows.Forms.TextBox();
            this.cn = new System.Windows.Forms.TextBox();
            this.ci = new System.Windows.Forms.TextBox();
            this.cj = new System.Windows.Forms.TextBox();
            this.elem = new System.Windows.Forms.TextBox();
            this.Tamaño = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Operaciones = new System.Windows.Forms.GroupBox();
            this.LBA = new System.Windows.Forms.ListBox();
            this.LBB = new System.Windows.Forms.ListBox();
            this.LBC = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rlA = new System.Windows.Forms.RadioButton();
            this.rlB = new System.Windows.Forms.RadioButton();
            this.rpA = new System.Windows.Forms.RadioButton();
            this.rpB = new System.Windows.Forms.RadioButton();
            this.rSum = new System.Windows.Forms.RadioButton();
            this.rpC = new System.Windows.Forms.RadioButton();
            this.Operación = new System.Windows.Forms.Button();
            this.Firma = new System.Windows.Forms.Button();
            this.Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cm
            // 
            this.cm.Location = new System.Drawing.Point(104, 32);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(41, 20);
            this.cm.TabIndex = 0;
            // 
            // cn
            // 
            this.cn.Location = new System.Drawing.Point(168, 32);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(41, 20);
            this.cn.TabIndex = 1;
            // 
            // ci
            // 
            this.ci.Location = new System.Drawing.Point(104, 103);
            this.ci.Name = "ci";
            this.ci.Size = new System.Drawing.Size(41, 20);
            this.ci.TabIndex = 2;
            // 
            // cj
            // 
            this.cj.Location = new System.Drawing.Point(168, 103);
            this.cj.Name = "cj";
            this.cj.Size = new System.Drawing.Size(41, 20);
            this.cj.TabIndex = 3;
            // 
            // elem
            // 
            this.elem.Location = new System.Drawing.Point(109, 159);
            this.elem.Name = "elem";
            this.elem.Size = new System.Drawing.Size(100, 20);
            this.elem.TabIndex = 4;
            // 
            // Tamaño
            // 
            this.Tamaño.Location = new System.Drawing.Point(12, 32);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(75, 59);
            this.Tamaño.TabIndex = 5;
            this.Tamaño.Text = "Tamaño";
            this.Tamaño.UseVisualStyleBackColor = true;
            this.Tamaño.Click += new System.EventHandler(this.Tamaño_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "i";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "j";
            // 
            // Operaciones
            // 
            this.Operaciones.Controls.Add(this.rpC);
            this.Operaciones.Controls.Add(this.rSum);
            this.Operaciones.Controls.Add(this.rpB);
            this.Operaciones.Controls.Add(this.rpA);
            this.Operaciones.Controls.Add(this.rlB);
            this.Operaciones.Controls.Add(this.rlA);
            this.Operaciones.Location = new System.Drawing.Point(12, 243);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Size = new System.Drawing.Size(200, 238);
            this.Operaciones.TabIndex = 10;
            this.Operaciones.TabStop = false;
            this.Operaciones.Text = "Operaciones";
            // 
            // LBA
            // 
            this.LBA.FormattingEnabled = true;
            this.LBA.Location = new System.Drawing.Point(313, 32);
            this.LBA.Name = "LBA";
            this.LBA.Size = new System.Drawing.Size(120, 212);
            this.LBA.TabIndex = 11;
            // 
            // LBB
            // 
            this.LBB.FormattingEnabled = true;
            this.LBB.Location = new System.Drawing.Point(481, 32);
            this.LBB.Name = "LBB";
            this.LBB.Size = new System.Drawing.Size(120, 212);
            this.LBB.TabIndex = 12;
            // 
            // LBC
            // 
            this.LBC.FormattingEnabled = true;
            this.LBC.Location = new System.Drawing.Point(646, 32);
            this.LBC.Name = "LBC";
            this.LBC.Size = new System.Drawing.Size(120, 212);
            this.LBC.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Elemento";
            // 
            // rlA
            // 
            this.rlA.AutoSize = true;
            this.rlA.Location = new System.Drawing.Point(43, 31);
            this.rlA.Name = "rlA";
            this.rlA.Size = new System.Drawing.Size(53, 17);
            this.rlA.TabIndex = 18;
            this.rlA.TabStop = true;
            this.rlA.Text = "Lee A";
            this.rlA.UseVisualStyleBackColor = true;
            // 
            // rlB
            // 
            this.rlB.AutoSize = true;
            this.rlB.Location = new System.Drawing.Point(43, 65);
            this.rlB.Name = "rlB";
            this.rlB.Size = new System.Drawing.Size(53, 17);
            this.rlB.TabIndex = 19;
            this.rlB.TabStop = true;
            this.rlB.Text = "Lee B";
            this.rlB.UseVisualStyleBackColor = true;
            // 
            // rpA
            // 
            this.rpA.AutoSize = true;
            this.rpA.Location = new System.Drawing.Point(43, 103);
            this.rpA.Name = "rpA";
            this.rpA.Size = new System.Drawing.Size(54, 17);
            this.rpA.TabIndex = 19;
            this.rpA.TabStop = true;
            this.rpA.Text = "Pon A";
            this.rpA.UseVisualStyleBackColor = true;
            // 
            // rpB
            // 
            this.rpB.AutoSize = true;
            this.rpB.Location = new System.Drawing.Point(43, 137);
            this.rpB.Name = "rpB";
            this.rpB.Size = new System.Drawing.Size(54, 17);
            this.rpB.TabIndex = 19;
            this.rpB.TabStop = true;
            this.rpB.Text = "Pon B";
            this.rpB.UseVisualStyleBackColor = true;
            // 
            // rSum
            // 
            this.rSum.AutoSize = true;
            this.rSum.Location = new System.Drawing.Point(43, 201);
            this.rSum.Name = "rSum";
            this.rSum.Size = new System.Drawing.Size(70, 17);
            this.rSum.TabIndex = 20;
            this.rSum.TabStop = true;
            this.rSum.Text = "C = A + B";
            this.rSum.UseVisualStyleBackColor = true;
            // 
            // rpC
            // 
            this.rpC.AutoSize = true;
            this.rpC.Location = new System.Drawing.Point(43, 169);
            this.rpC.Name = "rpC";
            this.rpC.Size = new System.Drawing.Size(54, 17);
            this.rpC.TabIndex = 21;
            this.rpC.TabStop = true;
            this.rpC.Text = "Pon C";
            this.rpC.UseVisualStyleBackColor = true;
            // 
            // Operación
            // 
            this.Operación.Location = new System.Drawing.Point(245, 302);
            this.Operación.Name = "Operación";
            this.Operación.Size = new System.Drawing.Size(199, 104);
            this.Operación.TabIndex = 18;
            this.Operación.Text = "Operación";
            this.Operación.UseVisualStyleBackColor = true;
            this.Operación.Click += new System.EventHandler(this.Operación_Click);
            // 
            // Firma
            // 
            this.Firma.Location = new System.Drawing.Point(690, 457);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(75, 38);
            this.Firma.TabIndex = 19;
            this.Firma.Text = "Firma";
            this.Firma.UseVisualStyleBackColor = true;
            // 
            // OperacionesMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 507);
            this.Controls.Add(this.Firma);
            this.Controls.Add(this.Operación);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBC);
            this.Controls.Add(this.LBB);
            this.Controls.Add(this.LBA);
            this.Controls.Add(this.Operaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tamaño);
            this.Controls.Add(this.elem);
            this.Controls.Add(this.cj);
            this.Controls.Add(this.ci);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.cm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OperacionesMatrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrices";
            this.Operaciones.ResumeLayout(false);
            this.Operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cm;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox ci;
        private System.Windows.Forms.TextBox cj;
        private System.Windows.Forms.TextBox elem;
        private System.Windows.Forms.Button Tamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Operaciones;
        private System.Windows.Forms.ListBox LBA;
        private System.Windows.Forms.ListBox LBB;
        private System.Windows.Forms.ListBox LBC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rSum;
        private System.Windows.Forms.RadioButton rpB;
        private System.Windows.Forms.RadioButton rpA;
        private System.Windows.Forms.RadioButton rlB;
        private System.Windows.Forms.RadioButton rlA;
        private System.Windows.Forms.RadioButton rpC;
        private System.Windows.Forms.Button Operación;
        private System.Windows.Forms.Button Firma;
    }
}

