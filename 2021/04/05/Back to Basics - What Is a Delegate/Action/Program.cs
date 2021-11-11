using System;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, int, DateTime> printer = PrintPerson;
            printer("Yeva Kohar", 66, new DateTime(1954, 7, 4));
        }

        static void PrintPerson(string name, int age, DateTime birthDate)
        {
            Console.WriteLine($"{name}, {age}, {birthDate}");
        }
    }
}
