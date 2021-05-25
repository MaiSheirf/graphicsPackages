using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class lineDDA : Form
    {
        int Fabs(int n)
        {
            return ((n > 0) ? n : (n * (-1)));
        }

        void lineDDAFunction(int x1, int y1, int x2, int y2)

        {

            var aBrush = Brushes.Black;

            var g = panel1.CreateGraphics();



            int dx = x2 - x1, dy = y2 - y1, steps, k;

            float xIncrement, yIncrement, x = x1, y = y1;

            if (Fabs(dx) > Fabs(dy))

                steps = Fabs(dx);

            else

                steps = Fabs(dy);

            xIncrement = (float)(dx) / (float)(steps);

            yIncrement = (float)(dy) / (float)(steps);

            g.FillRectangle(aBrush, x, y, 3, 3);

            for (k = 1; k < 150; k++)
            {

                x += xIncrement;

                y += yIncrement;

                g.FillRectangle(aBrush, x, y, 3, 3);

            }

        }
        public lineDDA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int x1input = int.Parse(x1textBox.Text);
            int y1input = int.Parse(y1textBox.Text);
            int x2input = int.Parse(x2textBox.Text);
            int y2input = int.Parse(y2textBox.Text);

            lineDDAFunction(x1input, y1input, x2input, y2input);
        }
    }
}
