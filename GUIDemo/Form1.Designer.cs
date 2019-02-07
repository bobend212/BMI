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
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderCombo = new System.Windows.Forms.ComboBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.menuForm1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForm1.SuspendLayout();
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
            this.titleLabel.Size = new System.Drawing.Size(467, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Body Mass Index ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genderLabel
            // 
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genderLabel.ForeColor = System.Drawing.Color.Blue;
            this.genderLabel.Location = new System.Drawing.Point(49, 65);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(77, 23);
            this.genderLabel.TabIndex = 1;
            this.genderLabel.Text = "Gender";
            // 
            // genderCombo
            // 
            this.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.genderCombo.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderCombo.Location = new System.Drawing.Point(28, 91);
            this.genderCombo.MaxDropDownItems = 2;
            this.genderCombo.MaxLength = 2;
            this.genderCombo.Name = "genderCombo";
            this.genderCombo.Size = new System.Drawing.Size(112, 26);
            this.genderCombo.Sorted = true;
            this.genderCombo.TabIndex = 2;
            // 
            // weightLabel
            // 
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weightLabel.ForeColor = System.Drawing.Color.Blue;
            this.weightLabel.Location = new System.Drawing.Point(172, 65);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(111, 23);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight (kg)";
            // 
            // heightLabel
            // 
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.heightLabel.ForeColor = System.Drawing.Color.Blue;
            this.heightLabel.Location = new System.Drawing.Point(317, 65);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(106, 23);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height (cm)";
            // 
            // WeightText
            // 
            this.WeightText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WeightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WeightText.Location = new System.Drawing.Point(164, 91);
            this.WeightText.Multiline = true;
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(119, 26);
            this.WeightText.TabIndex = 5;
            this.WeightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeightText
            // 
            this.HeightText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightText.Location = new System.Drawing.Point(304, 91);
            this.HeightText.Multiline = true;
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(119, 26);
            this.HeightText.TabIndex = 6;
            this.HeightText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.calculateButton.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Yellow;
            this.calculateButton.Location = new System.Drawing.Point(112, 133);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(227, 41);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuForm1
            // 
            this.menuForm1.BackColor = System.Drawing.SystemColors.Control;
            this.menuForm1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuForm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuForm1.Location = new System.Drawing.Point(0, 0);
            this.menuForm1.Name = "menuForm1";
            this.menuForm1.Size = new System.Drawing.Size(467, 24);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(467, 179);
            this.ControlBox = false;
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.genderCombo);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuForm1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BMI";
            this.menuForm1.ResumeLayout(false);
            this.menuForm1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderCombo;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.TextBox HeightText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.MenuStrip menuForm1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

