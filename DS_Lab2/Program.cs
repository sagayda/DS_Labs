namespace DS_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variant 6    tasks: 16, 17, 18

            double a = 0.58;
            double b = 0.34;
            double c = 1.25;
            double d = -1.89;
            Console.WriteLine($"\na = {a}, b = {b}, c = {c}, d = {d}");
            double num1 = 2 * ((Math.Sin(a) / (Math.Acos(-2 * b))) - Math.Sqrt(Math.Log(c * Math.Abs(2 * d))));
            Console.WriteLine($"Task 1 result: {num1}");

            a = -1.49;
            b = 23.4;
            c = 1.23;
            d = 2.254;
            Console.WriteLine($"\na = {a}, b = {b}, c = {c}, d = {d}");
            double num2 = 2 * Math.Sqrt(Math.Tan(Math.Abs(a + c))) + (Math.Log(b)) / (Math.Pow(c, d));
            Console.WriteLine($"Task 2 result: {num2}");

            a = 2.34;
            b = 0.756;
            c = 2.23;
            d = -1.653;
            Console.WriteLine($"\na = {a}, b = {b}, c = {c}, d = {d}");
            double num3 = (Math.Pow(Math.E, c) + 2 * Math.Log2(a)) / (Math.Sqrt(Math.Pow(c, b))) * Math.Abs(Math.Asin(d));
            Console.WriteLine($"Task 3 result: {num3}");

        }
    }
}