namespace Day2
{
    partial class Day05_Calculator
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
            this.lbNameForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btAddition = new System.Windows.Forms.Button();
            this.btSubtraction = new System.Windows.Forms.Button();
            this.btMultiplication = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNameForm
            // 
            this.lbNameForm.AutoSize = true;
            this.lbNameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameForm.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbNameForm.Location = new System.Drawing.Point(121, 34);
            this.lbNameForm.Name = "lbNameForm";
            this.lbNameForm.Size = new System.Drawing.Size(487, 55);
            this.lbNameForm.TabIndex = 0;
            this.lbNameForm.Text = "Calculator Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(65, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input A";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(235, 112);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(386, 26);
            this.tbA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(65, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input B";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(235, 189);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(386, 26);
            this.tbB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(65, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbResult.Enabled = false;
            this.tbResult.Location = new System.Drawing.Point(235, 273);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(386, 26);
            this.tbResult.TabIndex = 2;
            // 
            // btAddition
            // 
            this.btAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddition.Location = new System.Drawing.Point(81, 348);
            this.btAddition.Name = "btAddition";
            this.btAddition.Size = new System.Drawing.Size(70, 64);
            this.btAddition.TabIndex = 3;
            this.btAddition.Text = "+";
            this.btAddition.UseVisualStyleBackColor = true;
            this.btAddition.Click += new System.EventHandler(this.btAddition_Click);
            // 
            // btSubtraction
            // 
            this.btSubtraction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtraction.Location = new System.Drawing.Point(220, 348);
            this.btSubtraction.Name = "btSubtraction";
            this.btSubtraction.Size = new System.Drawing.Size(70, 64);
            this.btSubtraction.TabIndex = 4;
            this.btSubtraction.Text = "-";
            this.btSubtraction.UseVisualStyleBackColor = true;
            this.btSubtraction.Click += new System.EventHandler(this.btSubtraction_Click);
            // 
            // btMultiplication
            // 
            this.btMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplication.Location = new System.Drawing.Point(354, 348);
            this.btMultiplication.Name = "btMultiplication";
            this.btMultiplication.Size = new System.Drawing.Size(70, 64);
            this.btMultiplication.TabIndex = 4;
            this.btMultiplication.Text = "x";
            this.btMultiplication.UseVisualStyleBackColor = true;
            this.btMultiplication.Click += new System.EventHandler(this.btMultiplication_Click);
            // 
            // btDivision
            // 
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.Location = new System.Drawing.Point(523, 348);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(70, 64);
            this.btDivision.TabIndex = 4;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // Day05_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btMultiplication);
            this.Controls.Add(this.btSubtraction);
            this.Controls.Add(this.btAddition);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNameForm);
            this.Name = "Day05_Calculator";
            this.Text = "Day05_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       



        #endregion

        private System.Windows.Forms.Label lbNameForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btAddition;
        private System.Windows.Forms.Button btSubtraction;
        private System.Windows.Forms.Button btMultiplication;
        private System.Windows.Forms.Button btDivision;
    }
}