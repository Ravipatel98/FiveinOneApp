using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Ravi
{
    public partial class Dashboardravi : Form
    {
        public Dashboardravi()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lotto_649 obj = new Lotto_649();
            obj.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MoneyEx obj = new MoneyEx();
            obj.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TempConversions obj = new TempConversions();
            obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frm_Cal obj = new frm_Cal();
            obj.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            IP4 obj = new IP4();
            obj.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int btnValue = -1;

            btnValue = Convert.ToInt32(MessageBox.Show("Do you want Quit this application ?", "Exit?", MessageBoxButtons.OKCancel));

            if (btnValue == 1) Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            intro obj = new intro();
            obj.Show();
        }
    }
}
