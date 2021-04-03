using System;

namespace Delegate
{
    class Program
    {
        public delegate string PowerOfNumber(double a, int b);

        static void Main(string[] args)
        {
            PowerOfNumber powerOfNumber = new PowerOfNumber(Power);
            string result = powerOfNumber(10.00, 2);

            Console.WriteLine(result);
        }

        static string Power(double a, int power)
        {
            return $"Power of {a} is {Math.Pow(a, power)}.";
        }
    }
}
