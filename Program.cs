using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace slash_r
{
    class Program
    {
        static void Main(string[] args)
        {
            Dots();
        }

        private static void TheFinalCountdown()
        {
            for (var i = 10; i > 0; i--)
            {
                Console.Write("{0} \r", i);
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void Countdown()
        {
            for (var i = 10; i > 0; i--)
            {
                Console.Write("{0}\n", i);
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void Dots()
        {
            Console.WriteLine("Press any key to exit");
            var count = 0;

            while (!Console.KeyAvailable)
            {
                switch (count)
                {
                    case 0:
                        Console.Write("\rWorking .  ");
                        count++;
                        break;

                    case 1:
                        Console.Write("\rWorking  . ");
                        count++;
                        break;

                    case 2:
                        Console.Write("\rWorking   .");
                        count = 0;
                        break;

                    default:
                        break;
                }

                System.Threading.Thread.Sleep(333);
            }
        }

        // Assist: http://stackoverflow.com/questions/888533/how-can-i-update-the-current-line-in-a-c-sharp-windows-console-app
        private static void SpinIt()
        {
            ConsoleSpinner spin = new ConsoleSpinner();
            Console.WriteLine("Press any key to exit");
            Console.Write("Working...");


            while (!Console.KeyAvailable)
            {
                spin.Turn();
                System.Threading.Thread.Sleep(333);
            }
        }

        private class ConsoleSpinner
        {
            int counter;

            public ConsoleSpinner()
            {
                counter = 0;
            }

            public void Turn()
            {
                counter++;
        
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }

                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
}
