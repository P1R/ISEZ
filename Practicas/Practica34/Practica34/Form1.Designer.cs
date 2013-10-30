namespace Practica34
{
    partial class GraficadoraF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraficadoraF));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.Xf = new System.Windows.Forms.TextBox();
            this.Xi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Firma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic1.Location = new System.Drawing.Point(260, 15);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(553, 252);
            this.pic1.TabIndex = 15;
            this.pic1.TabStop = false;
            // 
            // Xf
            // 
            this.Xf.Location = new System.Drawing.Point(82, 74);
            this.Xf.Name = "Xf";
            this.Xf.Size = new System.Drawing.Size(131, 20);
            this.Xf.TabIndex = 21;
            this.Xf.Text = "10";
            // 
            // Xi
            // 
            this.Xi.Location = new System.Drawing.Point(82, 26);
            this.Xi.Name = "Xi";
            this.Xi.Size = new System.Drawing.Size(131, 20);
            this.Xi.TabIndex = 20;
            this.Xi.Text = "-10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Xf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Xi";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "0;1";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "cos(t)",
            "sen(t)"});
            this.listBox1.Location = new System.Drawing.Point(37, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(176, 160);
            this.listBox1.TabIndex = 26;
            this.listBox1.ValueMember = "0;1";
            // 
            // Firma
            // 
            this.Firma.Location = new System.Drawing.Point(682, 286);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(131, 23);
            this.Firma.TabIndex = 27;
            this.Firma.Text = "Firma";
            this.Firma.UseVisualStyleBackColor = true;
            this.Firma.Click += new System.EventHandler(this.Firma_Click);
            // 
            // GraficadoraF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 321);
            this.Controls.Add(this.Firma);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Xf);
            this.Controls.Add(this.Xi);
            this.Controls.Add(this.pic1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GraficadoraF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficadora de Funciones";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.TextBox Xf;
        private System.Windows.Forms.TextBox Xi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Firma;
    }
}

