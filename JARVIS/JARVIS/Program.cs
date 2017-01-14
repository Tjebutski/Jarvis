using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace JARVIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "";
            /*
            Thread.Sleep(1000); //Boot start
            Console.WriteLine("\n\tInitiating system check");
            Thread.Sleep(500);
            Console.WriteLine("\n\t. . .");
            Thread.Sleep(500);
            Console.WriteLine("\n\t. . .");
            Thread.Sleep(500);
            Console.WriteLine("\n\t. . .");
            Thread.Sleep(1000);
            Console.WriteLine("\n\tSystem check passed\n\n\tJ.A.R.V.I.S. is starting");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("Booting ... OK");
            Thread.Sleep(500);
            Console.WriteLine("Resuming at 0x9000 ... OK");
            Thread.Sleep(500);
            Console.WriteLine("Loading kernel ... OK");
            Thread.Sleep(500);
            Console.WriteLine("Installing clock ISR ... OK");
            Thread.Sleep(500);
            Console.WriteLine("Installing block curser ... OK");
            Thread.Sleep(500);
            Console.WriteLine("SDE loading ... OK");
            Thread.Sleep(1000);
            Console.WriteLine("\nSDE test Operating System\n(C) 2020 Amit Singh. All Rights Reserved.");
            Thread.Sleep(1000);
            Console.WriteLine("\nSDE# ?");
            Thread.Sleep(1000);
            Console.WriteLine("\nEnter N (0 < N <= 9) as number of disks.");
            Thread.Sleep(500);
            Console.WriteLine("SDE test Operating System");
            Thread.Sleep(500);
            Console.WriteLine("(C) 2018 Amit Singh. AllRights Reserved.");
            Thread.Sleep(1000);
            Console.WriteLine("\nNot a spy system# 2");
            Thread.Sleep(500);
            Console.WriteLine("move 1 --> 2");
            Thread.Sleep(500);
            Console.WriteLine("move 1 --> 3");
            Thread.Sleep(500);
            Console.WriteLine("move 2 --> 3");
            Thread.Sleep(500);
            Console.WriteLine("0003 moves total");
            Thread.Sleep(1000);
            Console.WriteLine("SDE# d-_-b");
            Thread.Sleep(3000);
            */
            Login();
        }
        public static void Login()
        {
        login:
            Console.Clear();
            while ((Values.password) != (Values.guess) || (Values.masterPasswordAlpha) != (Values.guess))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\n\t\t\t\tUsername: ");
                (Values.username) = Console.ReadLine();
                Console.Write("\n\t\t\t\tPassword: ");
                Console.ForegroundColor = ConsoleColor.Black;
                (Values.guess) = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if ((Values.guess) == (Values.password) && (Values.username) == (Values.username2))
                {
                    Console.Clear();
                    break;
                }
                else if ((Values.guess) == (Values.masterPasswordAlpha) && (Values.username) == (Values.username1))
                {
                    Console.Clear();
                    break;
                }
                else if ((Values.guess) == (Values.username1) && (Values.username) == (Values.username1)) //Cheking if admin/admin used
                {
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Write("\n\n\t\t\tDid you really think that would work?");
                    Thread.Sleep(1000);
                    Console.Write("\n\n\t\t\tYou really are stupid, did you know that?");
                    Thread.Sleep(7000);
                    Console.Clear();
                }
                else //Blinking screen if wrong answer
                {
                    Thread.Sleep(100);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Thread.Sleep(100);
                    Console.Beep(350, 200);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Beep(350, 200);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Beep(350, 200);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Beep(350, 200);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Beep(350, 200);
                    Thread.Sleep(100);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.Beep(350, 200);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
            Commands.DoingStuff();
            goto login;
            //Frederik har lavet ~10 linjer kode, så derfor tror han han er noget! (skide amatør)
            //Og jeg har lavet resten, så ER jeg noget!
        }
    }
}