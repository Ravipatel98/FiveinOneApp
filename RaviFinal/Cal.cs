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
using Ravi;

namespace Ravi
{
    public partial class frm_Cal : Form

    {
       
      

       Calculator calculator = new Calculator();
        double num1, num2;
        char op;
        bool eq = false;
    public frm_Cal()   
{
            InitializeComponent();
}
       

        private void Frm_Calc_Load(object sender, EventArgs e)
{
    //frm_Calc_lblName.Text = "Welcome to Calculator.";
}



        private void button18_Click(object sender, EventArgs e)
        {
    if (MessageBox.Show("Do You Want to Exit", "Close The App", MessageBoxButtons.YesNo).ToString() == "Yes")
    {
        this.Close();
    }

}



private void button1_Click(object sender, EventArgs e)
{

    if (button1.Text == "0")
    {
        textBox1.Text = "1";
    }
    else if (eq == true)
    {
        textBox1.Text = "1";
        eq = false;
    }
    else
    {
        textBox1.Text += "1";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}



private void button2_Click(object sender, EventArgs e)
{
    if (textBox1.Text == "0")
    {
        textBox1.Text = "2";
    }
    else if (eq == true)
    {
        textBox1.Text = "2";
        eq = false;
    }
    else
    {
        textBox1.Text += "2";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}



private void button3_Click(object sender, EventArgs e)
{
    if (textBox1.Text == "0")
    {
        textBox1.Text = "3";
    }
    else if (eq == true)
    {
        textBox1.Text = "3";
        eq = false;
    }
    else
    {
        textBox1.Text += "3";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}



        private void button4_Click_1(object sender, EventArgs e)
        {
    if (textBox1.Text == "0")
    {
        textBox1.Text = "4";
    }
    else if (eq == true)
    {
        textBox1.Text = "4";
        eq = false;
    }
    else
    {
        textBox1.Text += "4";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }

}



        private void button5_Click_1(object sender, EventArgs e)
        {
    if (textBox1.Text == "0")
    {
        textBox1.Text = "5";
    }
    else if (eq == true)
    {
        textBox1.Text = "5";
        eq = false;
    }
    else
    {
        textBox1.Text += "5";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }

}



        private void button6_Click_1(object sender, EventArgs e)
        {
    if (textBox1.Text == "0")
    {
        textBox1.Text = "6";
    }
    else if (eq == true)
    {
        textBox1.Text = "6";
        eq = false;
    }
    else
    {
        textBox1.Text += "6";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}



        private void button7_Click_1(object sender, EventArgs e)
        {
    if (textBox1.Text == "0")
    {
        textBox1.Text = "7";
    }
    else if (eq == true)
    {
        textBox1.Text = "7";
        eq = false;
    }
    else
    {
        textBox1.Text += "7";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}


        private void button8_Click_1(object sender, EventArgs e)
        {
    if (textBox1.Text == "0")
    {
        textBox1.Text = "8";
    }
    else if (eq == true)
    {
        textBox1.Text = "8";
        eq = false;
    }
    else
    {
        textBox1.Text += "8";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}



        private void button9_Click_1(object sender, EventArgs e)
        {
    if (textBox1.Text == "0")
    {
        textBox1.Text = "9";
    }
    else if (eq == true)
    {
        textBox1.Text = "9";
        eq = false;
    }
    else
    {
        textBox1.Text += "9";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}


private void button10_Click(object sender, EventArgs e)
{
    if (textBox1.Text == "0")
    {
        textBox1.Text = "0";
    }
    else if (eq == true)
    {
        textBox1.Text = "0";
        eq = false;
    }
    else
    {
        textBox1.Text += "0";
    }

    try
    {
        num2 = Convert.ToDouble(textBox1.Text);

    }
    catch
    {
        textBox1.Text = "Error!!!!!!!";
    }
}
        private void btnDot_Click(object sender, EventArgs e)
        {
    if (textBox1.Text.Contains("."))
    {
        MessageBox.Show("you can enter only one dot");
        textBox1.Focus();
    }
    else
    {
        textBox1.Text += ".";
    }
}



        private void button13_Click(object sender, EventArgs e)
        {
    eq = true;

    if (eq == true)
    {
        try
        {
            num1 = Convert.ToDouble(textBox1.Text);
        }
        catch
        {
            textBox1.Text = "Error!!!!!!!";
        }
    }

    op = '+';

}



        private void button14_Click(object sender, EventArgs e)
        {
    eq = true;
    if (eq == true)
    {
        try
        {
            num1 = Convert.ToDouble(textBox1.Text);
        }
        catch
        {
            textBox1.Text = "Error!!!!!!!";
        }
    }

    op = '-';

}



        private void button15_Click(object sender, EventArgs e)
        {
            eq = true;
         if (eq == true)
    {
        try
        {
            num1 = Convert.ToDouble(textBox1.Text);
        }
        catch
        {
            textBox1.Text = "Error!!!!!!!";
        }
    }

    op = '*';

}


        private void button16_Click(object sender, EventArgs e)
        {
    eq = true;
    if (eq == true)
    {
        try
        {
            num1 = Convert.ToDouble(textBox1.Text);
        }
        catch
        {
            textBox1.Text = "Error!!!!!!!";
        }
    }

    op = '/';

}

private void Frm_Calc_btnRead_Click(object sender, EventArgs e)
{
    String filename = @"E:\final\calculator.txt";
    using (StreamReader rdr = new StreamReader(filename))
    {
        String content = rdr.ReadToEnd();
        MessageBox.Show(content, "Dhruvil Patel");
    }
}
public static void Log(string logMessage, TextWriter w)
{
    w.Write("\r\nAns is ");
    w.WriteLine($":{logMessage}");
    w.WriteLine("-------------------------------");
}

        private void button12_Click(object sender, EventArgs e)
        {
    textBox1.Text = "0";
    num1 = 0;
    num2 = 0;

}

public static void DumpLog(StreamReader r)
{
    string line;
    while ((line = r.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

        

        private void button17_Click(object sender, EventArgs e)
        {



    textBox1.Text = calculator.calc(op, num1, num2);
    using (StreamWriter w = File.AppendText(@"E:\final\calculator.txt"))
    {
        Log(textBox1.Text, w);

    }

    using (StreamReader r = File.OpenText(@"E:\final\calculator.txt"))
    {
        DumpLog(r);
    }
}
    }
}
