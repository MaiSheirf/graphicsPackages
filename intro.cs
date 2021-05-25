using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace graphicsPackages
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new WinFormsApp1.lineDDA().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new graphicsPackages.Bresenham().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new graphicsPackages.middlePiont().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new graphicsPackages.Ellipse().Show();
        }
    }
}
