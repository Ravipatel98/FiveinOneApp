using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ravi
{
    public partial class MoneyEx : Form
    {
        public MoneyEx()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int btnValue = -1;

            btnValue = Convert.ToInt32(MessageBox.Show("Do you want Quit this application ?", "Exit?", MessageBoxButtons.OKCancel));

            if (btnValue == 1) Application.Exit();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double Ans = 0;

            try
            {
                Ans = Convert.ToDouble(textBox1.Text);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show(ex.Message, "Enter the Valid numbers");

            }
            Conv_Cur(Ans);

            using (StreamWriter w = File.AppendText(@"E:\final\moneyconversions.txt"))
            {

                Log(textBox1.Text, w);
                Log(frm_Money.Text, w);

            }

            using (StreamReader r = File.OpenText(@"E:\final\moneyconversions.txt"))
            {
                DumpLog(r);
            }

        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\n ");
            w.WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}");
            w.WriteLine($":{logMessage}");
            w.WriteLine("-------------------------------");
        }
        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        //For Performing the Operation
        void Conv_Cur(double Ans)
        {
            double ans1 = Ans;
            double ans = 0;
            //CAD to CAD
            if (radioButton1.Checked && radioButton10.Checked)
            {
                ans = ans1 * 1;
                frm_Money.Text = Convert.ToString(ans);
            }
            //CAD to USD
            else if (radioButton1.Checked && radioButton9.Checked)
            {
                ans = ans1 * 0.71;
                frm_Money.Text = Convert.ToString(ans);
            }
            //CAD to EUR
            else if (radioButton1.Checked && radioButton8.Checked)
            {
                ans = ans1 * 0.66;
                frm_Money.Text = Convert.ToString(ans);
            }
            //CAD to GBR
            else if (radioButton1.Checked && radioButton7.Checked)
            {
                ans = ans1 * 0.57;
                frm_Money.Text = Convert.ToString(ans);
            }
            //USD to CAD
            else if (radioButton2.Checked && radioButton10.Checked)
            {
                ans = ans1 * 1.4;
                frm_Money.Text = Convert.ToString(ans);
            }
            //USD to USD
            else if (radioButton2.Checked && radioButton9.Checked)
            {
                ans = ans1 * 1;
                frm_Money.Text = Convert.ToString(ans);
            }
            //USD to EUR
            else if (radioButton2.Checked && radioButton8.Checked)
            {
                ans = ans1 * 0.92;
                frm_Money.Text = Convert.ToString(ans);
            }


            //EUR to CAD
            else if (radioButton3.Checked && radioButton10.Checked)
            {
                ans = ans1 * 1.52;
                frm_Money.Text = Convert.ToString(ans);
            }
            //EUR to USD
            else if (radioButton3.Checked && radioButton9.Checked)
            {
                ans = ans1 * 1.08;
                frm_Money.Text = Convert.ToString(ans);
            }
            //EUR to EUR
            else if (radioButton3.Checked && radioButton8.Checked)
            {
                ans = ans1 * 1;
                frm_Money.Text = Convert.ToString(ans);
            }
            //GBP to CAD
            else if (radioButton4.Checked && radioButton10.Checked)
            {
                ans = ans1 * 1.75;
                frm_Money.Text = Convert.ToString(ans);
            }
            //GBP to USD
            else if (radioButton4.Checked && radioButton9.Checked)
            {
                ans = ans1 * 1.25;
                frm_Money.Text = Convert.ToString(ans);
            }
            //GBP to EUR
            else if (radioButton4.Checked && radioButton8.Checked)
            {
                ans = ans1 * 1.15;
                frm_Money.Text = Convert.ToString(ans);
            }   
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            String filename = @"E:\final\moneyconversions.txt";
            using (StreamReader rdr = new StreamReader(filename))
            {
                String content = rdr.ReadToEnd();
                MessageBox.Show(content, "Ravi Patel");
            }

        }
    }
}
