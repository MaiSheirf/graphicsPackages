using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace graphicsPackages
{
    public partial class middlePiont : Form
    {
        void MidPointCircleFun(int xCenter, int yCenter, int radius)
        {

            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            int x = 0;
            int y = radius;
            int d = 1 - radius;

            while (x < y)
            {
                g.FillRectangle(aBrush, xCenter + x, yCenter + y, 1, 1);
                g.FillRectangle(aBrush, xCenter + y, yCenter + x, 1, 1);
                g.FillRectangle(aBrush, xCenter - y, yCenter + x, 1, 1);
                g.FillRectangle(aBrush, xCenter - x, yCenter + y, 1, 1);
                g.FillRectangle(aBrush, xCenter - x, yCenter - y, 1, 1);
                g.FillRectangle(aBrush, xCenter - y, yCenter - x, 1, 1);
                g.FillRectangle(aBrush, xCenter + y, yCenter - x, 1, 1);
                g.FillRectangle(aBrush, xCenter + x, yCenter - y, 1, 1);

                x++;
                if (d < 0)
                    d += 2 * x + 1;
                else
                {
                    y--;
                    d += 2 * (x - y) + 1;
                }
            }
        }

        public middlePiont()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int xCenter = int.Parse(xtextBox.Text);
            int yCenter = int.Parse(ytextBox.Text);
            int radius = int.Parse(RadiustextBox.Text);

            MidPointCircleFun(xCenter, yCenter, radius);
        }
    }
}