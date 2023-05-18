namespace DS_Lab4
{
    public static class Task66
    {
        public static void Main(string[] args)
        {
            //Задано масиви А(n) та В(m). Сформувати масив С(n+m), елементами якого є n елементів масиву A, за якими слідують m елементів масиву B
            double[] doubles1 = { 1, 2, 3, 4, 5 };
            double[] doubles2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            try
            {
                Run(doubles1, doubles2);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles11 = Array.Empty<double>();
            double[] doubles21 = { 1, 2, 3, 4, 5, 6, -10 };
            try
            {
                Run(doubles11, doubles21);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles12 = { 95, 959, -8, 1 };
            double[] doubles22 = Array.Empty<double>();
            try
            {
                Run(doubles12, doubles22);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            double[] doubles13 = null;
            double[] doubles23 = Array.Empty<double>();
            try
            {
                Run(doubles13, doubles23);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

        }

        static double[] Run(double[] arrayA, double[] arrayB)
        {
            Console.WriteLine("\nTask 3 (66)");
            Console.Write("Input: ");
            Console.Write("\n\tArray 1: ");
            ArrayPrinter.Print(arrayA);
            Console.Write("\n\tArray 2: ");
            ArrayPrinter.Print(arrayB);
            Console.Write("\n\t\tResult: ");

            if (arrayA == null || arrayB == null)
                throw new NullReferenceException("Array is null");

            double[] res = new double[arrayA.Length + arrayB.Length];
            for (int i = 0; i < res.Length; i++)
            {
                if (i < arrayA.Length)
                {
                    res[i] = arrayA[i];
                }
                else
                {
                    res[i] = arrayB[i - arrayA.Length];
                }
            }

            ArrayPrinter.Print(res);
            return res;
        }
    }
}
