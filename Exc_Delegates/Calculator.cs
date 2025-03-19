using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_Delegates
{
    public delegate int MathOperation(int a, int b);
    public class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
    }
}
