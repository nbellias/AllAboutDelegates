using MyClassLibrary;

namespace ActionDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Action delegates...");

            MyServices myServices = new();

            Action<string> a = myServices.SendEmail;
            a += myServices.SendSms;
            // With lambda expression as an anonymous method
            a += (str) => Console.WriteLine($"A lambda expression void processing with message: {str}...");
            a("Hello World!");

            Action b = myServices.ExecuteProcessOne;
            b += myServices.ExecuteProcessTwo;
            b += myServices.ExecuteProcessThree;
            // With lambda expression as an anonymous method
            b += () => Console.WriteLine("Another void lambda expression processing...");
            b();
        }
    }
}