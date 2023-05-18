using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab8
{
    public class QuadraticEquationSolutionByDiscriminant : IQuadraticEquationSolver
    {
        private QuadraticEquation equation;
        public QuadraticEquation Equation
        {
            get { return equation; }
            set
            {
                equation = value ?? throw new ArgumentNullException(nameof(equation), "Quadratic equation can't be null");
                Discriminant = Math.Pow(Equation.B, 2) - 4 * Equation.A * Equation.C;
            }
        }

        public int RealRootsCount 
        { 
            get 
            {
                if (Discriminant > 0)
                    return 2;
                else if (Discriminant == 0)
                    return 1;
                else 
                    return 0;
            } 
        }

        public int ComplexRootsCount
        {
            get
            {
                if (Discriminant < 0)
                    return 2;
                else 
                    return 0;
            }
        }

        public double Discriminant { get; private set; }

        public QuadraticEquationSolutionByDiscriminant(QuadraticEquation equation)
        {
            Equation = equation;
        }

        public double[] GetRealRoots()
        {
            if(Equation == null)
                throw new ArgumentNullException(nameof(Equation), "Quadratic equation is not set");

            double[] roots;
            
            if(Discriminant == 0)
            {
                roots = new double[1];
                roots[0] = -Equation.B / (2 * Equation.A);
                return roots;
            }

            if(Discriminant > 0)
            {
                roots = new double[2];
                roots[0] = (-Equation.B + Math.Sqrt(Discriminant)) / (2 * Equation.A);
                roots[1] = (-Equation.B - Math.Sqrt(Discriminant)) / (2 * Equation.A);
                return roots;
            }

            throw new InvalidOperationException("Equation does't have real roots");
        }

        public Complex[] GetComplexRoots()
        {
            if (Equation == null)
                throw new ArgumentNullException(nameof(Equation), "Quadratic equation is not set");

            Complex[] roots;

            if(Discriminant < 0)
            {
                roots = new Complex[2];

                double realPart = -Equation.B / (2 * Equation.A);
                double imaginaryPart = Math.Sqrt(-Discriminant) / (2 * Equation.A);

                roots[0] = new Complex(realPart, imaginaryPart);
                roots[1] = new Complex(realPart, -imaginaryPart);

                return roots;
            }

            throw new InvalidOperationException("Equation does't have complex roots");
        }
    }
}
