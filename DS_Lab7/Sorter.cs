using DS_Lab7.Strategies;

namespace DS_Lab7
{
    public class Sorter
    {
        public byte[]? Values { get; set; }

        public ISortingAlgorithm? SortingAlgorithm { get; set; }

        public byte[] Sort()
        {
            if (Values == null)
                throw new ArgumentNullException(nameof(Values));

            if (SortingAlgorithm == null)
                throw new ArgumentNullException(nameof(SortingAlgorithm));

            return SortingAlgorithm.Sort(Values);
        }

        public void PrintSorted()
        {
            Console.Write($"\n>>>\nSorting algorithm: {SortingAlgorithm}\n");

            Console.Write("Inserted values:\n\t");
            if (Values == null || Values.Length == 0)
                Console.Write("Empty or null array");
            else
                foreach (var value in Values)
                    Console.Write($"{value} ");

            Console.Write("\nReturned values:\n\t");
            try
            {
                var res = Sort();

                if (res == null || res.Length == 0)
                    Console.Write("Empty or null array");
                else
                    foreach (var value in res)
                        Console.Write($"{value} ");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public void Randomize()
        {
            if(Values == null)
                throw new ArgumentNullException(nameof(Values));

            Random random = new Random();
            random.NextBytes(Values);
        }
    }
}
