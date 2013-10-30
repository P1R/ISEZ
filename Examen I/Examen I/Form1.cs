using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_I
{
    public partial class Form1 : Form
    {
        Computadoras A = new Computadoras();
        SistemaOperativo B = new SistemaOperativo();
        Estudiantes C = new Estudiantes();
        Edad D = new Edad();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                A.Arch = textBox1.Text;
                label1.Text = A.Arch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B.lee(textBox1.Text);
            label1.Text = B.imprime();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C.Name = textBox2.Text;
            label2.Text = C.Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            D.lee(textBox2.Text);
            label2.Text = D.imprime();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            textBox2.Text = "";
            label2.Text = "";
        }

    }
    public partial class Computadoras
    {
        private string arquitectura;
        protected string OS;
        public string Arch
        {
            set
            {
                arquitectura = value;
            }
            get
            {
                return(arquitectura);
            }
        }
    }
    public partial class SistemaOperativo: Computadoras
    {
        public void lee(string L)
        {
            OS = L;
        }
        public string imprime()
        {
            return OS;
        }
    }
    public partial class Estudiantes
    {
        private string Nombre;
        protected string boleta;
        public string Name
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return(Nombre);
            }
        }
    }
    public partial class Edad : Estudiantes
    {
        public void lee(string L)
        {
            boleta = L;
        }
        public string imprime()
        {
            return(boleta);
        }
    }
}
