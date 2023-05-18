using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab5
{
    public static class Task1
    {
        /*Таблиця футбольного чемпіонату задана квадратною матрицею, у якій усі
        елементи, що належать головній діагоналі, дорівнюють нулю, а кожний елемент,
        що не належить головній діагоналі, дорівнює 2, 1 або 0 (числу очок, набраних у
        грі: 2- виграш, 1 - нічия, 0 - програш). Знайти число команд, що мають більше
        перемог, ніж поразок.*/
        //рядки - команда
        //стовбці - ігри

        public static void Main(string[] args)
        {
            Run(ArrayConverter.ConvertToArray("0,2,2\n1,0,0\n1,1,0\n0,0,0"));

            Run(ArrayConverter.ConvertToArray("0,2,2\n1,0,0\n1,1,1"));

            Run(ArrayConverter.ConvertToArray("0,2,2\n1,0,0\n1,0,0"));

            Run(ArrayConverter.ConvertToArray("0,2,2\nnull\n1,0,0"));

            Run(ArrayConverter.ConvertToArray("0,2,2\n\n1,0,0"));

            Run(ArrayConverter.ConvertToArray("0,2,2\n2,0,4\n1,0,0"));

        }

        public static void Run(int[][]  results)
        {
            Console.WriteLine("\n\nTask 1 (6)");
            Console.WriteLine("Input:");
            ArrayConverter.PrintArray(results);
            Console.Write("\nResult: ");

            try
            {
                Console.Write(GetNumberOfWinners(results));
            }
            catch (Exception e)
            {
                Console.Write($"Exeption: {e.Message}");
            }
        }

        public static int GetNumberOfWinners(int[][] results) 
        {



            if (results == null)
                throw new ArgumentNullException("Matrix is null");

            if (results.Length == 0)
                throw new ArgumentException("Invalid matrix");

            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] == null)
                    throw new ArgumentNullException("Matrix is null");

                if (results[i].Length != results.Length)
                    throw new ArgumentException("Invalid matrix (Matrix is not square)");

                if (results[i][i] != 0)
                    throw new ArgumentException("Invalid matrix (Main diagonal is not 0)");
            }


            int[] totalResults = new int[results.Length];

            for (int i = 0; i < results.Length; i++)
            {
                for (int j = 0; j < results[i].Length; j++)
                {
                    if (i == j)
                        continue;

                    if (results[i][j] == 0) 
                    {
                        totalResults[i]--;
                    }
                    else if (results[i][j] == 1)
                    {
                        continue;
                    }
                    else if (results[i][j] == 2)
                    {
                        totalResults[i]++;
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid matrix (element at {i+1},{j+1} is not 0/1/2)");
                    }
                }
            }

            int commandsWithMoreVictories = 0;
            for (int i = 0; i < totalResults.Length; i++)
            {
                if (totalResults[i] > 0)
                    commandsWithMoreVictories++;
            }

            return commandsWithMoreVictories;
        }
    }
}
