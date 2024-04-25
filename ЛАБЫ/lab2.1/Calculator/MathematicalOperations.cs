using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class MathematicalOperations
    {

        public static double Score(string symbols)
        {

            Stack<char> operands = new Stack<char>();
            Stack<double> operators = new Stack<double>();

            foreach (var c in symbols)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    operands.Push(c);
                }
                else
                {
                    operators.Push(c);
                }
            }

            return operands.Count();
        }
    }
}
