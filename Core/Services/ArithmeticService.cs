using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFuncApi.Core.Services
{
    public class ArithmeticService : IArithmetic

    {
        public string getAdd(int num1, int num2)
        {
            int sum = 0;
            if (num1 >= 0 && num2 >= 0)
            {
                sum = (num1 + num2);
                return $"The sum is {sum}";
            }
            else
                return "Enter the proper inputs in query parameter";
        }

        public string getSub(int num1, int num2)
        {
            int sub = 0;
            if (num1 >= 0 && num2 >= 0)
            {
                sub = (num1 - num2);
                return $"The difference is {sub}";
            }
            else
                return "Enter the proper inputs in query parameter";
        }

        public string getProd(int num1, int num2)
        {
            int prod = 0;
            if (num1 >= 0 && num2 >= 0)
            {
                prod = (num1 * num2);
                return $"The product is {prod}";
            }
            else
                return "Enter the proper inputs in query parameter";
        }

        public string getDiv(int num1, int num2)
        {
            int div = 0;
            if (num1 >= 0 && num2 >= 0)
            {
                div = (num1 / num2);
                return $"The quotient is {div}";
            }
            else if (num2 == 0)
            {
                throw new DivideByZeroException("num2 can't be zero for division");
            }
            else
                return "Enter the proper inputs in query parameter";
        }
    }
}
