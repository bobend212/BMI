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
    public partial class form2Panel : Form
    {
        Form1 f1;
        private HelpForm helpForm;
        private string result = null;

        public form2Panel()
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
            f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bmiResultLabel.Text = Form1.bmi;

            if(Form1.age < 20)
            {
                resultLabel.Text = showResultChild();
            }
            else if (Form1.age >= 20 )
                resultLabel.Text = showResultAdult();
        }

        private string showResultAdult()
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

        private string showResultChild()
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
