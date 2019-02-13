using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException();
            }
            string left = "";
            string right = "";
            string _operator = null;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] != ' ')
                {
                    if (_operator == null)
                    {
                        if (expression[i] == '-' | expression[i] == '+' | expression[i] == '/' | expression[i] == '*')
                        {
                            _operator += expression[i];
                            continue;
                        }

                        left += expression[i];
                    }
                    else
                    {
                        right += expression[i];
                    }
                }
            }

            int Ileft = int.Parse(left);
            int Iright = int.Parse(right);

            switch (_operator)
            {
                case "+":
                    return Ileft + Iright;
                case "-":
                    return Ileft - Iright;
                case "/":
                    return Ileft / Iright;
                case "*":
                    return Ileft * Iright;
            }

            return 0;
        }
    }
}
