using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab3
{
    public static class Task2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tTask 2");
            PrintResults(0, 0);
            PrintResults(0, 1);
            PrintResults(1, 0);
            PrintResults(1, 1);
            PrintResults(2, 1);
            PrintResults(1, 2);
            PrintResults(2, -10);
            PrintResults(20, 20);
            PrintResults(21, -21);
            PrintResults(1, 10);
            PrintResults(-1, 10);
            PrintResults(0, 256);
            PrintResults(16, 256);
            PrintResults(1, int.MinValue);
            PrintResults(double.NaN, 2);
        }
        private static void CheckInput(int i)
        {
            if (i <= 0)
                throw new ArgumentOutOfRangeException(nameof(i), i, "Invalid value");

        }
        private static void PrintResults(double t, int i)
        {
            try
            {
                CheckInput(i);
            }
            catch (Exception e)
            {
                Console.WriteLine($"t: {t}, i:{i};\tres:{e.Message}");
                return;
            }

            double res = 0;

            if (i == 1 || i == 2)
            {
                res = Math.Log(t);
            }
            else
            {
                for (int k = 1; k <= i; k++)
                {
                    res += Math.Sin(t) / k;
                }
            }

            Console.WriteLine($"t: {t}, i:{i};\tres:{res}");
        }
    }

}
