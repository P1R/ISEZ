using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica16
{
    public partial class Temporizador : Form
    {
        public Temporizador()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo.Text = DateTime.Now.ToString("dd/MM/yyyy-hh:mm:ss:f");
            if (activar.Checked)
            {
                if(Alarma.Text==tiempo.Text )
                {
                MessageBox.Show("Alarma");
                System.Diagnostics.Process.Start("07.mp3"); 
                }
            }
        }

        private void firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }
    }
}
