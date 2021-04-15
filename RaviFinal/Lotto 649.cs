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
    public partial class Lotto_649 : Form
    {
        public Lotto_649()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int btnValue = -1;

            btnValue = Convert.ToInt32(MessageBox.Show("Do you want Quit this application ?", "Exit?", MessageBoxButtons.OKCancel));

            if (btnValue == 1) Application.Exit();
        }

        private void Frm_Lotto_649_Load(object sender, EventArgs e)
        {
            {
                lable_welcome.Text = "Welcome to the Lotto649.";
                frm_Lotto649.Visible = false;

            }

           
    }

        private void frm_Lotto649_lblName_Click(object sender, EventArgs e)
        {

            frm_Lotto649.Visible = true;
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            int temp = 0;
            int[] Number = new int[8];
            string temp1 = "";
            for (int i = 0; i < Number.Length; i++)
            {
                temp = random.Next(1, 49);
                Number[i] = getNum(Number, temp, random);
                temp1 += Number[i] + "\n";
            }
            frm_Lotto649.Text = temp1;


            using (StreamWriter w = File.AppendText(@"E:\final\LottoNbrs.txt"))
            {
                Log(frm_Lotto649.Text, w);
            }

            using (StreamReader r = File.OpenText(@"E:\final\LottoNbrs.txt"))
            {
                DumpLog(r);
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
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\n649;");
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

        private void button2_Click(object sender, EventArgs e)
        {
            String filename = @"E:\final\LottoNbrs.txt";
            using (StreamReader rdr = new StreamReader(filename))
            {
                String content = rdr.ReadToEnd();
                MessageBox.Show(content, "Ravi Patel");

            }

        }

       
    }
}
