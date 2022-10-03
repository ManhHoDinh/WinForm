namespace Day2
{
    partial class FormPictureDay04
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAnimals = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your animals";
            // 
            // comboBoxAnimals
            // 
            this.comboBoxAnimals.FormattingEnabled = true;
            this.comboBoxAnimals.Location = new System.Drawing.Point(52, 162);
            this.comboBoxAnimals.Name = "comboBoxAnimals";
            this.comboBoxAnimals.Size = new System.Drawing.Size(152, 28);
            this.comboBoxAnimals.TabIndex = 1;
            this.comboBoxAnimals.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimals_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Day2.Properties.Resources.Bg_Button2;
            this.button1.Location = new System.Drawing.Point(35, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Goto project to practice winform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxAnimal
            // 
            this.pictureBoxAnimal.Location = new System.Drawing.Point(426, 49);
            this.pictureBoxAnimal.Name = "pictureBoxAnimal";
            this.pictureBoxAnimal.Size = new System.Drawing.Size(342, 367);
            this.pictureBoxAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAnimal.TabIndex = 2;
            this.pictureBoxAnimal.TabStop = false;
            // 
            // FormPictureDay04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxAnimal);
            this.Controls.Add(this.comboBoxAnimals);
            this.Controls.Add(this.label1);
            this.Name = "FormPictureDay04";
            this.Text = "FormPictureDay04";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAnimals;
        private System.Windows.Forms.PictureBox pictureBoxAnimal;
        private System.Windows.Forms.Button button1;
    }
}