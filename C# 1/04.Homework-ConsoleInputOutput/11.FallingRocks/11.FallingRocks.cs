using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Units
{
    public int x;
    public int y;
    public char name;
    public ConsoleColor color;
}
struct MovingUnit
{
    public int x;
    public int y;
    public string name;
    public ConsoleColor color;
}
class FallingRocks
{


    public static void MoveToPosition(int x, int y, char c, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
        Console.ForegroundColor = ConsoleColor.Magenta;
        
    }
    public static void ShowStringInPosition(int x, int y, string str, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(str);
    }


    static void Main(string[] args)
    {
        Random generator = new Random();
        List<Units> Rocklist = new List<Units>();
        int livesCount = 3;
        int score = 0;
        char[] symbolList = { '^', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        int speed = 0;

        MovingUnit Dwarf = new MovingUnit();
        Dwarf.x = Console.WindowWidth / 2;
        Dwarf.y = Console.WindowHeight;
        Dwarf.name = "(0)";
        Dwarf.color = ConsoleColor.Blue;


        while (true)
        {
            bool hitted = false;

            int spawnBuffChance = generator.Next(0, 100);
            if (spawnBuffChance < 10)
            {
                // Buff
                Units newBuff = new Units();
                newBuff.x = generator.Next(0, Console.WindowWidth - 2);
                newBuff.y = 5;
                newBuff.color = ConsoleColor.Red;
                newBuff.name = '¤'; 
                Rocklist.Add(newBuff);
            }
            else
            {
                // Rock
                Units newInitRock = new Units();
                newInitRock.x = generator.Next(0, Console.WindowWidth - 2);
                newInitRock.y = 5;
                newInitRock.color = ConsoleColor.Gray;
                newInitRock.name = symbolList[generator.Next(0, 9)]; 
                Rocklist.Add(newInitRock);
            } 
            List<Units> newList = new List<Units>();
            for (int i = 0; i < Rocklist.Count; i++)
            {
                Units oldRock = Rocklist[i];
                Units NewMovedRock = new Units();
                NewMovedRock.x = oldRock.x;
                NewMovedRock.y = oldRock.y + 1;
                NewMovedRock.color = oldRock.color;
                NewMovedRock.name = oldRock.name;

                // Buff Detection
                if (NewMovedRock.name == '¤' && NewMovedRock.x == Dwarf.x && NewMovedRock.y == Dwarf.y || (NewMovedRock.x == Dwarf.x + 1 && NewMovedRock.y == Dwarf.y) || (NewMovedRock.x == Dwarf.x + 2 && NewMovedRock.y == Dwarf.y))
                {
                    speed = speed - 50;
                    livesCount++;
                }

                // Collision Detection
                if (NewMovedRock.name != '¤' && NewMovedRock.x == Dwarf.x && NewMovedRock.y == Dwarf.y || (NewMovedRock.x == Dwarf.x + 1 && NewMovedRock.y == Dwarf.y) || (NewMovedRock.x == Dwarf.x + 2 && NewMovedRock.y == Dwarf.y))
                {
                    livesCount--;
                    hitted = true;
                    speed = 0;
                    if (livesCount == 0)
                    {

                        ShowStringInPosition(42, 2, "GAME OVER", ConsoleColor.Red);
                        ShowStringInPosition(33, 3, "Press [enter] to continue", ConsoleColor.Red);
                        Console.ReadLine();
                        livesCount = 3;
                    }
                }
                if (NewMovedRock.y < Console.WindowHeight)
                {
                    newList.Add(NewMovedRock);
                }
                else
                {
                    score++;
                }
            }
            Rocklist = newList;

            Console.Clear();

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (Dwarf.x - 1 > 0)
                    {
                        Dwarf.x = Dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (Dwarf.x + 1 < (Console.WindowWidth - 3))
                    {
                        Dwarf.x = Dwarf.x + 1;
                    }
                }
            }
            if (hitted)
            {
                ShowStringInPosition(Dwarf.x, Dwarf.y, "X", ConsoleColor.Red);
                Rocklist.Clear();
            }
            else
            {
                ShowStringInPosition(Dwarf.x, Dwarf.y, Dwarf.name, Dwarf.color);
            }

            // Draw Rocks
            foreach (Units rock in Rocklist)
            {
                MoveToPosition(rock.x, rock.y, rock.name, rock.color);
            }

            // Draw Score and lives
            for (int i = 0; i < Console.WindowWidth; i++) // Score Divider
            {
                ShowStringInPosition(i, 5, "=", ConsoleColor.Blue);
            }
            ShowStringInPosition(10, 2, "Lives: " + livesCount, ConsoleColor.Green);
            ShowStringInPosition(20, 2, "Score: " + score, ConsoleColor.Green);
            ShowStringInPosition(20, 3, "Speed: " + speed, ConsoleColor.Green);

            // Slow the game down
            if (speed < 170)
            {
                speed++;
            }
            Thread.Sleep(250 - speed);
        }
    }
}

