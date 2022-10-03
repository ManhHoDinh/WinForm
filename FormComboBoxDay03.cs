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
    public partial class FormComboBoxDay03 : Form
    {
        public FormComboBoxDay03()
        {
            InitializeComponent();
            comboBoxFirst.DataSource = ListItemFirst;
            comboBoxFood.DataSource = ListItemFood;
            comboBoxFood.DisplayMember = "Name";
            AddBinding();
            List<School> ListSchools = new List<School>()
            {
                //TH Duy Phu
                new School(){
                    NameSchool = "Truong Tieu Hoc Duy Phu",
                    ListBranch = new List<Branch>(){ 
                        new Branch(){ 
                            NameBranch ="Branch 1",
                            ListClass = new List<string>(){ 
                                "1.A","1.B", "1.C"
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 2",
                            ListClass = new List<string>(){
                                "2.A","2.B", "2.C"
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 3",
                            ListClass = new List<string>(){
                                "3.A","3.B", "3.C"
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 4",
                            ListClass = new List<string>(){
                                "4.A","4.B", "4.C"
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 5",
                            ListClass = new List<string>(){
                                "5.A","5.B", "5.C"
                            }
                        }
                    }
                },
                //THCS Nguyen Chi Thanh
                new School(){
                    NameSchool = "Truong Trung Hoc Co So Nguyen Chi Thanh",
                    ListBranch = new List<Branch>(){
                        new Branch(){
                            NameBranch ="Branch 6",
                            ListClass = new List<string>(){
                                "6.1","6.2", 
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 7",
                            ListClass = new List<string>(){
                                "7.1","7.2"
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 8",
                            ListClass = new List<string>(){
                                "8.1","8.2"
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 9",
                            ListClass = new List<string>(){
                                "9.1","9.2"
                            }
                        },
                        
                    }
                },
                //THPT Le Hong Phong
                new School(){
                    NameSchool = "Truong Trung hoc Pho Thong Le Hong Phong",
                    ListBranch = new List<Branch>(){
                        new Branch(){
                            NameBranch ="Branch 10",
                            ListClass = new List<string>(){
                                "10.1", "10.2", "10.3", "10.4", "10.5", "10.6", "10.7", "10.8",
                            }
                        },
                       new Branch(){
                            NameBranch ="Branch 11",
                            ListClass = new List<string>(){
                                "11.1", "11.2", "11.3", "11.4", "11.5", "11.6", "11.7", "11.8",
                            }
                        },
                        new Branch(){
                            NameBranch ="Branch 12",
                            ListClass = new List<string>(){
                                "12.1", "12.2", "12.3", "12.4", "12.5", "12.6", "12.7", "12.8",
                            }
                        },
                    }
                },
            };
            comboBoxSchool.DataSource = ListSchools;
            comboBoxSchool.DisplayMember = "NameSchool";
        }

        void AddBinding()
        {
            textBoxPrice.DataBindings.Add(new Binding("Text", comboBoxFood.DataSource, "Price"));
        }

        List<string> ListItemFirst = new List<string>()
        {
         "Manh", "Ho", "Dinh"  
        };

        List<Food> ListItemFood = new List<Food>()
        {
            new Food(){Name="Cơm xèo Thập cẩm", Price = 40000},
            new Food(){Name="Bánh canh", Price = 25000},
            new Food{Name="Phở Bò", Price = 30000},
        };

        public class Food
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        private void comboBoxTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
              School cbr = cb.SelectedValue as School;
                comboBoxBranch.DataSource = cbr.ListBranch;
                comboBoxBranch.DisplayMember = "NameBranch";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFirst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Branch
        {
            public string NameBranch { get; set; }
            public List <string> ListClass { get; set; }
        }
        public class School
        {
            public string NameSchool { get; set; }
            public List<Branch> ListBranch { get; set; }
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                Branch branch = cb.SelectedItem as Branch;
                comboBoxClass.DataSource = branch.ListClass;
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (comboBoxBranch != null )
            {
                labelResultClass.Text = "Your Class is " + comboBoxClass.Text + " of " + comboBoxBranch.Text + " in " + comboBoxSchool.Text;
            }
        }

        private void labelBranch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormPictureDay04();
            form.Show();
        }
    }
}




