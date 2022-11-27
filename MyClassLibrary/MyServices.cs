namespace MyClassLibrary
{
    public class MyServices
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending email with message: {message}");
        }

        public void SendSms(string message)
        {
            Console.WriteLine($"Sending SMS with message: {message}");
        }

        public void ExecuteProcessOne()
        {
            Console.WriteLine("Process ONE execution...");
        }

        public void ExecuteProcessTwo()
        {
            Console.WriteLine("Process TWO execution...");
        }

        public void ExecuteProcessThree()
        {
            Console.WriteLine("Process THREE execution...");
        }

        public int AddTwoIntegers(int x, int y)
        {
            return x + y;
        }

        public int SubtractTwoIntegers(int x, int y)
        {
            return x - y;
        }

        public int MultiplyTwoIntegers(int x, int y)
        {
            return x * y;
        }

        public int RollTheDice()
        {
            return new Random().Next(1,6);
        }

        public bool DividesByThree(int x)
        {
            return x % 3 == 0;
        }
    }
}