using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, int, string> powerOfNumber = Power;
            string result = powerOfNumber(10.00, 2);

            Console.WriteLine(result);
        }

        static string Power(double a, int power)
        {
            return $"Power of {a} is {Math.Pow(a, power)}.";
        }
    }
}
