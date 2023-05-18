namespace DS_Lab7.Strategies
{
    public class BubbleSortAlgorithm : ISortingAlgorithm
    {
        public byte[] Sort(byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            if (data.Length <= 0)
                throw new ArgumentException("data");

            bool canStop = false;
            while (!canStop)
            {
                canStop = true;
                for (int i = 1; i < data.Length; i++)
                {
                    if (data[i - 1] < data[i])
                    {
                        byte temp = data[i - 1];
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
