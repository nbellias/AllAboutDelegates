namespace ComparisonWithInterfaces
{
    internal class Program
    {
        static List<string> myList = new List<string>() { "Nikos", "Margarita", "Spyros", "Iris", "Sofia" };

        static void Main(string[] args)
        {
            Console.WriteLine("Compare delegates with interfaces...");

            Console.WriteLine("---Interfaces---");
            MyLocalServices mySvc = new();
            mySvc.StartWithSomething();
            Console.WriteLine($"Second is {mySvc.DoSomethingSecondly()}");
            Console.WriteLine($"The list is sorted: {String.Join(',', mySvc.SortMyStrings(myList))}");
            Console.WriteLine();

            Console.WriteLine("---Delegates---");
            MyAdditionalServices myAddSvc = new();
            myAddSvc.DoSpecificSomething(3, (ο) => new { oid = 3 });

            //Dynamically extending sortAndPrintNames
            myAddSvc.SortAndPrintNames = (lst) =>
            {
                lst.Sort();
                Console.WriteLine(String.Join(',', lst));
            };
            myAddSvc.SortAndPrintNames(myList);
        }
    }
}