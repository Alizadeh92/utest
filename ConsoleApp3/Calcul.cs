using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Calcul
    {
        public double Summa(double a, double b)
        {
            return (a + b);
        }

        public double Minus(double a, double b)
        {
            return (a - b);
        }
        public double Umnoj (double a, double b)
        {
            return (a * b);
        }
        public double Delen ( double a, double b)
        {
            return a / b;
        }
        public double Koren ( double a)
        {
            return Math.Sqrt(a);
        }
    }
}
