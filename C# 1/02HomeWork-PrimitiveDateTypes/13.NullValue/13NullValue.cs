using System;

class Program
{
    static void Main()

    {

        int? numValue = null;
        Console.WriteLine("The nullable value is set to 0 here: {0}", numValue);
        numValue = 5;
        Console.WriteLine("The nullable value is set to 5 here: {0}", numValue);

        double? value = null;
        Console.WriteLine("The nullable value of the double int is 0: {0}", value);
        value = 5;
        Console.WriteLine("The nullable value of the double int set to 5 is: {0}", value);
        
    }
}

