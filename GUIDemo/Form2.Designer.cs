namespace GUIDemo
{
    partial class Form2
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
            this.bmiResultLabel = new System.Windows.Forms.Label();
            this.genderShowLabel = new System.Windows.Forms.Label();
            this.bmiEqualsLabel = new System.Windows.Forms.Label();
            this.ganderLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.menuForm2 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRYAGAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuForm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmiResultLabel
            // 
            this.bmiResultLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmiResultLabel.Location = new System.Drawing.Point(157, 62);
            this.bmiResultLabel.Name = "bmiResultLabel";
            this.bmiResultLabel.Size = new System.Drawing.Size(88, 27);
            this.bmiResultLabel.TabIndex = 0;
            this.bmiResultLabel.Text = "23.3";
            // 
            // genderShowLabel
            // 
            this.genderShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genderShowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.genderShowLabel.Location = new System.Drawing.Point(118, 34);
            this.genderShowLabel.Name = "genderShowLabel";
            this.genderShowLabel.Size = new System.Drawing.Size(66, 25);
            this.genderShowLabel.TabIndex = 1;
            this.genderShowLabel.Text = "gender";
            // 
            // bmiEqualsLabel
            // 
            this.bmiEqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmiEqualsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bmiEqualsLabel.Location = new System.Drawing.Point(3, 64);
            this.bmiEqualsLabel.Name = "bmiEqualsLabel";
            this.bmiEqualsLabel.Size = new System.Drawing.Size(148, 25);
            this.bmiEqualsLabel.TabIndex = 3;
            this.bmiEqualsLabel.Text = "Your BMI equals:";
            // 
            // ganderLabel
            // 
            this.ganderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ganderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ganderLabel.Location = new System.Drawing.Point(3, 34);
            this.ganderLabel.Name = "ganderLabel";
            this.ganderLabel.Size = new System.Drawing.Size(109, 25);
            this.ganderLabel.TabIndex = 4;
            this.ganderLabel.Text = "Your gender:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(5, 106);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(271, 21);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Underweight, youuld get some kg.";
            // 
            // menuForm2
            // 
            this.menuForm2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuForm2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuForm2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.tRYAGAINToolStripMenuItem});
            this.menuForm2.Location = new System.Drawing.Point(0, 0);
            this.menuForm2.Name = "menuForm2";
            this.menuForm2.Size = new System.Drawing.Size(340, 24);
            this.menuForm2.TabIndex = 6;
            this.menuForm2.Text = "menuStrip1";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // tRYAGAINToolStripMenuItem
            // 
            this.tRYAGAINToolStripMenuItem.Name = "tRYAGAINToolStripMenuItem";
            this.tRYAGAINToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tRYAGAINToolStripMenuItem.Text = "TRY AGAIN";
            this.tRYAGAINToolStripMenuItem.Click += new System.EventHandler(this.tRYAGAINToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 2);
            this.label1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(340, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.ganderLabel);
            this.Controls.Add(this.bmiEqualsLabel);
            this.Controls.Add(this.genderShowLabel);
            this.Controls.Add(this.bmiResultLabel);
            this.Controls.Add(this.menuForm2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuForm2.ResumeLayout(false);
            this.menuForm2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmiResultLabel;
        private System.Windows.Forms.Label genderShowLabel;
        private System.Windows.Forms.Label bmiEqualsLabel;
        private System.Windows.Forms.Label ganderLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.MenuStrip menuForm2;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRYAGAINToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}