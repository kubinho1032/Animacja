using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animacja
{
    public partial class Form1 : Form
    {
        private int x = 40;
        private int y = 40;
        private int z1 = 1;
        private int z2 = 0;
        private int h1,h2;
        private int s_1_x=50;
        private int s_1_y = 260;
        private int s_2_x = 400;
        private int s_2_y = 150;
        Bitmap tlo, ludzik, saml, samp;

        public Form1()
        {
            InitializeComponent();
            h1 = this.Width-50;
            h2 = this.Width - 50;
            tlo = new Bitmap("tlo.bmp");
            ludzik = new Bitmap("ludzik.bmp");
            saml = new Bitmap("saml.bmp");
            samp = new Bitmap("samp.bmp");
            this.DoubleBuffered =true;  
            //ludzik.MakeTransparent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g=e.Graphics;
            g.DrawImage(ludzik, 50, 300);
            g.DrawImage(tlo, 0, 0);
            g.DrawImage(saml, s_1_x, s_1_y);
            g.DrawImage(samp, s_2_x, s_2_y);
;
        }

        private void napisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         // samochod 1   
            if (s_1_x >= h1)
            {
                z1=0;
            }
           
            if (s_1_x <= 0) { z1 = 1; }

            if (z1 == 1 && s_1_x <= h1)
            {
                s_1_x += 5;
            }
            if (z1 == 0 && s_1_x >= 0)
            {
                s_1_x -= 5;
            }

         // samochod 2 
            if (s_2_x >= h2)
            {
                z2 = 0;
            }

            if (s_2_x <= 0) { z2 = 1; }

            if (z2 == 1 && s_2_x <= h2)
            {
                s_2_x += 5;
            }
            if (z2 == 0 && s_2_x >= 0)
            {
                s_2_x -= 5;
            }

            Invalidate();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
