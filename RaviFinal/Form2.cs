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
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit", "Close The App", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            int temp = 0;
            int[] Number = new int[7];
            string temp1 = "";

            for (int i = 0; i < Number.Length; i++)
            {
                temp = random.Next(1, 49);
                Number[i] = getNum(Number, temp, random);
                temp1 += Number[i] + "\n";
            }
            textBox1.Text = temp1;


            using (StreamWriter w = File.AppendText(@"E:\final\LottoNbrs.txt"))
            {
                Log(textBox1.Text, w);
            }

            using (StreamReader r = File.OpenText(@"E:\final\LottoNbrs.txt"))
            {
                DumpLog(r);
            }

        }
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLottoMax;");
            w.WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}");
            w.WriteLine($"Bonus:{logMessage}");
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

        public int getNum(int[] Number, int temp, Random random)
        {
            int n = 0;
            while (n <= Number.Length - 1)
            {
                if (Number[n] == temp)
                {
                    temp = random.Next(1, 49);
                    getNum(Number, temp, random);
                }
                n++;
            }
            return temp;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String filename = @"E:\final\LottoNbrs.txt";
            using (StreamReader rdr = new StreamReader(filename))
            {
                String content = rdr.ReadToEnd();

                MessageBox.Show(content, "Ravi Patel");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
