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
    public partial class FormPictureDay04 : Form
    {
        public FormPictureDay04()
        {
            InitializeComponent();
            comboBoxAnimals.DataSource = pictureList;
        }

        
        List<string> pictureList = new List<string>() { "Tiger", "pikachu", "Dog"};
       
       
       

        private void comboBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxAnimal.Image = new Bitmap("..\\..\\access\\Images\\" + comboBoxAnimals.Text + ".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new PracticeWithProject();
            f.Show();
        }
    }
}
