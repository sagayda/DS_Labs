using System.Numerics;

namespace DS_Lab8
{
    public interface IQuadraticEquationSolver
    {
        public QuadraticEquation Equation { get; set; }

        public int RealRootsCount { get; }

        public int ComplexRootsCount { get; }

        public Complex[] GetComplexRoots();

        public double[] GetRealRoots();
    }
}
