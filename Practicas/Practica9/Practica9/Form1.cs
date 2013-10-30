using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ar = new OpenFileDialog();
            ar.ShowDialog();
            Player1.URL = ar.FileName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ar = new OpenFileDialog();
            ar.ShowDialog();
            string g = ar.FileName.ToString();
            PDF1.LoadFile(g);  
        }
    }
}
