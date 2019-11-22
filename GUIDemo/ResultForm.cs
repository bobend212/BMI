using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDemo
{
    public partial class ResultForm : Form
    {
        MainForm mainForm;
        private HelpForm helpForm;
        private string result = string.Empty;

        public ResultForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tRYAGAINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bmiResultLabel.Text = MainForm.bmi;

            if(MainForm.age < 20)
            {
                resultLabel.Text = showResultForChild();
            }
            else if (MainForm.age >= 20 )
                resultLabel.Text = showResultForAdult();
        }

        private string showResultForAdult()
        {
            double resultBmi = double.Parse(bmiResultLabel.Text);
            if (resultBmi <= 18.50)
            {
                result = "Underweight";
                this.BackColor = Color.OrangeRed;
            }
            else if (resultBmi >= 18.51 && resultBmi <= 24.99)
            {
                result = "Normal";
                this.BackColor = Color.LightGreen;
            }
            else if (resultBmi >= 25.00 && resultBmi <= 29.99)
            {
                result = "Overweight";
                this.BackColor = Color.MediumVioletRed;
            }
            else if (resultBmi >= 29.99)
            {
                result = "Obese!";
                this.BackColor = Color.Red;
            }
            return result;
        }

        private string showResultForChild()
        {
            double resultBmi = double.Parse(bmiResultLabel.Text);
            if (resultBmi <= 5)
            {
                result = "Underweight";
                this.BackColor = Color.OrangeRed;
            }
            else if (resultBmi > 5.01 && resultBmi <= 85)
            {
                result = "Normal";
                this.BackColor = Color.LightGreen;
            }
            else if (resultBmi > 85.01 && resultBmi <= 95)
            {
                result = "Overweight";
                this.BackColor = Color.MediumVioletRed;
            }
            else if (resultBmi > 95.01)
            {
                result = "Obese!";
                this.BackColor = Color.IndianRed;
                this.BackColor = Color.Red;
            }
            return result;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
