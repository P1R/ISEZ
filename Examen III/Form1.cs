using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen_III
{
    public partial class Form1 : Form
    {
        int m, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void filas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tamaño_Click(object sender, EventArgs e)
        {
            m = Int32.Parse(filas.Text);
            n = Int32.Parse(columnas.Text);

        }
    }
}
