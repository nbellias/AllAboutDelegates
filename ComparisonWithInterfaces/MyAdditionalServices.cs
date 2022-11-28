using System;
namespace ComparisonWithInterfaces
{
    public class MyAdditionalServices
    {
        public MyAdditionalServices(int hours, int mins)
        {

        }

        public MyAdditionalServices()
        {
            Console.WriteLine("My additional Services with Delegates...");
        }

        public delegate dynamic MyDelegate(dynamic obj);


        public void DoSpecificSomething(int n, MyDelegate callback)
        {
            //TODO: I have to....
            Console.WriteLine(callback);
        }

        public Func<int, int> SquareRoot;

        public Action<List<string>> SortAndPrintNames;
    }
}

