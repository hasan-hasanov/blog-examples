using System;
using System.Diagnostics;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<string> logger = (message) =>
            //{
            //    Debug.WriteLine(message);
            //};

            Action<string> logger = (message) => { };
            QuadraticEquationSolver solver = new QuadraticEquationSolver(logger);
            double[] answers = solver.Solve(5, 3, 6);

            foreach (var answer in answers)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
