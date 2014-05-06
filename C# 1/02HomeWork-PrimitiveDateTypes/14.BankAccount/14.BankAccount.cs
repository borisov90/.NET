using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mincho";
            string middleName = "Vremeto";
            string lastName = "Praznikov";
            double balance = 2000000;
            string bankName = "Bank of Evil (Former Lehman Brothers)";
            string iban = "BGSOF123219883";
            string bic = "BUIBGSF";
            double creditCard1 = 123123112;
            double creditCard2 = 123111111;
            double creditCard3 = 100000000;


            Console.WriteLine("============================================================");
            Console.WriteLine("Account Holder: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Available balance: {0}", balance);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|Account information| ");
            Console.WriteLine("Operating Bank: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("BIC code:{0}", bic);
            Console.WriteLine("Credit card 1 number:{0}",creditCard1);
            Console.WriteLine("Credit card 2 number:{0}",creditCard2);
            Console.WriteLine("Credit card 3 number:{0}",creditCard3);
            Console.WriteLine("============================================================");

        }
    }
}
