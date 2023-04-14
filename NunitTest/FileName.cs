using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest
{
    public class Calculator
    {
        public int Summ (int x, int y) => x + y;

        public int Minus(int x, int y) => x - y;

        public int Divedie(int x, int y) => x / y;

    }
}
