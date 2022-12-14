namespace Day2
{
    partial class PracticeWithProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day05CaculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day06RandomGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day07ChangeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day08PredictAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.day05CaculatorToolStripMenuItem,
            this.day06RandomGameToolStripMenuItem,
            this.day07ChangeColorToolStripMenuItem,
            this.day08PredictAppToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // day05CaculatorToolStripMenuItem
            // 
            this.day05CaculatorToolStripMenuItem.Name = "day05CaculatorToolStripMenuItem";
            this.day05CaculatorToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.day05CaculatorToolStripMenuItem.Text = "Day05 - Caculator";
            this.day05CaculatorToolStripMenuItem.Click += new System.EventHandler(this.day05CaculatorToolStripMenuItem_Click);
            // 
            // day06RandomGameToolStripMenuItem
            // 
            this.day06RandomGameToolStripMenuItem.Name = "day06RandomGameToolStripMenuItem";
            this.day06RandomGameToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.day06RandomGameToolStripMenuItem.Text = "Day06 - Random Game";
            this.day06RandomGameToolStripMenuItem.Click += new System.EventHandler(this.day06RandomGameToolStripMenuItem_Click);
            // 
            // day07ChangeColorToolStripMenuItem
            // 
            this.day07ChangeColorToolStripMenuItem.Name = "day07ChangeColorToolStripMenuItem";
            this.day07ChangeColorToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.day07ChangeColorToolStripMenuItem.Text = "Day07 - Change Color";
            this.day07ChangeColorToolStripMenuItem.Click += new System.EventHandler(this.day07ChangeColorToolStripMenuItem_Click);
            // 
            // day08PredictAppToolStripMenuItem
            // 
            this.day08PredictAppToolStripMenuItem.Name = "day08PredictAppToolStripMenuItem";
            this.day08PredictAppToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.day08PredictAppToolStripMenuItem.Text = "Day08 - Predict App";
            this.day08PredictAppToolStripMenuItem.Click += new System.EventHandler(this.day08PredictAppToolStripMenuItem_Click);
            // 
            // PracticeWithProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 611);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PracticeWithProject";
            this.Text = "PracticeWithProject";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day05CaculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day06RandomGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day07ChangeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day08PredictAppToolStripMenuItem;
    }
}