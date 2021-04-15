using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravi
{
    class Calculator
    {
        public string calc(char op, double num1, double num2)
        {


            if (op == '+')
            {
                return (num1 + num2).ToString();
            }
            else if (op == '-')
            {
                return (num1 - num2).ToString();
            }
            else if (op == '*')
            {
                return (num1 * num2).ToString();
            }
            else
            {
                return (num1 / num2).ToString();
            }

        }
    }
}
