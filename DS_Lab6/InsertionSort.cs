using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab6
{
    public static class InsertionSort
    {
        public static void Main(string[] args)
        {
            PrintSortedArray(new byte[] { 1, 2, 3, 4, 5, 6, 7, });

            Console.WriteLine("\n");
            PrintSortedArray(null);

            Console.WriteLine("\n");
            PrintSortedArray(new byte[] { 23, 8, 43, 77, 120, 0, 0, 87 });

            Console.WriteLine("\n");
            PrintSortedArray(Array.Empty<byte>());
        }

        public static void PrintSortedArray(byte[] data)
        {
            Console.WriteLine("Insertion sort");
            Console.Write("Input: ");
            ArrayHandler.PrintArray(data);
            Console.Write("\nResult: ");
            try
            {
                ArrayHandler.PrintArray(Sort(data));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static byte[] Sort(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (data.Length <= 0)
                throw new ArgumentException(null, nameof(data));

            for (int i = 1; i < data.Length; i++)
            {
                byte current = data[i];
                int j = i - 1;

                while (j >= 0 && data[j] < current)
                {
                    data[j + 1] = data[j];
                    j--;
                }

                data[j + 1] = current;
            }

            return data;
        }
    }
}
