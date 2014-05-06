using System;

class Program
{
    static void Main(string[] args)
    {
        int rounds = int.Parse(Console.ReadLine());
        int mitkoscore;
        int vladkoscore;
        int charcounter = 0;
        
        for (int i = 0; i <= rounds; i++)
        {
            charcounter = 0;
            while (true)
            {
                
                int ch = Console.Read();
                
                
                if (ch == -1 || ch == '\n' || ch == '\r')
                {
                    break;
                }
                if (ch >= '1' && ch <= '9')
                {
                    char nextchar = (char)ch;
                    int digit = ch - '0';

                    charcounter++;
                    
                }
                if (charcounter % 2 == 0)
                {
                    if (i <= charcounter / 2)
                    {
                        vladkoscore += digit;
                        return;
                    }
                    if (i > charcounter / 2 )
                    {
                        mitkoscore += digit;
                    }
                }
               
            }
            
        }
    }
}

