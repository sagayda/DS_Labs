using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab3
{
    public static class Task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tTask 1");
            PrintResults(0, 0);
            PrintResults(0, 1);
            PrintResults(1, 0);
            PrintResults(1, 1);
            PrintResults(2, 1);
            PrintResults(1, 2);
            PrintResults(2, -10);
            PrintResults(20, 30);
            PrintResults(21, 31);
            PrintResults(1, 10);
            PrintResults(-1, 10);
            PrintResults(0, int.MaxValue);
            PrintResults(1, int.MaxValue);
            PrintResults(1, int.MinValue);
            PrintResults(double.NaN, 2);
        }

        private static void CheckInput(int? k)
        {
            if (k <= 0 || k > 30)
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
        }

        private static void PrintResults(double m, int k)
        {
            try
            {
                CheckInput(k);
            }
            catch (Exception e)
            {
                Console.WriteLine($"m: {m}, k:{k};\tres:{e.Message}");
                return;
            }

            double sum = 0;

            for (int i = 1; i <= k; i++)
                sum += Math.Sqrt(m * (1 / i)) * Math.Sin(m * i);

            Console.WriteLine($"m: {m}, k:{k};\tres:{sum}");
        }
    }
}
