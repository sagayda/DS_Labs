namespace DS_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0 / 0.0;

            if(a == Double.NaN)
            {
                Console.WriteLine("Nan");
            }
            else
            {
                Console.WriteLine("Not Nan");
            }

            if(Double.IsNaN(a))
            {
                Console.WriteLine("Nan");
            }
            else
            {
                Console.WriteLine("Not Nan");
            }

            Console.WriteLine(Double.NaN == Double.NaN);

            //Task1.Main(args);
            //Task2.Main(args);
            //Task3.Main(args);
        }
    }
}