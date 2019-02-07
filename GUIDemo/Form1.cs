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
    public partial class Form1 : Form
    {

        public static double h;
        public static double w;
        public static double sum;
        public static string sum2;
        public static string comboStr;

        private double heightInput;



        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            h = double.Parse(HeightText.Text);
            w = double.Parse(WeightText.Text);

            if (h < 150 || w < 40)
            {
                MessageBox.Show("Minimum height: 150cm \nMinimum weight: 40kg");
            }
            else
            {
                try
                {

                    sum = (w / (h * h)) * 10000;
                    comboStr = genderCombo.Text;
                    sum2 = Convert.ToString(Math.Round(sum, 2));

                    Form2 openForm2 = new Form2();
                    openForm2.Show();
                    this.Hide();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Wrong input!");
                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
