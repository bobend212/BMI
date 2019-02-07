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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
           // f1 = new Form1();
            CenterToScreen();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            bmiResultLabel.Text = Form1.sum2;
            genderShowLabel.Text = Form1.comboStr;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tRYAGAINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }
    }
}
