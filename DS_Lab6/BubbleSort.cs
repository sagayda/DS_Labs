namespace DS_Lab6
{
    public static class BubbleSort
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
            Console.WriteLine("Bubble sort");
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

            bool canStop = false;
            while (!canStop)
            {
                canStop = true;
                for (int i = 1; i < data.Length; i++)
                {
                    if (data[i - 1] < data[i])
                    {
                        var temp = data[i - 1];
                        data[i - 1] = data[i];
                        data[i] = temp;
                        canStop = false;
                    }
                }
            }

            return data;
        }
    }
}
