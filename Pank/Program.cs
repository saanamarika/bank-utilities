using System;

namespace Pank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
       ClassBBAN newAccount = new ClassBBAN("4108265-11736");
            Console.WriteLine(UtilityBBAN.CorrectNumber("4108265-11736"));

            Console.WriteLine(UtilityBBAN.CorrectNumber("74108265-11736"));
            Console.WriteLine(UtilityBBAN.IsValidAccount("41082650011736"));

            Console.ReadKey();

        }
    }
}
