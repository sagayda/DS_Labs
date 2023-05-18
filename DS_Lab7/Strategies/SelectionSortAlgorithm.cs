namespace DS_Lab7.Strategies
{
    public class SelectionSortAlgorithm : ISortingAlgorithm
    {
        public byte[] Sort(byte[] data)
        {
            int n = data.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (data[j] > data[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                byte temp = data[maxIndex];
                data[maxIndex] = data[i];
                data[i] = temp;
            }

            return data;
        }
    }
}
