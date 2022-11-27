using MyClassLibrary;
using System;

namespace PredicateDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Predicate delegates...");

            MyServices myServices = new();

            Predicate<int> p = myServices.DividesByThree;
            Console.WriteLine(p(12));

            // As lambda expression and anonymous method
            p = (x) => x > 10;
            Console.WriteLine(p(4));

        }
    }
}