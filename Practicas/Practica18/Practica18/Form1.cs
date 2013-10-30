using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica18
{
    public partial class repetidor : Form
    {
        public int i;
        public repetidor()
        {
                i=0;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic1.Width = i;
            pic1.Height = i;
            pic1.Left = i;
            pic1.Top = i;
            i++;
        }

        private void firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe");
        }


    }
}
