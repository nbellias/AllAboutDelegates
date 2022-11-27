using MyClassLibrary;
using System;

namespace FuncDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Func delegates...");

            MyServices myServices = new();

            Func<int,int,int> f = myServices.AddTwoIntegers;
            Console.WriteLine(f(3, 6));
            f = myServices.SubtractTwoIntegers;
            Console.WriteLine(f(3, 6));
            f = myServices.MultiplyTwoIntegers;
            Console.WriteLine(f(3, 6));
            
            // With lambda expression as an anonymous method
            f = (x, y) => x + y + (x * y);
            Console.WriteLine(f(2,3));

            // Roll the dice ten times
            Console.WriteLine("Roll the dice ten times:");
            for(int i = 0; i <= 10; i++)
            {
                Func<int> g = myServices.RollTheDice;
                Console.WriteLine($"#{i + 1} {g()}");
            }
            

        }
    }
}