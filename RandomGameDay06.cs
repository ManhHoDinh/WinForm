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
    public partial class RandomGameDay06 : Form
    {
        public RandomGameDay06()
        {
            InitializeComponent();
        }
        int Point = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (rb3.Checked==rb11.Checked) {
                MessageBox.Show("Choose your predict, Please!!!");
            }
            else
                {
                        Random random = new Random();
                        int Number1, Number2, Number3;
                        Number1 = random.Next(7);
                        Number2 = random.Next(0, 7);
                        Number3 = random.Next(0, 7);
                        lbN1.Text = Number1.ToString();
                        lbN2.Text = Number2.ToString();
                        lbN3.Text = Number3.ToString();
                        int sum = Number1 + Number2 + Number3;
                        if (rb3.Checked == true)
                        {
                            if (sum >= 3 && sum <= 10)
                                Point += 10;
                            else
                                Point -= 10;
                        }
                        else if (rb11.Checked == true)
                        {
                            if (sum >= 11 && sum <= 18)
                                Point += 10;
                            else
                                Point -= 10;
                        }
                        lbPoint.Text = Point.ToString();
                    }
        }

        private void RadioCheckedChange(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked == true)
            {
                radio.BackColor = Color.Blue;
            }
            else
                radio.BackColor = Color.Gray;
        }

        private void btPlayAgain_Click(object sender, EventArgs e)
        {
            rb3.BackColor=rb11.BackColor=Color.Gray;
            Point = 0;
            lbPoint.Text = Point.ToString();
            lbN1.Text = lbN2.Text = lbN3.Text = "";
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            rb3.BackColor = rb11.BackColor = Color.Gray;
            rb3.Checked = false;
            rb11.Checked = false;
        }
    }
}
