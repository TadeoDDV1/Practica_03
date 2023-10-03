using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jtddv_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f = float.Parse(textBox1.Text);
            float c = (f - 32) * 5.0f / 9.0f;
            textBox2.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float c = float.Parse(textBox1.Text);
            float f = (c * 9f / 5f) + 32;
            textBox2.Text = f.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.0";
            textBox2.Text = "0.0";
        }
    }
}
