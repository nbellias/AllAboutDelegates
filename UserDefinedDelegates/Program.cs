// See https://aka.ms/new-console-template for more information
using System;
using MyClassLibrary;

class Program
{
    delegate int ARandomOperation();
    delegate int ACalculation(int x, int y);
    delegate void DoSendMessages(string message);
    delegate void DoAProcess();

    static void Main(string[] args)
    {
        Console.WriteLine("User defined delegates...");

        MyServices myServices = new();

        // Explicitly create the delegate
        var op1 = new ARandomOperation(myServices.RollTheDice);
        Console.WriteLine(op1());

        var op2 = new ACalculation(myServices.AddTwoIntegers);
        Console.WriteLine(op2(3,6));

        var op3 = new DoSendMessages(myServices.SendEmail);
        
        var op4 = new DoAProcess(myServices.ExecuteProcessOne);

        // Delegate is created automatically from method
        op1 = myServices.RollTheDice;
        Console.WriteLine(op1());

        op2 = myServices.SubtractTwoIntegers;
        Console.WriteLine(op2(17, 3));

        op2 = myServices.MultiplyTwoIntegers;
        Console.WriteLine(op2(6,3));

        op3 += myServices.SendSms;
        op3("Hello World!");

        op4 += myServices.ExecuteProcessTwo;
        op4 += myServices.ExecuteProcessThree;
        op4();
    }
}








