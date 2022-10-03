namespace Day2
{
    partial class FormComboBoxDay03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSchool = new System.Windows.Forms.ComboBox();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelSchool = new System.Windows.Forms.Label();
            this.labelBranch = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxFirst = new System.Windows.Forms.ComboBox();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.LableComboBoxFirst = new System.Windows.Forms.Label();
            this.LabelFood = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelResultClass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSchool
            // 
            this.comboBoxSchool.FormattingEnabled = true;
            this.comboBoxSchool.Location = new System.Drawing.Point(104, 336);
            this.comboBoxSchool.Name = "comboBoxSchool";
            this.comboBoxSchool.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSchool.TabIndex = 3;
            this.comboBoxSchool.SelectedIndexChanged += new System.EventHandler(this.comboBoxTruong_SelectedIndexChanged);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(332, 336);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(137, 28);
            this.comboBoxBranch.TabIndex = 4;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.CausesValidation = false;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(557, 336);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 28);
            this.comboBoxClass.TabIndex = 5;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // labelSchool
            // 
            this.labelSchool.AutoSize = true;
            this.labelSchool.Location = new System.Drawing.Point(100, 284);
            this.labelSchool.Name = "labelSchool";
            this.labelSchool.Size = new System.Drawing.Size(155, 20);
            this.labelSchool.TabIndex = 3;
            this.labelSchool.Text = "Choose Your School";
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(328, 284);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(157, 20);
            this.labelBranch.TabIndex = 4;
            this.labelBranch.Text = "Choose Your Branch";
            this.labelBranch.Click += new System.EventHandler(this.labelBranch_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(553, 284);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(145, 20);
            this.labelClass.TabIndex = 5;
            this.labelClass.Text = "Choose Your Class";
            // 
            // comboBoxFirst
            // 
            this.comboBoxFirst.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxFirst.FormattingEnabled = true;
            this.comboBoxFirst.Location = new System.Drawing.Point(104, 65);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(121, 28);
            this.comboBoxFirst.TabIndex = 0;
            this.comboBoxFirst.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirst_SelectedIndexChanged);
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(104, 198);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(186, 28);
            this.comboBoxFood.TabIndex = 1;
            // 
            // LableComboBoxFirst
            // 
            this.LableComboBoxFirst.AutoSize = true;
            this.LableComboBoxFirst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LableComboBoxFirst.Location = new System.Drawing.Point(100, 25);
            this.LableComboBoxFirst.Name = "LableComboBoxFirst";
            this.LableComboBoxFirst.Size = new System.Drawing.Size(118, 20);
            this.LableComboBoxFirst.TabIndex = 8;
            this.LableComboBoxFirst.Text = "ComboBoxFirst";
            // 
            // LabelFood
            // 
            this.LabelFood.AutoSize = true;
            this.LabelFood.Location = new System.Drawing.Point(100, 151);
            this.LabelFood.Name = "LabelFood";
            this.LabelFood.Size = new System.Drawing.Size(46, 20);
            this.LabelFood.TabIndex = 9;
            this.LabelFood.Text = "Food";
            this.LabelFood.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(346, 198);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrice.TabIndex = 10;
            this.textBoxPrice.Text = "0";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(342, 151);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            // 
            // labelResultClass
            // 
            this.labelResultClass.AutoSize = true;
            this.labelResultClass.Location = new System.Drawing.Point(153, 430);
            this.labelResultClass.Name = "labelResultClass";
            this.labelResultClass.Size = new System.Drawing.Size(45, 20);
            this.labelResultClass.TabIndex = 12;
            this.labelResultClass.Text = "Hello";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Day2.Properties.Resources.Bg_Button;
            this.button1.Location = new System.Drawing.Point(407, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "GoTo Form OF day 4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormComboBoxDay03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Day2.Properties.Resources.bg_FormDay31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(929, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResultClass);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.LabelFood);
            this.Controls.Add(this.LableComboBoxFirst);
            this.Controls.Add(this.comboBoxFood);
            this.Controls.Add(this.comboBoxFirst);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelBranch);
            this.Controls.Add(this.labelSchool);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.comboBoxSchool);
            this.Name = "FormComboBoxDay03";
            this.Text = "FormComboBoxDay03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSchool;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelSchool;
        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxFirst;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.Label LableComboBoxFirst;
        private System.Windows.Forms.Label LabelFood;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelResultClass;
        private System.Windows.Forms.Button button1;
    }
}