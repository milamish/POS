using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milvale_POS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Convert.ToString(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                double f = b * c;
                label4.Text = a.ToString();
                label5.Text = String.Format("{0:C}", double.Parse(b.ToString()));
                label6.Text = c.ToString();
                label7.Text = String.Format("{0:C}", double.Parse(f.ToString()));


            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = String.Format("{0:N2}", double.Parse(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("invalid input");
            }

        }
    }
}
