using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var xy = string.Format("X: {0}; Y: {1}", e.X, e.Y);
            Text = xy;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
            }
            else if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                Application.Exit();
            }
            else if (e.Button == MouseButtons.Left)
            {

            }

        }
    }
}
