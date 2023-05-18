namespace DS_Lab5
{
    public static class Task2
    {
        //Знайти найменше зі значень елементів стовпця, який має найбільшу суму модулів елементів.
        //Якщо таких стовпців декілька, то знайти найменше значення серед них.
        public static void Main(string[] args)
        {
            Run(ArrayConverter.ConvertToArray("19,25,2\n25,0,0\n1,20,0\n50,50,0"));

            Run(ArrayConverter.ConvertToArray("20,25,2\n25,-5,0\n5,20,0\n50,50,0"));

            Run(ArrayConverter.ConvertToArray("19,25,2\n\n1,20,0\n50,50,0"));

            Run(ArrayConverter.ConvertToArray("19,25,2\n25,0,0\nnull\n50,50,0"));

            Run(null);

            Run(ArrayConverter.ConvertToArray("19,25,2\n25,0,0\n50,50,0\n50,50,0,10"));
        }

        public static void Run(int[][] matrix)
        {
            Console.WriteLine("\n\nTask 2 (1)");
            Console.WriteLine("Input:");
            ArrayConverter.PrintArray(matrix);
            Console.Write("\nResult: ");

            try
            {
                Console.Write(MinElementInLargestColumn(matrix));
            }
            catch (Exception e)
            {
                Console.Write($"Exeption: {e.Message}");
            }
        }

        public static int MinElementInLargestColumn(int[][] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException("Matrix is null");

            if (matrix.Length == 0)
                throw new ArgumentException("Invalid matrix");

            int matrixColoumnsCount = matrix[0].Length;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] == null)
                    throw new ArgumentNullException("Matrix is null");

                if (matrix[i].Length != matrixColoumnsCount)
                    throw new ArgumentException("Matrix is not rectangular");
            }

            int maxElentsSum = 0;
            List<int> coloumnsWithLargestSumIndex = new List<int>();

            for (int j = 0; j < matrixColoumnsCount; j++)
            {
                int elementsSum = 0;

                for (int i = 0; i < matrix.Length; i++)
                {
                    elementsSum += Math.Abs(matrix[i][j]);
                }

                if(maxElentsSum < elementsSum)
                {
                    maxElentsSum = elementsSum;
                    coloumnsWithLargestSumIndex.Clear();
                    coloumnsWithLargestSumIndex.Add(j);
                    continue;
                }

                if(maxElentsSum == elementsSum)
                {
                    coloumnsWithLargestSumIndex.Add(j);
                }
            }


            int minElelm = matrix[0][coloumnsWithLargestSumIndex[0]];

            foreach (var index in coloumnsWithLargestSumIndex)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    if(minElelm > matrix[i][index])
                    {
                        minElelm = matrix[i][index];
                    }
                }
            }

            return minElelm;
        }
    }
}
