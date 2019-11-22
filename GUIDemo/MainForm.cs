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
    public partial class MainForm : Form
    {
        double height, weight;
        private static double bmiDouble;
        public static string bmi;
        public static int age;
        private ResultForm resultForm;
        private HelpForm helpForm;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculateBMI();
                resultForm = new ResultForm();
                this.Hide();
                resultForm.Show();

            } catch (FormatException)
            {
                MessageBox.Show("Try again.", "Wrong data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string calculateBMI()
        {
            height = double.Parse(maskTextHeight.Text);
            weight = double.Parse(maskTextWeight.Text);
            bmiDouble = weight / (height * height) * 10000;
            bmi = string.Format("{00:f2}", bmiDouble);
            age = Convert.ToInt32(ageTxtbox.Text);
            return bmi;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ageTxtbox.Focus();
        }
    }
}