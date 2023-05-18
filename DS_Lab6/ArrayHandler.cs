using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab6
{
    public static class ArrayHandler
    {
        public static void PrintArray(byte[] arr)
        {
            if (arr == null || arr.Length == 0) 
            {
                Console.Write("Empty or null array");
                return; 
            }

            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
