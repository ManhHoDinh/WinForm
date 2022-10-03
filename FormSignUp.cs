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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = -1;
            if (Int32.TryParse(textBox1.Text, out num))
                label4.Text ="Your phone number : " + textBox1.Text;
            else
                label4.Text = "You must to input correct your phone number";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("You must input your phone number!");
            else if (textBox2.Text != textBox3.Text)
                MessageBox.Show("You must input 2 passwork same");
            else
                MessageBox.Show("We will send link access account to " + textBox1.Text + " after 3 minutes!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
                label4.Text = "PassWord Same!";
            else
                label4.Text = "Retry input your password, because 2 passwork don't same";
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
