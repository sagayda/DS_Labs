using DS_Lab7.Strategies;
using System.Net.Sockets;

namespace DS_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sorter sorter = new Sorter();

            sorter.PrintSorted();

            sorter.Values = new byte[5];

            sorter.PrintSorted();

            sorter.Randomize();
            sorter.SortingAlgorithm = new BubbleSortAlgorithm();
            sorter.PrintSorted();
            sorter.Randomize();
            sorter.SortingAlgorithm = new SelectionSortAlgorithm();
            sorter.PrintSorted();
            sorter.Randomize();
            sorter.SortingAlgorithm = new InsertionSortAlgorithm();
            sorter.PrintSorted();
            sorter.Randomize();
            sorter.SortingAlgorithm = new CocktailSortAlgorithm();
            sorter.PrintSorted();
            sorter.Randomize();
        }
    }
}