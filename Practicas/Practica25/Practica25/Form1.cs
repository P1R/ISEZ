using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica25
{
    public partial class Trazo : Form
    {
        public Boolean rata;
        public Trazo()
        {
            InitializeComponent();
        }

        private void pic1_MouseUp(object sender, MouseEventArgs e)
        {
            rata = false;
        }

        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            rata = true;
        }

        private void pic1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pic1.CreateGraphics();
            if (rata)
                g.DrawLine(Pens.Black, e.X, e.Y, e.X + 1, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe"); 
        }
    }
}
