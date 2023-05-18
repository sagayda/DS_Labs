using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab4
{
    public static class ArrayPrinter
    {
        public static void Print<T>(T[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.Write("Empty array or null");
                return;
            }

            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
