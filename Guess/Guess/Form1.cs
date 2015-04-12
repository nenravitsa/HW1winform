using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Add(button1);
            Random random = new Random();
            int n = 0;
            DialogResult res;
            do
            {
                int randomNumber = random.Next(1, 2001);
                string answer = randomNumber.ToString();
                n++;
                string col = n.ToString();
                
                DialogResult result = MessageBox.Show(answer, "Правильно?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    res =  MessageBox.Show("Я выйграл! Количество попыток - " + col + ". Хотите сыграть еще раз?", "Win!",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK)
                    {
                        n = 0;
                    }
                    if (res == DialogResult.Cancel)
                    {
                        Close();
                        break;
                    }
                }
            } while (true);
            Application.Exit();
        }
    }
}
