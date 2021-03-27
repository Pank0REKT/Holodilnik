using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs_Project
{
    public partial class Form1 : Form
    {
        public string Txt
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_ypr form2 = new panel_ypr();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open form1 = new open();
            form1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(label1.Text);
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.tempN;
            label2.Text = Properties.Settings.Default.tempM;
            label10.Text = Properties.Settings.Default.HMode;
            if (Properties.Settings.Default.Meet == 0 & Properties.Settings.Default.Chicken == 0) checkBox1.Checked = false;
            else checkBox1.Checked = true;
            if (Properties.Settings.Default.Fish == 0 & Properties.Settings.Default.Ant == 0 & Properties.Settings.Default.BigFish == 0  & Properties.Settings.Default.Tentackle == 0) checkBox2.Checked = false;
            else checkBox2.Checked = true;
            if (Properties.Settings.Default.Milk == 0 & Properties.Settings.Default.Cip == 0) checkBox3.Checked = false;
            else checkBox3.Checked = true;
            if (Properties.Settings.Default.Melon == 0 & Properties.Settings.Default.Pineapple == 0 & Properties.Settings.Default.Vine == 0 & Properties.Settings.Default.Vegan == 0) checkBox4.Checked = false;
            else checkBox4.Checked = true;
            if (Properties.Settings.Default.Soda == 0 & Properties.Settings.Default.TomatoSouce == 0 & Properties.Settings.Default.Yksys == 0 & Properties.Settings.Default.Juice == 0) checkBox5.Checked = false;
            else checkBox5.Checked = true;
        }


    }
}
