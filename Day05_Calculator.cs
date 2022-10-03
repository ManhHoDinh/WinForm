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
    public partial class Day05_Calculator : Form
    {
        public Day05_Calculator()
        {
            InitializeComponent();
        }

   
       
        private void btSubtraction_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (tbA.Text == "" || tbB.Text == "")
                    throw new Exception("Please, Input all box");
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
               
                tbResult.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input Interger Value, please!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbA.Text == "" || tbB.Text == "")
                    throw new Exception("Please, Input all box");
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
               
                tbResult.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input Interger Value, please!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (tbA.Text == "" || tbB.Text == "")
                    throw new Exception("Please, Input all box");
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
                
                tbResult.Text = (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input Interger Value, please!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddition_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (tbA.Text == "" || tbB.Text == "")
                    throw new Exception("Please, Input all box");
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
               
                tbResult.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input Interger Value, please!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Day05_Calculator_FormClosing (object sender, FormClosingEventArgs e)
        {
            DialogResult f = MessageBox.Show("Do you want Close Calculator Form?","Out Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (f == DialogResult.No)
                e.Cancel = true;
        }

       
    }
}
