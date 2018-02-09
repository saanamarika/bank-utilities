using System;

namespace Pank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(BankUtilSS.CorrectNumber("4108265-11736"));

            Console.WriteLine(BankUtilSS.CorrectNumber("74108265-11736"));
            Console.WriteLine(BankUtilSS.IsValidAccount("41082650011736"));

            Console.ReadKey();

        }
    }
}
