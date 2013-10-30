namespace Practica10
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
            this.firma = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Player = new System.Windows.Forms.TabPage();
            this.Player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Medio1 = new System.Windows.Forms.Button();
            this.PDF = new System.Windows.Forms.TabPage();
            this.PDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.Medio2 = new System.Windows.Forms.Button();
            this.Explorador = new System.Windows.Forms.TabPage();
            this.medio3 = new System.Windows.Forms.Button();
            this.nav1 = new AxSHDocVw.AxWebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Tab.SuspendLayout();
            this.Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.PDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).BeginInit();
            this.Explorador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nav1)).BeginInit();
            this.SuspendLayout();
            // 
            // firma
            // 
            this.firma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firma.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firma.Location = new System.Drawing.Point(1122, 583);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(111, 40);
            this.firma.TabIndex = 6;
            this.firma.Text = "Firma";
            this.firma.UseVisualStyleBackColor = false;
            this.firma.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Player);
            this.Tab.Controls.Add(this.PDF);
            this.Tab.Controls.Add(this.Explorador);
            this.Tab.Location = new System.Drawing.Point(12, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1221, 565);
            this.Tab.TabIndex = 5;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.LightCyan;
            this.Player.Controls.Add(this.Player1);
            this.Player.Controls.Add(this.Medio1);
            this.Player.Location = new System.Drawing.Point(4, 22);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(1213, 539);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            // 
            // Player1
            // 
            this.Player1.Enabled = true;
            this.Player1.Location = new System.Drawing.Point(22, 15);
            this.Player1.Name = "Player1";
            this.Player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player1.OcxState")));
            this.Player1.Size = new System.Drawing.Size(1171, 451);
            this.Player1.TabIndex = 2;
            // 
            // Medio1
            // 
            this.Medio1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Medio1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medio1.Location = new System.Drawing.Point(22, 499);
            this.Medio1.Name = "Medio1";
            this.Medio1.Size = new System.Drawing.Size(182, 34);
            this.Medio1.TabIndex = 1;
            this.Medio1.Text = "Medio";
            this.Medio1.UseVisualStyleBackColor = false;
            this.Medio1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDF
            // 
            this.PDF.BackColor = System.Drawing.Color.Thistle;
            this.PDF.Controls.Add(this.PDF1);
            this.PDF.Controls.Add(this.Medio2);
            this.PDF.Location = new System.Drawing.Point(4, 22);
            this.PDF.Name = "PDF";
            this.PDF.Padding = new System.Windows.Forms.Padding(3);
            this.PDF.Size = new System.Drawing.Size(1213, 539);
            this.PDF.TabIndex = 1;
            this.PDF.Text = "PDF";
            // 
            // PDF1
            // 
            this.PDF1.Enabled = true;
            this.PDF1.Location = new System.Drawing.Point(11, 13);
            this.PDF1.Name = "PDF1";
            this.PDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF1.OcxState")));
            this.PDF1.Size = new System.Drawing.Size(1185, 468);
            this.PDF1.TabIndex = 3;
            // 
            // Medio2
            // 
            this.Medio2.BackColor = System.Drawing.Color.LavenderBlush;
            this.Medio2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medio2.Location = new System.Drawing.Point(11, 499);
            this.Medio2.Name = "Medio2";
            this.Medio2.Size = new System.Drawing.Size(148, 34);
            this.Medio2.TabIndex = 2;
            this.Medio2.Text = "Medio";
            this.Medio2.UseVisualStyleBackColor = false;
            this.Medio2.Click += new System.EventHandler(this.button3_Click);
            // 
            // Explorador
            // 
            this.Explorador.Controls.Add(this.medio3);
            this.Explorador.Controls.Add(this.nav1);
            this.Explorador.Controls.Add(this.webBrowser2);
            this.Explorador.Controls.Add(this.webBrowser1);
            this.Explorador.Location = new System.Drawing.Point(4, 22);
            this.Explorador.Name = "Explorador";
            this.Explorador.Padding = new System.Windows.Forms.Padding(3);
            this.Explorador.Size = new System.Drawing.Size(1213, 539);
            this.Explorador.TabIndex = 2;
            this.Explorador.Text = "Explorador";
            this.Explorador.UseVisualStyleBackColor = true;
            // 
            // medio3
            // 
            this.medio3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.medio3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medio3.Location = new System.Drawing.Point(16, 490);
            this.medio3.Name = "medio3";
            this.medio3.Size = new System.Drawing.Size(182, 34);
            this.medio3.TabIndex = 3;
            this.medio3.Text = "Medio";
            this.medio3.UseVisualStyleBackColor = false;
            this.medio3.Click += new System.EventHandler(this.medio3_Click);
            // 
            // nav1
            // 
            this.nav1.Enabled = true;
            this.nav1.Location = new System.Drawing.Point(16, 37);
            this.nav1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("nav1.OcxState")));
            this.nav1.Size = new System.Drawing.Size(1175, 435);
            this.nav1.TabIndex = 2;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1207, 533);
            this.webBrowser2.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1207, 533);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1245, 635);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.Tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Tab.ResumeLayout(false);
            this.Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.PDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).EndInit();
            this.Explorador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nav1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firma;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.Button Medio1;
        private System.Windows.Forms.TabPage PDF;
        private System.Windows.Forms.Button Medio2;
        private AxWMPLib.AxWindowsMediaPlayer Player1;
        private AxAcroPDFLib.AxAcroPDF PDF1;
        private System.Windows.Forms.TabPage Explorador;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button medio3;
        private AxSHDocVw.AxWebBrowser nav1;
    }
}

