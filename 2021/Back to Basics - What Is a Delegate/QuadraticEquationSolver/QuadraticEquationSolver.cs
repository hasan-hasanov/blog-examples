using System;

namespace QuadraticEquationSolver
{
    public class QuadraticEquationSolver
    {
        private readonly Action<string> _log;

        public QuadraticEquationSolver()
        {
            _log = (message) => { };
        }

        public QuadraticEquationSolver(Action<string> log)
        {
            _log = log;
        }

        public double[] Solve(double a, double b, double c)
        {
            double discriminant, denominator, x1, x2;
            if (a == 0)
            {
                x1 = -c / b;

                _log($"The roots are equal: {x1}");

                return new double[] { x1 };
            }
            else
            {
                discriminant = (b * b) - (4 * a * c);
                denominator = 2 * a;
                if (discriminant > 0)
                {
                    _log("The roots are real and not equal");

                    x1 = (-b / denominator) + (Math.Sqrt(discriminant) / denominator);
                    x2 = (-b / denominator) - (Math.Sqrt(discriminant) / denominator);

                    _log($"Roots are found {x1} and {x2}");

                    return new double[] { x1, x2 };
                }
                else if (discriminant == 0)
                {
                    _log($"Discriminant is 0, the roots are equal");

                    x1 = -b / denominator;

                    _log($"Roots is found {x1}");

                    return new double[] { x1 };
                }
                else
                {
                    _log($"Roots are imaginery");
                    return Array.Empty<double>();
                }
            }
        }
    }
}
