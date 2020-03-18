using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3;
            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);
            n3 = n1 / (n2*n2);
            textBox3.Text = n3.ToString("#,###,###,###.##");

            if (n3 > 25)
            {
                label5.Text = "อ้วน";
                MessageBox.Show("ค่าดัชนีมวลกายของคุณคือ" + n3.ToString() + "คุณอ้วน");
            }
            else
            {
                if (n3 > 18 && n3 < 25)
                {
                    label5.Text = "ปกติ";
                    MessageBox.Show("ค่าดัชนีมวลกายของคุณคือ" + n3.ToString() + "คุณปกติ");
                }
                else
                {
                    if (n3 < 18)
                        label5.Text = "ผอม";
                    MessageBox.Show("ค่าดัชนีมวลกายของคุณคือ" + n3.ToString() + "คุณผอม");
                }
            }
                
            } 

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
