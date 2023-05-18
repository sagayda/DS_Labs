namespace DS_Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation equation = new(1,0,1);
            QuadraticEquationSolutionByDiscriminant solutionByDiscriminant = new(equation);

            foreach (var root in solutionByDiscriminant.GetComplexRoots())
            {
                Console.WriteLine(root);
            }
        }
    }
}