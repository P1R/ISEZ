using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica11
{
    public partial class Form1 : Form
    {
        private double dx, dy, ry;
        public Form1()
        {
            InitializeComponent();
        }

        private void sen1_Click(object sender, EventArgs e)
        {
            dx = Double.Parse(cx1.Text);
            ry = Math.Sin(dx);
            cy1.Text = ry.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }
    }
}
