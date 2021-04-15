using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ravi
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text ="Romit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboardravi obj = new Dashboardravi();
            obj.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
