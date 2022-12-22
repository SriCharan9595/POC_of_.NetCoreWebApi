using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFuncApi.Core.Services
{
    public interface IArithmetic
    {
        string getAdd(int num1, int num2);

        string getSub(int num1, int num2);

        string getProd(int num1, int num2);

        string getDiv(int num1, int num2);
    }
}
