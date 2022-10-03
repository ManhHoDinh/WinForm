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
    public partial class Day02 : Form
    {
        public Day02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        
        private void Day02_Load(object sender, EventArgs e)
        {
            label1.Text = "Just click on WinForm";
            label1.BackColor = Color.White;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSignIn NewForm= new FormSignIn();
            NewForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Text = "Hello";
            label1.Text = "This is lable change";
            label1.BackColor = Color.Yellow;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormSignUp fIn= new FormSignUp();
            fIn.Show();
        }
    }
}
