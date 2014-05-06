using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string adress = Console.ReadLine();
        Console.WriteLine("Enter company's phone number: ");
        double phone = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter company's fax number: ");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Enter company's website: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("Now enter manager's information");
        Console.WriteLine("First name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("enter manager's phone number");
        double managersPhone = double.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Company information:");

        Console.WriteLine("Name: {0}",companyName);
        Console.WriteLine("address: {0}", adress);
        Console.WriteLine("phone number: {0}", phone);
        Console.WriteLine("fax number: {0}", faxNumber);
        Console.WriteLine("website: {0}", webSite);

        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Company manager: {0} {1}, {2} years old. Phone number: {3}" ,firstName, lastName, age, managersPhone);



    }
}

