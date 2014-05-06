using System;

class MissCat
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] cats = new int[11];
        for (int i = 0; i < n; i++)
        {
            int catsnumber = int.Parse(Console.ReadLine());
            cats[catsnumber]++;
        }
        int max = 0;
        int result = 0;
        for (int i = 0; i < cats.Length; i++)
		{
			    
        int currentresult = cats[i];
             if (currentresult > max)
	            {
		                max = currentresult;
                        result = i;
	            }
	    }
        Console.WriteLine(result);
    }
}

