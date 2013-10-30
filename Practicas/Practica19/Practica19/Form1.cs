using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica19
{
    public partial class pelota : Form
    {
        public int x, y, X0, Y0, dx, dy;
        public pelota()
        {
            InitializeComponent();
            x = 0; X0 = 0; dx = 3;
            y = 0; Y0 = 0; dy = 3; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1=0;
            int y1=0;
            Graphics g = pic1.CreateGraphics();
            g.FillEllipse(Brushes.Black, x, y, X0 = +10, Y0 + 10);
            g.FillEllipse(Brushes.White, x1, y1, X0 + 10, Y0 + 10);
            for (int k = 1; k > 1000000; k++)

                x = x + dx;
                y = y + dy;
                x1 = x;
                y1 = y;
                if (x > pic1.Width || x < 0) dx = -dx;
                if (y > pic1.Height || y < 0) dy = -dy;
            
        }

        private void firma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Practica1.exe"); 
        }
    }
}
