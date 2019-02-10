namespace GUIDemo
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.menuForm1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageTxtbox = new System.Windows.Forms.TextBox();
            this.maskTextWeight = new System.Windows.Forms.MaskedTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.maskTextHeight = new System.Windows.Forms.MaskedTextBox();
            this.menuForm1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.titleLabel.Location = new System.Drawing.Point(0, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(338, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Body Mass Index ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ageLabel
            // 
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageLabel.ForeColor = System.Drawing.Color.Blue;
            this.ageLabel.Location = new System.Drawing.Point(23, 31);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(43, 23);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Age";
            // 
            // weightLabel
            // 
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weightLabel.ForeColor = System.Drawing.Color.Blue;
            this.weightLabel.Location = new System.Drawing.Point(88, 31);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(102, 23);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight (kg)";
            // 
            // heightLabel
            // 
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightLabel.ForeColor = System.Drawing.Color.Blue;
            this.heightLabel.Location = new System.Drawing.Point(205, 31);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(105, 23);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height (cm)";
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Yellow;
            this.calculateButton.Location = new System.Drawing.Point(50, 171);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(227, 41);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // menuForm1
            // 
            this.menuForm1.BackColor = System.Drawing.SystemColors.Control;
            this.menuForm1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuForm1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuForm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuForm1.Location = new System.Drawing.Point(0, 0);
            this.menuForm1.Name = "menuForm1";
            this.menuForm1.Size = new System.Drawing.Size(338, 24);
            this.menuForm1.TabIndex = 8;
            this.menuForm1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ageTxtbox
            // 
            this.ageTxtbox.Location = new System.Drawing.Point(18, 57);
            this.ageTxtbox.Multiline = true;
            this.ageTxtbox.Name = "ageTxtbox";
            this.ageTxtbox.Size = new System.Drawing.Size(63, 26);
            this.ageTxtbox.TabIndex = 9;
            this.ageTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskTextWeight
            // 
            this.maskTextWeight.Location = new System.Drawing.Point(102, 57);
            this.maskTextWeight.Name = "maskTextWeight";
            this.maskTextWeight.Size = new System.Drawing.Size(74, 26);
            this.maskTextWeight.TabIndex = 10;
            this.maskTextWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox.Controls.Add(this.maskTextHeight);
            this.groupBox.Controls.Add(this.ageLabel);
            this.groupBox.Controls.Add(this.weightLabel);
            this.groupBox.Controls.Add(this.maskTextWeight);
            this.groupBox.Controls.Add(this.heightLabel);
            this.groupBox.Controls.Add(this.ageTxtbox);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox.Location = new System.Drawing.Point(12, 57);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(316, 108);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Insert data";
            // 
            // maskTextHeight
            // 
            this.maskTextHeight.Location = new System.Drawing.Point(209, 57);
            this.maskTextHeight.Mask = "000";
            this.maskTextHeight.Name = "maskTextHeight";
            this.maskTextHeight.Size = new System.Drawing.Size(74, 26);
            this.maskTextHeight.TabIndex = 11;
            this.maskTextHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(338, 219);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuForm1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuForm1.ResumeLayout(false);
            this.menuForm1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.MenuStrip menuForm1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox ageTxtbox;
        private System.Windows.Forms.MaskedTextBox maskTextWeight;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.MaskedTextBox maskTextHeight;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

