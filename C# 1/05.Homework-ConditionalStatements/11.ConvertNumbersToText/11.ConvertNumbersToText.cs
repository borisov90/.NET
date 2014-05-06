using System;

class ConvertNumbersToText
{

    static void Main()
    {
        Console.Title = "Convert numbers (ranging from 0 to 999) to text";
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        var Tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        var Units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", };
        var Teens = new[] { "ten","eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", };
        var UnitNumber = new[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        var Hundreds = new[] {0, 100, 200, 300, 400, 500, 600, 700, 800, 900};
        var HundredWords = new[]{"one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred", "one thousand" };
        var ZeroToTwenty = new[]{"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten","eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};


        if (number < 0 || number > 999)
        {
            Console.WriteLine("The number you have entered is incorect. It should be in the region 0 to 999");
        }
        else if (number < 10 && number > -1)
        {
            Console.WriteLine(Units[number]);
        }
        else if (number >= 10 && number < 20)
        {
            Console.WriteLine(Teens[number - 10]);
        }
        else if (number > 19 && number < 100 )
        {
            Console.WriteLine("{0} {1}",Tens[number / 10], Units[number - UnitNumber[number / 10]]);
        }
        else if (number > 99 && number < 120 || number > 199 && number < 229 || number > 299 && number < 320 || number > 399 && number < 420 || number > 499 && number < 520 || number > 599 && number < 620 || number > 699 && number < 720 || number > 799 && number < 820 || number > 899 && number < 920)
        {
            Console.WriteLine(HundredWords[(number / 100) - 1] + " and " + ZeroToTwenty[(number - (Hundreds[number / 100]))]);
        }
        else if (number > 99 && number < 1000)
        {
            Console.WriteLine(HundredWords[(number / 100) - 1] + " " + Tens[(number - (Hundreds[number / 100])) / 10] + " " + Units[(((number - (Hundreds[number / 100])) - UnitNumber[((number - (Hundreds[number / 100])) / 10)]))]);
        }  
    }
}
