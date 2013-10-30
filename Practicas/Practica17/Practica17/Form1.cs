using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica17
{
    public partial class LTiemer : Form
    {
        public LTiemer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo.Text = DateTime.Now.ToString("dd/MM/yyyy-hh:mm:ss:f");

            if (activar1.Checked)
            {
                if (lanzar1.Text == tiempo.Text)
                {
                    MessageBox.Show("Bloc de Notas");
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
                }
            }

            if (activar2.Checked)
            {
                if (lanzar2.Text == tiempo.Text)
                {
                    MessageBox.Show("Internet Explorer");
                    System.Diagnostics.Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe");
                }
            }

           if (activar3.Checked)
            {
                if (lanzar3.Text == tiempo.Text)
                {
                    MessageBox.Show("Paint");
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
                }
            }

            if (activar4.Checked)
            {
                if (lanzar4.Text == tiempo.Text)
                {
                    MessageBox.Show("Calculadora");
                    System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
                }
            }

            if (activar5.Checked)
            {
                if (lanzar5.Text == tiempo.Text)
                {
                    MessageBox.Show("Reproductor Windows Media");
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows Media Player\wmplayer.exe");
                }
            }

            if (activar6.Checked)
            {
                if (lanzar6.Text == tiempo.Text)
                {
                    MessageBox.Show("Word Pad");
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Windows NT\Accessories\wordpad.exe");
                }
            }

            if (activar7.Checked)
            {
                if (lanzar7.Text == tiempo.Text)
                {
                    MessageBox.Show("Office Word ");
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\Office15\WINWORD.exe");
                }
            }

            if (activar8.Checked)
            {
                if (lanzar8.Text == tiempo.Text)
                {
                    MessageBox.Show("Office Powerpaint ");
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\Office15\POWERPNT.exe");
                }
            }

            if (activar9.Checked)
            {
                if (lanzar9.Text == tiempo.Text)
                {
                    MessageBox.Show("Office Excel ");
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Microsoft Office\Office15\EXCEL.exe");
                }
            }

           if (activar10.Checked)
            {
                if (lanzar10.Text == tiempo.Text)
                {
                    MessageBox.Show("iTunes");
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\iTunes\iTunes.exe");
                }
            }

        }

        private void firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }
    }
}
