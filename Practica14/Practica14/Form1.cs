using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica14
{
    public partial class Form1 : Form
    {
        private double dx, ry;
        public Form1()
        {
            InitializeComponent();
            Cx1.Text = "0.0";
        }

        private void sen_Click(object sender, EventArgs e)
        {
            //dx = Convert.ToDouble(Cx1.Text);
            dx = double.Parse(Cx1.Text);
            ry = Math.Sin(dx);
            Cy1.Text = ry.ToString();
        }
    }
}
