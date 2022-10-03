using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      
        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormComboBoxDay03();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(textBox1.Text, out num))
                label4.Text = "Your phone number : " + textBox1.Text;
            else
                label4.Text = "Input your correct phone number, please!";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
