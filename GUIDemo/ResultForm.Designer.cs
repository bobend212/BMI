namespace GUIDemo
{
    partial class ResultForm
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.menuForm2 = new System.Windows.Forms.MenuStrip();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRYAGAINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.resultBoxGroup = new System.Windows.Forms.GroupBox();
            this.menuForm2.SuspendLayout();
            this.resultBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmiResultLabel
            // 
            this.bmiResultLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmiResultLabel.Location = new System.Drawing.Point(31, 28);
            this.bmiResultLabel.Name = "bmiResultLabel";
            this.bmiResultLabel.Size = new System.Drawing.Size(69, 27);
            this.bmiResultLabel.TabIndex = 0;
            this.bmiResultLabel.Text = "<0>";
            this.bmiResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(12, 120);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(272, 38);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Underweight";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuForm2
            // 
            this.menuForm2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuForm2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuForm2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXITToolStripMenuItem,
            this.tRYAGAINToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuForm2.Location = new System.Drawing.Point(0, 0);
            this.menuForm2.Name = "menuForm2";
            this.menuForm2.Size = new System.Drawing.Size(290, 24);
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 2);
            this.label1.TabIndex = 7;
            // 
            // resultBoxGroup
            // 
            this.resultBoxGroup.Controls.Add(this.bmiResultLabel);
            this.resultBoxGroup.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultBoxGroup.Location = new System.Drawing.Point(79, 27);
            this.resultBoxGroup.Name = "resultBoxGroup";
            this.resultBoxGroup.Size = new System.Drawing.Size(140, 74);
            this.resultBoxGroup.TabIndex = 8;
            this.resultBoxGroup.TabStop = false;
            this.resultBoxGroup.Text = "Your BMI";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(290, 171);
            this.Controls.Add(this.resultBoxGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.menuForm2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuForm2.ResumeLayout(false);
            this.menuForm2.PerformLayout();
            this.resultBoxGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmiResultLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.MenuStrip menuForm2;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRYAGAINToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox resultBoxGroup;
    }
}