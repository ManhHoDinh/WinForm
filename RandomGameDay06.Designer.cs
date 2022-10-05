namespace Day2
{
    partial class RandomGameDay06
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
            this.lbN1 = new System.Windows.Forms.Label();
            this.lbN2 = new System.Windows.Forms.Label();
            this.lbN3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.btPlayAgain = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbN1
            // 
            this.lbN1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbN1.Location = new System.Drawing.Point(72, 104);
            this.lbN1.Name = "lbN1";
            this.lbN1.Size = new System.Drawing.Size(137, 138);
            this.lbN1.TabIndex = 0;
            this.lbN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbN2
            // 
            this.lbN2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbN2.Location = new System.Drawing.Point(321, 104);
            this.lbN2.Name = "lbN2";
            this.lbN2.Size = new System.Drawing.Size(137, 138);
            this.lbN2.TabIndex = 0;
            this.lbN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbN3
            // 
            this.lbN3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbN3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbN3.Location = new System.Drawing.Point(589, 104);
            this.lbN3.Name = "lbN3";
            this.lbN3.Size = new System.Drawing.Size(137, 138);
            this.lbN3.TabIndex = 0;
            this.lbN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(197, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 104);
            this.label4.TabIndex = 1;
            this.label4.Text = "ứng dụng dự đoán ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb11);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(129, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // rb11
            // 
            this.rb11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb11.AutoSize = true;
            this.rb11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb11.Location = new System.Drawing.Point(305, 45);
            this.rb11.Name = "rb11";
            this.rb11.Size = new System.Drawing.Size(153, 56);
            this.rb11.TabIndex = 0;
            this.rb11.TabStop = true;
            this.rb11.Text = "11 - 18";
            this.rb11.UseVisualStyleBackColor = false;
            this.rb11.CheckedChanged += new System.EventHandler(this.RadioCheckedChange);
            // 
            // rb3
            // 
            this.rb3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb3.Location = new System.Drawing.Point(74, 45);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(131, 56);
            this.rb3.TabIndex = 0;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 - 10";
            this.rb3.UseVisualStyleBackColor = false;
            this.rb3.CheckedChanged += new System.EventHandler(this.RadioCheckedChange);
            // 
            // btPlayAgain
            // 
            this.btPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlayAgain.ForeColor = System.Drawing.Color.SpringGreen;
            this.btPlayAgain.Location = new System.Drawing.Point(40, 476);
            this.btPlayAgain.Name = "btPlayAgain";
            this.btPlayAgain.Size = new System.Drawing.Size(174, 55);
            this.btPlayAgain.TabIndex = 3;
            this.btPlayAgain.Text = "Play Again";
            this.btPlayAgain.UseVisualStyleBackColor = true;
            this.btPlayAgain.Click += new System.EventHandler(this.btPlayAgain_Click);
            // 
            // btPlay
            // 
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.ForeColor = System.Drawing.Color.SpringGreen;
            this.btPlay.Location = new System.Drawing.Point(289, 476);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(109, 55);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(487, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 71);
            this.label5.TabIndex = 4;
            this.label5.Text = "Point : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPoint
            // 
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPoint.Location = new System.Drawing.Point(631, 476);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(138, 71);
            this.lbPoint.TabIndex = 4;
            this.lbPoint.Text = "00";
            this.lbPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(125, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "from 1 - 6 in a box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(491, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Win + 10 or lose - 10";
            // 
            // RandomGameDay06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 617);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.btPlayAgain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbN3);
            this.Controls.Add(this.lbN2);
            this.Controls.Add(this.lbN1);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Name = "RandomGameDay06";
            this.Text = "RandomGameDay05";
            this.Shown += new System.EventHandler(this.ShowNewForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbN1;
        private System.Windows.Forms.Label lbN2;
        private System.Windows.Forms.Label lbN3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb11;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.Button btPlayAgain;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}