using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab4
{
    public static class Task36
    {
        public static void Main(string[] args)
        {
            //Визначити середнє геометричне номерів максимального та мінімального елементів масиву
            double[] doubles0 = { 88, 3, 10, 15 };
            try
            {
                Run(doubles0);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles1 = { 8, 2, 4, 947, -48 };
            try
            {
                Run(doubles1);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles2 = { 2, 2 };
            try
            {
                Run(doubles2);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles3 = Array.Empty<double>();
            try
            {
                Run(doubles3);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles4 = null;
            try
            {
                Run(doubles4);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public static double Run(double[] array)
        {
            Console.WriteLine("\nTask 2 (36)");
            Console.Write("Input: ");
            ArrayPrinter.Print(array);
            Console.Write($"\n\tResult: ");

            if (array == null)
                throw new ArgumentNullException("Array is null");

            if (array.Length == 0)
                throw new ArgumentException("Array is empty");

            double minNum = array[0];
            double minNumIndex = 0;
            double maxNum = array[0];
            double maxNumIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (minNum > array[i])
                {
                    minNum = array[i];
                    minNumIndex = i;
                }

                if (maxNum < array[i])
                {
                    maxNum = array[i];
                    maxNumIndex = i;
                }
            }

            double res = Math.Sqrt(maxNumIndex * minNumIndex);
            Console.Write(res);
            return res;
        }
    }
}
