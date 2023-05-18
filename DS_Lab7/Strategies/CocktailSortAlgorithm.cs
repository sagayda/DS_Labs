namespace DS_Lab7.Strategies
{
    public class CocktailSortAlgorithm : ISortingAlgorithm
    {
        public byte[] Sort(byte[] data)
        {
            int left = 0;
            int right = data.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (data[i] < data[i + 1])
                        Swap(data, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (data[i - 1] < data[i])
                        Swap(data, i - 1, i);
                }
                left++;
            }

            return data;
        }

        static void Swap(byte[] data, int i, int j)
        {
            byte temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}
