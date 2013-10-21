using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador_5_20130918mascota
{
    public partial class Form1 : Form
    {
        double vida1;
        int n1, n3,n5, n6, n7, n8, n9, n10, fin;
        DateTime date1;
        public Form1()
        {
            InitializeComponent();
            vida1=10;
            fin = 0;
            Vida.Text = vida1.ToString();

            date1 = DateTime.Now;

            tex1.Text = DateTime.Now.ToString("hh:00:00");
            tex2.Text = DateTime.Now.ToString("hh:05:00");
            tex3.Text = DateTime.Now.ToString("hh:03:00");
            tex4.Text = DateTime.Now.ToString("hh:11:00");
            tex5.Text = DateTime.Now.ToString("hh:14:00");
            tex6.Text = DateTime.Now.ToString("hh:16:00");
            tex7.Text = DateTime.Now.ToString("hh:20:00");
            tex8.Text = DateTime.Now.ToString("hh:10:00");
            tex9.Text = DateTime.Now.ToString("hh:18:00");
            tex10.Text = DateTime.Now.ToString("hh:12:00");
            n1 = 0;
            n3 = 0;
            n5 = 0;
            n6 = 0;
            n7 = 0;
            n8 = 0;
            n9 = 0;
            n10 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Tiempo.Text = DateTime.Now.ToString("hh:mm:ss");            
                
            if (vida1 < 0 && fin==0)
            {
                fin = 1;
                vida1 = 1;
                Vida.Text = "_____________";
                Image image = Image.FromFile("img1.jpg");
                pic1.Image = image;
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                Tiempo.Text = "0";
                tex1.Text = "0";
                MessageBox.Show("Has descuidado a tu mascota");
            }

            if (fin == 0)
            {
                if (tex1.Text == Tiempo.Text)
                {
                   if (b1.Checked)
                   {
                       vida1 = vida1 + 10;
                   }
                   else
                   {
                       vida1  = vida1 - 100;
                   }
                   Vida.Text = vida1.ToString();
                   n1++;
                   if (n1 == 0) { tex1.Text = DateTime.Now.ToString("hh:20:00"); }
                   if (n1 == 1) { tex1.Text = DateTime.Now.ToString("hh:40:00"); }
                   if (n1 == 2) { tex2.Text = DateTime.Now.ToString("hh:00:00"); n1 = 0; }
                }

                if (tex2.Text == Tiempo.Text)
                {
                    if (b2.Checked)
                    {
                        vida1 = vida1 + 40;
                    }
                    else
                    {
                        vida1 = vida1 - 20;
                    }
                    Vida.Text = vida1.ToString();
                }

                if (tex3.Text == Tiempo.Text)
                {
                    if (b3.Checked)
                    {
                        vida1 = vida1 + 50;
                    }
                    else
                    {
                        vida1 = vida1 - 50;
                    }
                    Vida.Text = vida1.ToString();
                    n3++;
                    if (n3 == 0) { tex3.Text = DateTime.Now.ToString("hh:33:00"); }
                    if (n3 == 1) { tex3.Text = DateTime.Now.ToString("hh:03:00"); n3 = 0; }                 
               }

                if (tex4.Text == Tiempo.Text)
                {
                    if (b4.Checked)
                    {
                        vida1 = vida1 + 10;
                    }
                    else
                    {
                        vida1 = vida1 - 10;
                    }
                    Vida.Text = vida1.ToString();
                }

                if (tex5.Text == Tiempo.Text)
                {
                    if (b5.Checked)
                    {
                        vida1 = vida1 + 20;
                    }
                    else
                    {
                        vida1 = vida1 - 30;
                    }
                    Vida.Text = vida1.ToString();
                    n5++;
                    if (n5 == 0) { tex5.Text = DateTime.Now.ToString("hh:14:00"); }
                    if (n5 == 1) { tex5.Text = DateTime.Now.ToString("hh:44:00"); n5 = 0; }
                }

                if (tex6.Text == Tiempo.Text)
                {
                    if (b6.Checked)
                    {
                        vida1 = vida1 + 20;
                    }
                    else
                    {
                        vida1 = vida1 - 30;
                    }
                    Vida.Text = vida1.ToString();
                    n6++;
                    if (n6 == 0) { tex6.Text = DateTime.Now.ToString("hh:16:00"); }
                    if (n6 == 1) { tex6.Text = DateTime.Now.ToString("hh:16:20"); }
                    if (n6 == 2) { tex6.Text = DateTime.Now.ToString("hh:16:40"); n6 = 0; }
                }

                if (tex7.Text == Tiempo.Text)
                {
                    if (b7.Checked)
                    {
                        vida1 = vida1 + 20;
                    }
                    else
                    {
                        vida1 = vida1 - 30;
                    }
                    Vida.Text = vida1.ToString();
                    n7++;
                    if (n7 == 0) { tex7.Text = DateTime.Now.ToString("hh:20:00"); }
                    if (n7 == 1) { tex7.Text = DateTime.Now.ToString("hh:50:00"); n7 = 0; }
                }

                if (tex8.Text == Tiempo.Text)
                {
                    if (b8.Checked)
                    {
                        vida1 = vida1 + 20;
                    }
                    else
                    {
                        vida1 = vida1 - 30;
                    }
                    Vida.Text = vida1.ToString();
                    n8++;
                    if (n8 == 0) { tex8.Text = DateTime.Now.ToString("hh:10:00"); }
                    if (n8 == 1) { tex7.Text = DateTime.Now.ToString("hh:43:00"); n8 = 0; }
                }

                if (tex9.Text == Tiempo.Text)
                {
                    if (b9.Checked)
                    {
                        vida1 = vida1 + 20;
                    }
                    else
                    {
                        vida1 = vida1 - 30;
                    }
                    Vida.Text = vida1.ToString();
                    n9++;
                    if (n9 == 0) { tex9.Text = DateTime.Now.ToString("hh:28:00"); }
                    if (n9 == 1) { tex9.Text = DateTime.Now.ToString("hh:48:00"); }
                    if (n9 == 2) { tex9.Text = DateTime.Now.ToString("hh:18:00"); n9 = 0; }
                }

                if (tex10.Text == Tiempo.Text)
                {
                    if (b10.Checked)
                    {
                        vida1 = vida1 + 20;
                    }
                    else
                    {
                        vida1 = vida1 - 30;
                    }
                    Vida.Text = vida1.ToString();
                    n9++;
                    if (n9 == 0) { tex10.Text = DateTime.Now.ToString("hh:27:00"); }
                    if (n9 == 1) { tex10.Text = DateTime.Now.ToString("hh:12:00"); n9 = 0; }
                }
                
             }

        }
         
       

        private void button3_Click(object sender, EventArgs e)
        {
            vida1 = 1000;
            fin = 0;
            Vida.Text = vida1.ToString();
            Image image = Image.FromFile("charm.jpg");
            pic1.Image = image;
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
