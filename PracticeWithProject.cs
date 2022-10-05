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
    public partial class PracticeWithProject : Form
    {
        public PracticeWithProject()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void day05CaculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Day05_Calculator day05_Calculator = new Day05_Calculator();
            day05_Calculator.Show();
        }

        private void day06RandomGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomGameDay06 randomGameDay06 = new RandomGameDay06();
            randomGameDay06.Show();
        }
    }
}
