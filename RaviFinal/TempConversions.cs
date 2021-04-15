using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ravi
{
    public partial class TempConversions : Form
    {
        public TempConversions()
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
                 Ans = Convert.ToDouble(textBox2.Text);
             }
             catch (ArgumentOutOfRangeException ex1)
             {
                 MessageBox.Show(ex1.Message + "Enter the valid NUmbers.");
             }
             Valid_Temp(Ans);
             Valid_Message();
             using (StreamWriter w = File.AppendText(@"E:\final\tempconversions.txt"))
             {
                 Log(textBox1.Text, w);
                 Log(textBox1.Text, w);
                 Log(textBox3.Text, w);
             }

             using (StreamReader r = File.OpenText(@"E:\final\tempconversions.txt"))
             {
                 DumpLog(r);
             }
             void Log(string logMessage, TextWriter w)
             {
                 w.Write("\r\n");
                 w.WriteLine($" {DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}");
                 w.WriteLine($":{logMessage}");
                 w.WriteLine("-------------------------------");
             }
             void DumpLog(StreamReader r)
             {
                 string line;
                 while ((line = r.ReadLine()) != null)
                 {
                     Console.WriteLine(line);
                 }
             }
             
             void Valid_Temp(double Ans2)
            {
                 double ans1 = Ans2, ans = 0;
                 //For Converting Celsius to Fahrenheit (°C × 9 / 5) +32
                 if (radioButton2.Checked)
                 {
                     ans = (ans1 * 9 / 5 + 32);
                     textBox1.Text = Convert.ToString(ans);

                 }
                 //For Converting Fahrenheit to Celsius (°F − 32) x 5/9
                 else if (radioButton1.Checked)
                 {
                     ans = ((ans1 - 32) * 5 / 9);
                     textBox1.Text = Convert.ToString(ans);
                 }
                 else
                 {
                     MessageBox.Show("Enter Valid Values between -40 to 40.");
                     textBox2.Focus();
                 }
                 textBox3.Focus();
             }
             void Valid_Message()
             {
                 double ans = Convert.ToDouble(textBox2.Text);
                 double que = Convert.ToDouble(textBox2.Text);
                

                 if (radioButton2.Checked)
                 {
                     if (que == 100 | ans == 212)
                     {
                         textBox3.Text = "Water Bolis.....";
                         textBox3.BackColor = Color.Red;
                     }
                     else if (que == 40 | ans == 104)
                     {
                         textBox3.Text = "Hot Bath.....";
                         textBox3.BackColor = Color.Red;

                     }
                     else if (que == 37 | ans == 98.6)

                     {
                         textBox3.Text = "Body Temprature.....";
                         textBox3.BackColor = Color.Green;

                     }
                     else if (que == 30 | ans == 86)
                     {
                         textBox3.Text = "Beach weather.....";
                         textBox3.BackColor = Color.Green;

                     }
                     else if (que == 21 | ans == 70)
                     {
                         textBox3.Text = "Room Temprature.....";
                         textBox3.BackColor = Color.Green;

                     }
                     else if (que == 10 | ans == 50)
                     {
                         textBox3.Text = "Cold Day.....";
                         textBox3.BackColor = Color.Blue;

                     }
                     else if (que == 0 | ans == 32)
                     {
                         textBox3.Text = "Frezzing point of water.....";
                         textBox3.BackColor = Color.Blue;

                     }
                     else if (que == -18 | ans == 0)
                     {
                         textBox3.Text = "Very Cold Day.....";
                         textBox3.BackColor = Color.Blue;

                     }
                     else if (que == -40 | ans == -40)
                     {
                         textBox3.Text = "Extremely Cold....\n Same numbers";
                         textBox3.BackColor = Color.Blue;

                     }
                     else
                     {
                         textBox3.Text = "Nothing Good Enough";
                         textBox3.BackColor = Color.Silver;
                     }
                 }
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String filename = @"E:\final\tempconversions.txt";
            using (StreamReader rdr = new StreamReader(filename))
            {
                String content = rdr.ReadToEnd();
                MessageBox.Show(content, "Ravi Patel");
            }

        }
    }
}

