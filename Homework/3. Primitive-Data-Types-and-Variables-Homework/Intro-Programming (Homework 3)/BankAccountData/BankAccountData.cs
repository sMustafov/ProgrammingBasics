using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Sevgin";
            string middleName = "Orhanov";
            string lastName = "Mustafov";
            decimal moneyBalance = 666.25m;
            string bankName = "DSK Bank";
            string IBAN = "BG0000888888UP54454545";
            long firstCard = 5646489854656;
            long secondCard = 4564877898987;
            long thirdCard = 4545478748988;
            Console.WriteLine("Account holder : {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Account balance : {0} BGN", moneyBalance);
            Console.WriteLine("Bank : {0}", bankName);
            Console.WriteLine("IBAN : {0}", IBAN);
            Console.WriteLine("Credit Cards numbers : \n1. {0}\n2. {1}\n3. {2}", firstCard, secondCard, thirdCard);
            Console.ReadKey();
        }
    }
}
