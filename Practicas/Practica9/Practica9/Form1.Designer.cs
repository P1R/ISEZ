namespace Practica9
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
            this.button2 = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.Player = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.PDF = new System.Windows.Forms.TabPage();
            this.Player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.button3 = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.Player.SuspendLayout();
            this.PDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(579, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Firma";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.Player);
            this.Tab.Controls.Add(this.PDF);
            this.Tab.Location = new System.Drawing.Point(18, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(672, 415);
            this.Tab.TabIndex = 3;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.LightCyan;
            this.Player.Controls.Add(this.Player1);
            this.Player.Controls.Add(this.button1);
            this.Player.Location = new System.Drawing.Point(4, 22);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(664, 389);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Medio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDF
            // 
            this.PDF.BackColor = System.Drawing.Color.Thistle;
            this.PDF.Controls.Add(this.button3);
            this.PDF.Controls.Add(this.PDF1);
            this.PDF.Location = new System.Drawing.Point(4, 22);
            this.PDF.Name = "PDF";
            this.PDF.Padding = new System.Windows.Forms.Padding(3);
            this.PDF.Size = new System.Drawing.Size(664, 389);
            this.PDF.TabIndex = 1;
            this.PDF.Text = "PDF";
            // 
            // Player1
            // 
            this.Player1.Enabled = true;
            this.Player1.Location = new System.Drawing.Point(22, 6);
            this.Player1.Name = "Player1";
            this.Player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player1.OcxState")));
            this.Player1.Size = new System.Drawing.Size(627, 328);
            this.Player1.TabIndex = 2;
            // 
            // PDF1
            // 
            this.PDF1.Enabled = true;
            this.PDF1.Location = new System.Drawing.Point(27, 6);
            this.PDF1.Name = "PDF1";
            this.PDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF1.OcxState")));
            this.PDF1.Size = new System.Drawing.Size(448, 360);
            this.PDF1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(495, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Medio";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tab);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Tab.ResumeLayout(false);
            this.Player.ResumeLayout(false);
            this.PDF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage PDF;
        private AxWMPLib.AxWindowsMediaPlayer Player1;
        private System.Windows.Forms.Button button3;
        private AxAcroPDFLib.AxAcroPDF PDF1;
    }
}

