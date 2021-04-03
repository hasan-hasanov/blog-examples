using System;

namespace AnonymousDelegateMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------- Func --------------------------------------- //
            Func<double, int, string> powerOfNumber = (a, power) =>
            {
                return $"Power of {a} is {Math.Pow(a, power)}.";
            };

            string result = powerOfNumber(10.00, 2);
            Console.WriteLine(result);

            // ----------------------------- Action -------------------------------------- //
            Action<string, int, DateTime> printer = (name, age, birthDate) =>
            {
                Console.WriteLine($"{name}, {age}, {birthDate}");
            };

            printer("Yeva Kohar", 66, new DateTime(1954, 7, 4));
        }
    }
}
