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
    public partial class ChangeColorDay07 : Form
    {
        public ChangeColorDay07()
        {
            InitializeComponent();
        }

        private void hScrollBarRed_Scroll(object sender, ScrollEventArgs e)
        { 
            int RedValue, BlueValue, GreenValue;
            RedValue = Convert.ToInt32(hScrollBarRed.Value);
            BlueValue = Convert.ToInt32(hScrollBarBlue.Value);
            GreenValue = Convert.ToInt32(hScrollBarGreen.Value);
            panelResult.BackColor = Color.FromArgb(RedValue,GreenValue,BlueValue);
        }
    }
}
