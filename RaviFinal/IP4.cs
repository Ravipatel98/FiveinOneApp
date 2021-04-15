using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ravi
{
    public partial class IP4 : Form
    {
        public IP4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int btnValue = -1;

            btnValue = Convert.ToInt32(MessageBox.Show("Do you want Quit this application ?", "Exit?", MessageBoxButtons.OKCancel));

            if (btnValue == 1) Application.Exit();
        }

       
        private void Frm_ipvalid_btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit", "Close The App", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex1 = new Regex(@"(([\d][\d]?[\d]?)(\.)([\d][\d]?[\d]?)(\.)([\d][\d]?[\d]?)(\.)([\d][\d]?[\d]?))$");
            bool test = regex1.IsMatch(textBox1.Text);
            if (test == true)
            {
                MessageBox.Show(textBox1.Text + "\nThe IP is Correct.");

            }
            else
            {

                MessageBox.Show("The Ip Must Have 4 Bytes\ninteger number between 0 to 255\nseperated by a dot(255.255.255.255).");
                textBox1.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();

        }

        
    }

}

