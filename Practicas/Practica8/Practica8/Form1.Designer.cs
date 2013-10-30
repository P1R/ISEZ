namespace Practica8
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.Player = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.Player);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(21, 26);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(672, 415);
            this.tab1.TabIndex = 0;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.LightCyan;
            this.Player.Controls.Add(this.button1);
            this.Player.Controls.Add(this.Player1);
            this.Player.Location = new System.Drawing.Point(4, 22);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(664, 389);
            this.Player.TabIndex = 0;
            this.Player.Text = "Player";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Player1
            // 
            this.Player1.Enabled = true;
            this.Player1.Location = new System.Drawing.Point(22, 25);
            this.Player1.Name = "Player1";
            this.Player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player1.OcxState")));
            this.Player1.Size = new System.Drawing.Size(620, 294);
            this.Player1.TabIndex = 0;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(580, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Firma";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(705, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.tab1.ResumeLayout(false);
            this.Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.TabPage tabPage2;
        private AxWMPLib.AxWindowsMediaPlayer Player1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

