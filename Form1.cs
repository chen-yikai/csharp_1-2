using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void showCurrentDate(object sender, EventArgs e)
        {
            masterLabel.Text = DateTime.Now.ToString();
        }

        private void showText_Click(object sender, EventArgs e)
        {
            masterLabel.Text = "HelloWorld!";
        }

        private void left_Click(object sender, EventArgs e)
        {
            masterLabel.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void center_Click(object sender, EventArgs e)
        {
            masterLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void right_Click(object sender, EventArgs e)
        {
            masterLabel.TextAlign = ContentAlignment.MiddleRight;
        }

        private void greenbg_Click(object sender, EventArgs e)
        {
            masterLabel.BackColor = Color.Green;
        }

        private void lightBlueText_Click(object sender, EventArgs e)
        {
            masterLabel.ForeColor = Color.LightBlue;
        }

        private void formColor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void clearAllColor_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            masterLabel.ForeColor= SystemColors.ControlText;
            masterLabel.BackColor= SystemColors.Control;
        }
    }
}
