using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace graphicsPackages
{
    public partial class Bresenham : Form
    {
        void lineBresenham(int x1, int y1, int x2, int y2)

        {

            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();

            float x = x1, y = y1;
            int dx = x2 - x1, dy = y2 - y1;

            float P = 2 * dy - dx;

            while (x <= x2)
            {
                g.FillRectangle(aBrush, x, y, 2, 2);
                x++;

                if (P < 0)
                {
                    P = P + 2 * dy;
                }
                else
                {
                    P = P + 2 * dy - 2 * dx;
                    y++;
                }
            }

        }

        public Bresenham()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void drawbutton_Click(object sender, EventArgs e)
        {
            int x1input = int.Parse(x1textBox.Text);
            int y1input= int.Parse(y1textBox.Text);
            int x2input = int.Parse(x2textBox.Text);
            int y2input = int.Parse(y2textBox.Text);

            lineBresenham(x1input, y1input, x2input, y2input);
        }
    }
}
