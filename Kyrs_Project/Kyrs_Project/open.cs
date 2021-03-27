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
    public partial class open : Form
    {
        public open()
        {
            InitializeComponent();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void open_Load(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;


        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { pictureBox16.Visible = true; Properties.Settings.Default.Meet++; }
            else {pictureBox16.Visible = false; Properties.Settings.Default.Meet=0; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { pictureBox17.Visible = true; Properties.Settings.Default.Fish++; }
            else { pictureBox17.Visible = false; Properties.Settings.Default.Fish = 0; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { pictureBox28.Visible = true; Properties.Settings.Default.Chicken++; }
            else { pictureBox28.Visible = false; Properties.Settings.Default.Chicken = 0; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { pictureBox25.Visible = true; Properties.Settings.Default.Ant++; }
            else { pictureBox25.Visible = false; Properties.Settings.Default.Ant = 0; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) { pictureBox26.Visible = true; Properties.Settings.Default.Tentackle++; }
            else { pictureBox26.Visible = false; Properties.Settings.Default.Tentackle = 0; }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) { pictureBox27.Visible = true; Properties.Settings.Default.BigFish++; }
            else { pictureBox27.Visible = false; Properties.Settings.Default.BigFish = 0; }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) { pictureBox29.Visible = true; Properties.Settings.Default.Juice++; }
            else { pictureBox29.Visible = false; Properties.Settings.Default.Juice = 0; }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked) { pictureBox30.Visible = true; Properties.Settings.Default.Milk++; }
            else { pictureBox30.Visible = false; Properties.Settings.Default.Milk = 0; }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked) { pictureBox31.Visible = true; Properties.Settings.Default.Yksys++; }
            else { pictureBox31.Visible = false; Properties.Settings.Default.Yksys = 0; }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked) { pictureBox32.Visible = true; Properties.Settings.Default.TomatoSouce++; }
            else { pictureBox32.Visible = false; Properties.Settings.Default.TomatoSouce = 0; }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked) { pictureBox33.Visible = true; Properties.Settings.Default.Soda++; }
            else { pictureBox33.Visible = false; Properties.Settings.Default.Soda = 0; }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked) { pictureBox22.Visible = true; Properties.Settings.Default.Melon++; }
            else { pictureBox22.Visible = false; Properties.Settings.Default.Melon = 0; }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked) { pictureBox19.Visible = true; Properties.Settings.Default.Pineapple++; }
            else { pictureBox19.Visible = false; Properties.Settings.Default.Pineapple = 0; }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked) { pictureBox23.Visible = true; Properties.Settings.Default.Vine++; }
            else {pictureBox23.Visible = false; Properties.Settings.Default.Vine = 0; }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked) { pictureBox24.Visible = true; Properties.Settings.Default.Vegan++; }
            else { pictureBox24.Visible = false; Properties.Settings.Default.Vegan = 0; }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked) { pictureBox18.Visible = true; Properties.Settings.Default.Cip++; }
            else { pictureBox18.Visible = false; Properties.Settings.Default.Cip = 0; }
        }

        private void open_Activated(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Meet > 0) checkBox1.Checked = true;
            else checkBox1.Checked = false;

            if (Properties.Settings.Default.Fish > 0) checkBox2.Checked = true;
            else checkBox2.Checked = false;

            if (Properties.Settings.Default.Chicken > 0) checkBox3.Checked = true;
            else checkBox3.Checked = false;

            if (Properties.Settings.Default.Ant > 0) checkBox4.Checked = true;
            else checkBox4.Checked = false;

            if (Properties.Settings.Default.Tentackle > 0) checkBox5.Checked = true;
            else checkBox5.Checked = false;

            if (Properties.Settings.Default.BigFish > 0) checkBox6.Checked = true;
            else checkBox6.Checked = false;

            if (Properties.Settings.Default.Juice > 0) checkBox7.Checked = true;
            else checkBox7.Checked = false;

            if (Properties.Settings.Default.Milk > 0) checkBox8.Checked = true;
            else checkBox8.Checked = false;

            if (Properties.Settings.Default.Yksys > 0) checkBox9.Checked = true;
            else checkBox9.Checked = false;

            if (Properties.Settings.Default.TomatoSouce > 0) checkBox10.Checked = true;
            else checkBox10.Checked = false;

            if (Properties.Settings.Default.Soda > 0) checkBox11.Checked = true;
            else checkBox11.Checked = false;

            if (Properties.Settings.Default.Melon > 0) checkBox12.Checked = true;
            else checkBox12.Checked = false;

            if (Properties.Settings.Default.Pineapple > 0) checkBox13.Checked = true;
            else checkBox13.Checked = false;

            if (Properties.Settings.Default.Vegan > 0) checkBox15.Checked = true;
            else checkBox15.Checked = false;

            if (Properties.Settings.Default.Vine > 0) checkBox14.Checked = true;
            else checkBox14.Checked = false;

            if (Properties.Settings.Default.Cip > 0) checkBox16.Checked = true;
            else checkBox16.Checked = false;

        }

        private void open_Deactivate(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
    
}
