using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab3
{
    public static class Task3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tTask 3");
            PrintResults(0);
            PrintResults(0.1);
            PrintResults(2);
            PrintResults(-0.01);
            PrintResults(0.000001);
            PrintResults(-0.000001);
            PrintResults(0.000000000000001);
            PrintResults(double.MaxValue);
            PrintResults(double.MinValue);
            PrintResults(double.NaN);
        }
        private static void PrintResults(double e)
        {
            double sum = 0;
            int i = 1;

            do
            {
                sum += Math.Pow(-1, i) / Factorial(i);
                i++;
            } while (Math.Abs(Math.Pow(-1, i) / Factorial(i)) > Math.Abs(e));

            Console.WriteLine($"e: {e};\tres:{sum}");
        }

        private static double Factorial(int i)
        {
            double res = 1;
            for (int k = 1; k <= i; k++)
            {
                res *= k;
            }
            return res;
        }
    }
}
