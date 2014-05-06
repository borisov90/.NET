
namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Acount[] bankAcounts = { new Deposit(new IndividualCustomer("Nikoleri Bohinov", "0885 10 20 30", "0123456987"),8970.20, 0.36),
                                   new Loan(new CompanyCustomer("Berbalicious OOD", "987465126", "Mitko Ivanov"), 20000, 0.2),
                                   new Mortgage(new IndividualCustomer("Petar Petrov", "54169841", "9874563258"), 1534.35, 0.4)};

            Console.WriteLine("All Acounts:\n");
            PrintAcounts(bankAcounts);

            Console.WriteLine("\nAcounts after 500 deposit:\n");
            foreach (IDeposit acount in bankAcounts)
            {
                acount.Deposit(500);
            }

            PrintAcounts(bankAcounts);

            Console.Write("\nEnter number of months for interest: ");
            int months = int.Parse(Console.ReadLine());

            foreach (IInterest acount in bankAcounts)
            {
                Console.WriteLine("The {0} has interest: {1}", acount.GetType().Name, acount.CalculateInterestAmount(months));
            }
        }

        static void PrintAcounts(Acount[] acounts)
        {
            foreach (IPrintable acount in acounts)
            {
                acount.PrintInfo();
            }
        }
    }
}