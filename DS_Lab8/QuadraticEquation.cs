using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Lab8
{
    public class QuadraticEquation
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override string ToString()
        {
            return $"{A}*x^2 + {B}*x -{C} = 0";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if(GetType() != obj.GetType())
                return false;

            QuadraticEquation otherEquation = (QuadraticEquation)obj;
            return A == otherEquation.A && B == otherEquation.B && C == otherEquation.C;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }
    }
}
