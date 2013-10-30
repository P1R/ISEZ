namespace Practica37
{
    partial class OpMatrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpMatrices));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transpC = new System.Windows.Forms.RadioButton();
            this.resC = new System.Windows.Forms.RadioButton();
            this.matAC = new System.Windows.Forms.DataGridView();
            this.TamañoAC = new System.Windows.Forms.Button();
            this.CalcularC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matBC = new System.Windows.Forms.DataGridView();
            this.mac = new System.Windows.Forms.TextBox();
            this.nac = new System.Windows.Forms.TextBox();
            this.mbc = new System.Windows.Forms.TextBox();
            this.nbc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.matPC = new System.Windows.Forms.DataGridView();
            this.TamañoBC = new System.Windows.Forms.Button();
            this.MatricesR = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rse = new System.Windows.Forms.RadioButton();
            this.transp = new System.Windows.Forms.RadioButton();
            this.res = new System.Windows.Forms.RadioButton();
            this.matA = new System.Windows.Forms.DataGridView();
            this.Tamaño = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matB = new System.Windows.Forms.DataGridView();
            this.cm = new System.Windows.Forms.TextBox();
            this.cn = new System.Windows.Forms.TextBox();
            this.cmb = new System.Windows.Forms.TextBox();
            this.cnb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.matP = new System.Windows.Forms.DataGridView();
            this.TamañoB = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matPC)).BeginInit();
            this.MatricesR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matP)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.TamañoBC);
            this.tabPage1.Controls.Add(this.matPC);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nbc);
            this.tabPage1.Controls.Add(this.mbc);
            this.tabPage1.Controls.Add(this.nac);
            this.tabPage1.Controls.Add(this.mac);
            this.tabPage1.Controls.Add(this.matBC);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.CalcularC);
            this.tabPage1.Controls.Add(this.TamañoAC);
            this.tabPage1.Controls.Add(this.matAC);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 578);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Matrices complejas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resC);
            this.groupBox2.Controls.Add(this.transpC);
            this.groupBox2.Location = new System.Drawing.Point(33, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 185);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opreaciones";
            // 
            // transpC
            // 
            this.transpC.AutoSize = true;
            this.transpC.Location = new System.Drawing.Point(9, 41);
            this.transpC.Name = "transpC";
            this.transpC.Size = new System.Drawing.Size(109, 17);
            this.transpC.TabIndex = 9;
            this.transpC.TabStop = true;
            this.transpC.Text = "Transpuesta de A";
            this.transpC.UseVisualStyleBackColor = true;
            // 
            // resC
            // 
            this.resC.AutoSize = true;
            this.resC.Location = new System.Drawing.Point(9, 64);
            this.resC.Name = "resC";
            this.resC.Size = new System.Drawing.Size(79, 17);
            this.resC.TabIndex = 10;
            this.resC.TabStop = true;
            this.resC.Text = "P = A- B^-1";
            this.resC.UseVisualStyleBackColor = true;
            // 
            // matAC
            // 
            this.matAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matAC.Location = new System.Drawing.Point(193, 25);
            this.matAC.Name = "matAC";
            this.matAC.Size = new System.Drawing.Size(296, 255);
            this.matAC.TabIndex = 16;
            // 
            // TamañoAC
            // 
            this.TamañoAC.Location = new System.Drawing.Point(28, 378);
            this.TamañoAC.Name = "TamañoAC";
            this.TamañoAC.Size = new System.Drawing.Size(105, 36);
            this.TamañoAC.TabIndex = 17;
            this.TamañoAC.Text = "Tamaño A";
            this.TamañoAC.UseVisualStyleBackColor = true;
            this.TamañoAC.Click += new System.EventHandler(this.TamañoAC_Click);
            // 
            // CalcularC
            // 
            this.CalcularC.Location = new System.Drawing.Point(32, 218);
            this.CalcularC.Name = "CalcularC";
            this.CalcularC.Size = new System.Drawing.Size(110, 94);
            this.CalcularC.TabIndex = 18;
            this.CalcularC.Text = "Calcular";
            this.CalcularC.UseVisualStyleBackColor = true;
            this.CalcularC.Click += new System.EventHandler(this.CalcularC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "n";
            // 
            // matBC
            // 
            this.matBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matBC.Location = new System.Drawing.Point(193, 307);
            this.matBC.Name = "matBC";
            this.matBC.Size = new System.Drawing.Size(304, 255);
            this.matBC.TabIndex = 23;
            // 
            // mac
            // 
            this.mac.Location = new System.Drawing.Point(42, 351);
            this.mac.Name = "mac";
            this.mac.Size = new System.Drawing.Size(35, 20);
            this.mac.TabIndex = 21;
            this.mac.Text = "2";
            // 
            // nac
            // 
            this.nac.Location = new System.Drawing.Point(80, 351);
            this.nac.Name = "nac";
            this.nac.Size = new System.Drawing.Size(34, 20);
            this.nac.TabIndex = 22;
            this.nac.Text = "2";
            // 
            // mbc
            // 
            this.mbc.Location = new System.Drawing.Point(42, 458);
            this.mbc.Name = "mbc";
            this.mbc.Size = new System.Drawing.Size(35, 20);
            this.mbc.TabIndex = 24;
            this.mbc.Text = "2";
            // 
            // nbc
            // 
            this.nbc.Location = new System.Drawing.Point(80, 458);
            this.nbc.Name = "nbc";
            this.nbc.Size = new System.Drawing.Size(34, 20);
            this.nbc.TabIndex = 25;
            this.nbc.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "n";
            // 
            // matPC
            // 
            this.matPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matPC.Location = new System.Drawing.Point(537, 25);
            this.matPC.Name = "matPC";
            this.matPC.Size = new System.Drawing.Size(295, 255);
            this.matPC.TabIndex = 28;
            // 
            // TamañoBC
            // 
            this.TamañoBC.Location = new System.Drawing.Point(28, 484);
            this.TamañoBC.Name = "TamañoBC";
            this.TamañoBC.Size = new System.Drawing.Size(100, 36);
            this.TamañoBC.TabIndex = 29;
            this.TamañoBC.Text = "Tamaño B";
            this.TamañoBC.UseVisualStyleBackColor = true;
            this.TamañoBC.Click += new System.EventHandler(this.TamañoBC_Click);
            // 
            // MatricesR
            // 
            this.MatricesR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MatricesR.Controls.Add(this.TamañoB);
            this.MatricesR.Controls.Add(this.matP);
            this.MatricesR.Controls.Add(this.label3);
            this.MatricesR.Controls.Add(this.label4);
            this.MatricesR.Controls.Add(this.cnb);
            this.MatricesR.Controls.Add(this.cmb);
            this.MatricesR.Controls.Add(this.cn);
            this.MatricesR.Controls.Add(this.cm);
            this.MatricesR.Controls.Add(this.matB);
            this.MatricesR.Controls.Add(this.label2);
            this.MatricesR.Controls.Add(this.label1);
            this.MatricesR.Controls.Add(this.Calcular);
            this.MatricesR.Controls.Add(this.Tamaño);
            this.MatricesR.Controls.Add(this.matA);
            this.MatricesR.Controls.Add(this.groupBox1);
            this.MatricesR.Location = new System.Drawing.Point(4, 22);
            this.MatricesR.Name = "MatricesR";
            this.MatricesR.Padding = new System.Windows.Forms.Padding(3);
            this.MatricesR.Size = new System.Drawing.Size(860, 578);
            this.MatricesR.TabIndex = 0;
            this.MatricesR.Text = "Matrices reales";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.res);
            this.groupBox1.Controls.Add(this.transp);
            this.groupBox1.Controls.Add(this.rse);
            this.groupBox1.Location = new System.Drawing.Point(33, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 185);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opreaciones";
            // 
            // rse
            // 
            this.rse.AutoSize = true;
            this.rse.Location = new System.Drawing.Point(9, 18);
            this.rse.Name = "rse";
            this.rse.Size = new System.Drawing.Size(67, 17);
            this.rse.TabIndex = 8;
            this.rse.TabStop = true;
            this.rse.Text = "Sol. Ecs.";
            this.rse.UseVisualStyleBackColor = true;
            // 
            // transp
            // 
            this.transp.AutoSize = true;
            this.transp.Location = new System.Drawing.Point(9, 41);
            this.transp.Name = "transp";
            this.transp.Size = new System.Drawing.Size(109, 17);
            this.transp.TabIndex = 9;
            this.transp.TabStop = true;
            this.transp.Text = "Transpuesta de A";
            this.transp.UseVisualStyleBackColor = true;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(9, 64);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(79, 17);
            this.res.TabIndex = 10;
            this.res.TabStop = true;
            this.res.Text = "P = A- B^-1";
            this.res.UseVisualStyleBackColor = true;
            // 
            // matA
            // 
            this.matA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matA.Location = new System.Drawing.Point(193, 25);
            this.matA.Name = "matA";
            this.matA.Size = new System.Drawing.Size(296, 255);
            this.matA.TabIndex = 16;
            // 
            // Tamaño
            // 
            this.Tamaño.Location = new System.Drawing.Point(28, 378);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(105, 36);
            this.Tamaño.TabIndex = 17;
            this.Tamaño.Text = "Tamaño A";
            this.Tamaño.UseVisualStyleBackColor = true;
            this.Tamaño.Click += new System.EventHandler(this.Tamaño_Click_1);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(32, 218);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(110, 94);
            this.Calcular.TabIndex = 18;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "n";
            // 
            // matB
            // 
            this.matB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matB.Location = new System.Drawing.Point(193, 307);
            this.matB.Name = "matB";
            this.matB.Size = new System.Drawing.Size(304, 255);
            this.matB.TabIndex = 23;
            // 
            // cm
            // 
            this.cm.Location = new System.Drawing.Point(42, 351);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(35, 20);
            this.cm.TabIndex = 21;
            this.cm.Text = "2";
            // 
            // cn
            // 
            this.cn.Location = new System.Drawing.Point(80, 351);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(34, 20);
            this.cn.TabIndex = 22;
            this.cn.Text = "2";
            // 
            // cmb
            // 
            this.cmb.Location = new System.Drawing.Point(42, 458);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(35, 20);
            this.cmb.TabIndex = 24;
            this.cmb.Text = "2";
            // 
            // cnb
            // 
            this.cnb.Location = new System.Drawing.Point(80, 458);
            this.cnb.Name = "cnb";
            this.cnb.Size = new System.Drawing.Size(34, 20);
            this.cnb.TabIndex = 25;
            this.cnb.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "n";
            // 
            // matP
            // 
            this.matP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matP.Location = new System.Drawing.Point(537, 25);
            this.matP.Name = "matP";
            this.matP.Size = new System.Drawing.Size(295, 255);
            this.matP.TabIndex = 28;
            // 
            // TamañoB
            // 
            this.TamañoB.Location = new System.Drawing.Point(28, 484);
            this.TamañoB.Name = "TamañoB";
            this.TamañoB.Size = new System.Drawing.Size(100, 36);
            this.TamañoB.TabIndex = 29;
            this.TamañoB.Text = "Tamaño B";
            this.TamañoB.UseVisualStyleBackColor = true;
            this.TamañoB.Click += new System.EventHandler(this.TamañoB_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MatricesR);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // OpMatrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 627);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "OpMatrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrices con DataGrid";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matPC)).EndInit();
            this.MatricesR.ResumeLayout(false);
            this.MatricesR.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matP)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button TamañoBC;
        private System.Windows.Forms.DataGridView matPC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nbc;
        private System.Windows.Forms.TextBox mbc;
        private System.Windows.Forms.TextBox nac;
        private System.Windows.Forms.TextBox mac;
        private System.Windows.Forms.DataGridView matBC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalcularC;
        private System.Windows.Forms.Button TamañoAC;
        private System.Windows.Forms.DataGridView matAC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton resC;
        private System.Windows.Forms.RadioButton transpC;
        private System.Windows.Forms.TabPage MatricesR;
        private System.Windows.Forms.Button TamañoB;
        private System.Windows.Forms.DataGridView matP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cnb;
        private System.Windows.Forms.TextBox cmb;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox cm;
        private System.Windows.Forms.DataGridView matB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Tamaño;
        private System.Windows.Forms.DataGridView matA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton res;
        private System.Windows.Forms.RadioButton transp;
        private System.Windows.Forms.RadioButton rse;
        private System.Windows.Forms.TabControl tabControl1;


    }
}

