using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enryu0513
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            MessageBox.Show("ボタンを透明化しました");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            MessageBox.Show("ボタンの透明化を解除しました");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "押しましたね？バレてますよ";
            button2.Left = 0;
        }
    }
}
