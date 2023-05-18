namespace DS_Lab7.Strategies
{
    public class InsertionSortAlgorithm : ISortingAlgorithm
    {
        public byte[] Sort(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            if (data.Length <= 0)
                throw new ArgumentException("data");

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
