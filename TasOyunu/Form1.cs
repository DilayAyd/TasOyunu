using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics tahta;
            tahta = this.CreateGraphics();
            SolidBrush renk1 = new SolidBrush(Color.MintCream);
            SolidBrush renk2 = new SolidBrush(Color.DarkSlateGray);

            int a = 0;
            for (int i = 0; i < 400; i = i + 100)
            {
                for (int k = 0; k <= 7; k++)
                {
                    if (a == 0)
                    {
                        tahta.FillRectangle(renk1, i, (k * 50), 50, 50);
                        tahta.FillRectangle(renk2, i + 50, (k * 50), 50, 50);
                        a = 1;
                    }
                    else
                    {
                        tahta.FillRectangle(renk2, i, (k * 50), 50, 50);
                        tahta.FillRectangle(renk1, i + 50, (k * 50), 50, 50);
                        a = 0;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] p = new int[8];
            p[0] = 0;
            p[1] = 50;
            p[2] = 100;
            p[3] = 150;
            p[4] = 200;
            p[5] = 250;
            p[6] = 300;
            p[7] = 350;

            int x, y;

                         /*Random rastgele = new Random();
                         for (int i = 0; i < 5; i++)
                         {
                             int sayi = rastgele.Next(0, 400);
                            */

            tas1.Location = new Point(50, 100);
            tas2.Location = new Point(200, 150);
            tas3.Location = new Point(200, 50);
            tas4.Location = new Point(100, 50);

            anatas.Location = new Point(300, 250);



        }

        private void engelgetir_Click(object sender, EventArgs e)
        {
            engel1.Location = new Point(100, 100);
            engel2.Location = new Point(300, 200);
        }

        private void topla_Click(object sender, EventArgs e)
        {
            for (int y = 100; y <= 250; y = y + 50)
            {
                tas1.Location = new Point(50, y);
                System.Threading.Thread.Sleep(1000);
            }
            for (int x = 50; x <= 300; x = x + 50)
            {
                tas1.Location = new Point(x, 250);
                System.Threading.Thread.Sleep(1000);
            }

            tas4.Location = new Point(150, 50);
            for (int y = 50; y <= 250; y = y + 50)
            {
                tas4.Location = new Point(150, y);
                System.Threading.Thread.Sleep(1000);
            }
            for (int x = 150; x <= 300; x = x + 50)
            {
                tas4.Location = new Point(x, 250);
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void tas1_Click(object sender, EventArgs e)
        {

        }
    }

}
    

