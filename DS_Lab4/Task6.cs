using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab4
{
    public static class Task6
    {
        public static void Main(string[] args)
        {
            //Знайти мінімальний елемент, що кратний 5
            double[] doubles0 = { 88, 3, 10, 15 };
            try
            {
                Run(doubles0);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles1 = { -50, 3, 10, 15, 99, 500 };
            try
            {
                Run(doubles1);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles2 = Array.Empty<double>();
            try
            {
                Run(doubles2);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles3 = null;
            try
            {
                Run(doubles3);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        static double Run(double[] array)
        {
            Console.WriteLine("\nTask 1 (6)");
            Console.Write("Input: ");
            ArrayPrinter.Print(array);
            Console.Write($"\n\tResult: ");

            if (array == null)
                throw new NullReferenceException("Array is null");

            if (array.Length == 0)
                throw new ArgumentException("Array is empty");

            double res = double.NaN;
            foreach (double num in array)
            {
                if(num % 5 == 0 && (double.IsNaN(res) || res > num))
                {
                    res = num;
                }
            }

            if (double.IsNaN(res))
                throw new ArgumentException("No elements found that are multiples of 5\r\n");

            Console.Write(res);
            return res;
        }
    }
}
