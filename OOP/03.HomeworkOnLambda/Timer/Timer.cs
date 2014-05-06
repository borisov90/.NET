namespace Timer
{
    using System;
    using System.Reflection;
    using System.IO;
    using System.Resources;
    using System.Media;
    using System.Diagnostics;

    public delegate void Timer(int seconds);

    public class LoopInInterval
    {
        static void Main()
        {
            Timer t = new Timer(SayHi);
            t(1);

            Assembly assembly;
            assembly = Assembly.GetExecutingAssembly();

            SoundPlayer My_JukeBox = new SoundPlayer(@"Timer.Music.wav"); // Thrift shop  - 20 seconds wav
            My_JukeBox.Play();
            // това щеше да ми е много забавно но нещо не се подкарва без Windows Forms
        }
        public static void SayHi(int seconds)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            
            while (true)
            {
                
                if (watch.Elapsed.TotalSeconds % seconds == 0)
                {
                    Console.WriteLine(("What what? "), watch.Elapsed.TotalSeconds);
                }
                if (watch.Elapsed.TotalSeconds == 20)
                {
                    break;
                }
            }
        }
    }
}
