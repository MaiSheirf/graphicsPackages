using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace graphicsPackages
{
    public partial class Ellipse : Form
    {
        public void MidPointEllipsse(int rx, int ry, int xcenter, int ycenter)
        {
            double rxx = Math.Sqrt(rx);
            double ryy = Math.Sqrt(ry);
            double x2 = Math.Sqrt(xcenter);
            double y2 = Math.Sqrt(ycenter);

            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            double x1, y1;
            double p;

            x1 = 0;
            y1 = ryy;
            p = (ryy * ryy) - (rxx * rxx * ryy) + ((rxx * rxx) / 4);

            while ((2 * x1 * ryy * ryy) < (2 * y1 * rxx * rxx))
            {
                g.FillRectangle(aBrush, (float)x2 + (float)x1, (float)y2 - (float)y1, 1, 1);
                g.FillRectangle(aBrush, (float)x2 - (float)x1, (float)y2 + (float)y1, 1, 1);
                g.FillRectangle(aBrush, (float)x2 + (float)x1, (float)y2 + (float)y1, 1, 1);
                g.FillRectangle(aBrush, (float)x2 - (float)x1, (float)y2 - (float)y1, 1, 1);

                if (p < 0)
                {
                    x1 = x1 + 1;
                    p = p + (2 * ryy * ryy * x1) + (ryy * ryy);
                }
                else
                {
                    x1 = x1 + 1;
                    y1 = y1 - 1;
                    p = p + (2 * ryy * ryy * x1 + ryy * ryy) - (2 * rxx * rxx * y1);
                }
            }
            p = ((float)x1 + 0.5) * ((float)x1 + 0.5) * ryy * ryy + (y1 - 1) * (y1 - 1) * rxx * rxx - rxx * rxx * ryy * ryy;

            while (y1 >= 0)
            {
                g.FillRectangle(aBrush, (float)x2 + (float)x1, (float)y2 - (float)y1, 1, 1);
                g.FillRectangle(aBrush, (float)x2 - (float)x1, (float)y2 + (float)y1, 1, 1);
                g.FillRectangle(aBrush, (float)x2 + (float)x1, (float)y2 + (float)y1, 1, 1);
                g.FillRectangle(aBrush, (float)x2 - (float)x1, (float)y2 - (float)y1, 1, 1);

                if (p > 0)
                {
                    y1 = y1 - 1;
                    p = p - (2 * rxx * rxx * y1) + (rxx * rxx);

                }
                else
                {
                    y1 = y1 - 1;
                    x1 = x1 + 1;
                    p = p + (2 * ryy * ryy * x1) - (2 * rxx * rxx * y1) - (rxx * rxx);
                }
            }

        }
        public Ellipse()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xctxt = int.Parse(xctextBox.Text);
            int yctxt = int.Parse(yctextBox.Text);
            int xradtxt = int.Parse(xRadiustextBox.Text);
            int yradtxt = int.Parse(yradiustextBox.Text);

            MidPointEllipsse(xctxt, yctxt, xradtxt, yradtxt);

        }
    }
}
