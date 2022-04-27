using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int siz = 0;
        int pc = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int tahmin = random.Next(1, 4);
            switch (tahmin)
            {
                case 1:
                    label6.Text = "Beraberlik!";
                    button4.BackColor = Color.Gray;
                    break;
                case 2:
                    pc++;
                    label6.Text = "Kaybettiniz!";
                    button5.BackColor = Color.Red;
                    break;
                case 3:
                    siz++;
                    label6.Text = "Kazandınız!";
                    button6.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
            label4.Text = pc.ToString();
            label2.Text = siz.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int tahmin = random.Next(1, 4);
            switch (tahmin)
            {
                case 1:
                    siz++;
                    label6.Text = "Kazandınız!";
                    button4.BackColor = Color.Green;
                    break;
                case 2:
                    
                    label6.Text = "Beraberlik!";
                    button5.BackColor = Color.Gray;
                    break;
                case 3:
                    pc++;
                    label6.Text = "Kaybettiniz!";
                    button6.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
            label4.Text = pc.ToString();
            label2.Text = siz.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            Random random = new Random();
            int tahmin = random.Next(1, 4);
            switch (tahmin)
            {
                case 1:
                    pc++;
                    label6.Text = "Kaybettiniz!";
                    button4.BackColor = Color.Red;
                    break;
                case 2:
                    siz++;
                    label6.Text = "Kazandınız!";
                    button5.BackColor = Color.Green;
                    break;
                case 3:
                    label6.Text = "Beraberlik!";
                    button6.BackColor = Color.Gray;
                    break;
                default:
                    break;
            }
            label4.Text = pc.ToString();
            label2.Text = siz.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
        }
    }
}
