using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dollar = 388;
        int Euro = 410;
        int Rub = 5;
        int x;
        int z;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {


                if (this.radioButton1.Checked)
                {
                    x = Convert.ToInt32(textBox3.Text);
                    z = Dollar * x;
                    textBox1.Text = z.ToString();
                }


                else if (this.radioButton2.Checked)
                {
                    x = Convert.ToInt32(textBox3.Text);
                    z = Euro * x;
                    textBox1.Text = z.ToString();

                }

                else if (this.radioButton3.Checked)
                {
                    x = Convert.ToInt32(textBox3.Text);
                    z = Rub * x;
                    textBox1.Text = z.ToString();

                }
            }
    }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
