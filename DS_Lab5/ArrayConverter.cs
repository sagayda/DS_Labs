using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab5
{
    public static class ArrayConverter
    {
        public static int[][] ConvertToArray(string array)
        {
            var rows = array.Split('\n');
            int[][] resArray = new int[rows.Length][];

            for (int i = 0; i < rows.Length; i++)
            {
                var elems = rows[i].Split(',');

                if(elems.Length == 1 && elems[0] == "null")
                {
                    resArray[i] = null;
                    continue;
                }

                if(elems.Length == 1 && elems[0] == "")
                {
                    resArray[i] = Array.Empty<int>();
                    continue;
                }

                resArray[i] = new int[elems.Length];

                for (int j = 0; j < elems.Length; j++)
                {
                    resArray[i][j] = int.Parse(elems[j]);
                }
            }

            return resArray;
        }
        public static void PrintArray(int[][] array)
        {
            if (array == null || array.Length <= 0)
            {
                Console.Write("Empty or null array\n");
                return;
            }

            foreach (var row in array)
            {
                if (row == null || row.Length <= 0)
                {
                    Console.Write("Empty or null row\n");
                    continue;
                }

                foreach (var item in row)
                {
                    Console.Write($"{item}, ");
                }
                Console.Write("\n");
            }
        }
    }
}
