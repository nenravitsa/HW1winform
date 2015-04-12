using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DateTimerFormat format;
        public enum DateTimerFormat
        {
            ShowClock,
            ShowDate
        };
        public Form1()
        {
            format = DateTimerFormat.ShowClock;
            
            InitializeComponent();
            
            this.listBox1.Items.AddRange(new object[]
            {
                "Minsk",
                "Vilnus",
                "Paris",
                "Moskow",
                "London"
            });
            this.comboBox1.Items.AddRange(new object[] { "Brasil", "Belarus", "Russia", "GB", "France" }
                );
            //this.progressBar1.Increment(25);
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 100;
            numericUpDown2.Minimum = 20;
            numericUpDown2.Maximum = 200;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.SelectedItem.ToString(), "Selected country", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add(this.textBox1.Text);
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Empty string!");
                return;
            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 50;
            progressBar1.Step = 2;
            for (int i = 0; i <= 25; i++)
            {
                progressBar1.PerformStep();
                Thread.Sleep(50);
            }
            progressBar1.Value = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            decimal itog = numericUpDown1.Value + numericUpDown2.Value;
            textBox2.Text = itog.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string str;
            str = DateTime.Now.ToShortDateString();
            this.toolStripStatusLabel1.Text = str;
            str = DateTime.Now.DayOfWeek.ToString();
            this.toolStripMenuItem1.Text = str;
            if (format == DateTimerFormat.ShowClock)
            {
                this.toolStripStatusLabel1.Text = DateTime.Now.ToShortTimeString();
                format = DateTimerFormat.ShowClock;
            }
            else
            {
                this.toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
                format = DateTimerFormat.ShowDate;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(this.trackBar1.Value, this.trackBar2.Value, this.trackBar3.Value);
            this.BackColor = c;
        }






    }
}
