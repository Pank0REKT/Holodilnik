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
    public partial class panel_ypr : Form
    {
        public panel_ypr()
        {
            InitializeComponent();
        }

        private void panel_ypr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp1plus = Convert.ToInt32(label1.Text);
            temp1plus++;
            label1.Text = Convert.ToString(temp1plus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int temp1minus = Convert.ToInt32(label1.Text);
            temp1minus--;
            label1.Text = Convert.ToString(temp1minus);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int temp2plus = Convert.ToInt32(label2.Text);
            temp2plus++;
            label2.Text = Convert.ToString(temp2plus);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int temp2minus = Convert.ToInt32(label2.Text);
            temp2minus--;
            label2.Text = Convert.ToString(temp2minus);
        }

        private void panel_ypr_Deactivate(object sender, EventArgs e)
        {
            int mN = Convert.ToInt32(label1.Text); int mM = Convert.ToInt32(label2.Text);
            if (mN < -15 | mN > 20) { MessageBox.Show("Температуры оказались больше доступных и были возвращены к нулю."); label1.Text = "0";}
            if (mM < -23 | mM > 5) { MessageBox.Show("Температуры оказались больше доступных и были возвращены к нулю."); label2.Text = "0"; }
            Properties.Settings.Default.tempN = label1.Text;
            Properties.Settings.Default.tempM = label2.Text;
            Properties.Settings.Default.Save();
        }

        private void panel_ypr_Activated(object sender, EventArgs e)
        {
            string prov = Properties.Settings.Default.proverka;
            if (prov == "1") { button10.Visible = false; button11.Visible = true; button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false; }
            else { button10.Visible = true; button11.Visible = false; }
            label1.Text = Properties.Settings.Default.tempN;
            label2.Text = Properties.Settings.Default.tempM;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.proverka = "0";
                MessageBox.Show("Влючен режим разморозки, температуры снижены");
                Properties.Settings.Default.tempN = "12";
                Properties.Settings.Default.tempM = "0";
                //int specialError = Convert.ToInt32(Properties.Settings.Default.tempM);
                //specialError /= 0;
                label1.Text = Properties.Settings.Default.tempN;
                label2.Text = Properties.Settings.Default.tempM;
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true;
                Properties.Settings.Default.HMode = "Холодильник работает в режиме разморозки.";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.proverka = "1";
            MessageBox.Show("Вы отключили питание, в скором времени температура приравняется к комнатной.");
            Properties.Settings.Default.tempN = "0";
            Properties.Settings.Default.tempM = "0";
            button10.Visible = false;
            button11.Visible = true;
            label1.Text = Properties.Settings.Default.tempN;
            label2.Text = Properties.Settings.Default.tempM;
            button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false;
            Properties.Settings.Default.HMode = "Питание отсутствует.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.proverka = "0";
            MessageBox.Show("Влючен режим отпуск, температуры остались неизменны, напряжение на электросеть уменьшилось");
            label1.Text = Properties.Settings.Default.tempN;
            label2.Text = Properties.Settings.Default.tempM;
            button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true;
            Properties.Settings.Default.HMode = "Холодильник работает в режиме отпуск.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.proverka = "0";
            MessageBox.Show("Влючен режим быстрой разморозки, температуры снижена только в морозильнике");
            Properties.Settings.Default.tempN = "6";
            Properties.Settings.Default.tempM = "0";
            label1.Text = Properties.Settings.Default.tempN;
            label2.Text = Properties.Settings.Default.tempM;
            button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true;
            Properties.Settings.Default.HMode = "Холодильник работает в режиме быстрой разморозки.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.proverka = "0";
            MessageBox.Show("Вы включили холодильник, в скором времени температура приравняется к значениям на циферблате.");
            button10.Visible = true;
            button11.Visible = false;
            Properties.Settings.Default.tempN = "4";
            Properties.Settings.Default.tempM = "-11";
            label1.Text = Properties.Settings.Default.tempN;
            label2.Text = Properties.Settings.Default.tempM;
            button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; button4.Enabled = true;
            Properties.Settings.Default.HMode = "Холодильник работает в обычном режиме";
        }

    }
}
