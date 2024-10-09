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
            masterLabel.Text = DateTime.Now.ToString(); //顯示現在時間
        }
        private void showText_Click(object sender, EventArgs e)
        {
            masterLabel.Text = "HelloWorld!"; //顯示文字
        }
        // 文字對齊 -------------------------------------
        private void left_Click(object sender, EventArgs e)
        {
            masterLabel.TextAlign = ContentAlignment.MiddleLeft; //靠左
        }

        private void center_Click(object sender, EventArgs e)
        {
            masterLabel.TextAlign = ContentAlignment.MiddleCenter; //置中
        }

        private void right_Click(object sender, EventArgs e)
        {
            masterLabel.TextAlign = ContentAlignment.MiddleRight; //靠右
        }
        // -------------------------------------

        private void greenbg_Click(object sender, EventArgs e)
        {
            masterLabel.BackColor = Color.Green; //文字背景綠色
        }

        private void lightBlueText_Click(object sender, EventArgs e)
        {
            masterLabel.ForeColor = Color.LightBlue; //文字顏色淺藍色
        }

        private void formColor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow; //表單背景黃色
        }

        private void clearAllColor_Click(object sender, EventArgs e)
        {
            //文字恢復預設值
            this.BackColor = SystemColors.Control;
            masterLabel.ForeColor= SystemColors.ControlText;
            //表單恢復預設值
            masterLabel.BackColor= SystemColors.Control;
        }
    }
}
