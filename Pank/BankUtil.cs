using System;
using System.Collections.Generic;
using System.Text;

namespace Pank
{
    class BankUtilSS
    {
        /// <summary>
        /// CorrectNumber poistaa tilinumerosta väliviivat ja lisää tarvittavan määrän nollia. Konekieliseen muotoon (Machineformat).
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns>machineformat account</returns>
        public static string CorrectNumber(string accountNumber)
        {      
            accountNumber = accountNumber.Replace("-", "").Replace(" ", "");

            int PositionOfZeros = 0;
            if (accountNumber[0] == '1' || accountNumber[0] == '2' || accountNumber[0] == '6' || accountNumber[0] == '8')
                PositionOfZeros = 6;
            else if (accountNumber[0] == '3')
            {
                if (accountNumber[1] == '0' || accountNumber[1] == '2' || accountNumber[1] == '5')
                    return "Väärä tilinumero!";
                else
                    PositionOfZeros = 6;
            }
            else if (accountNumber[0] == '4' || accountNumber[0] == '5')
                PositionOfZeros = 7;
            else
            {
                return "Väärä tilinumero!";
            }
            for (int i = accountNumber.Length; i < 14; i++)
            {
                accountNumber = accountNumber.Insert(PositionOfZeros, "0");
            }
            return accountNumber;
        }
        public static bool IsValidAccount(string machineFormatAccount)
        {
            int checkNumber = int.Parse(machineFormatAccount[machineFormatAccount.Length-1].ToString());
            machineFormatAccount = machineFormatAccount.Remove(machineFormatAccount.Length-1, 1);
            int[] multiplex = new int[2] { 2, 1 };
            int m = 0;
            for(int i = 0; i < machineFormatAccount.Length; i++)
            {
                int n = int.Parse(machineFormatAccount[machineFormatAccount.Length-1-i].ToString()) * multiplex[i % 2];
                if (n >= 10)
                    m += n / 10 + (n - 10);
                else
                    m += n;
            }
            int calculateCheck = ((m / 10 + 1) * 10)-m;
            return checkNumber == calculateCheck;




        }

    }
}
