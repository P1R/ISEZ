using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pic1.CreateGraphics();
            g.DrawEllipse(Pens.Blue, 10, 10, 100, 100);
            g.FillEllipse(Brushes.Red, 100,100,200,200); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }
    }
}
