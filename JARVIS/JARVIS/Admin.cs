using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace JARVIS
{
    class Admin
    {
        public static void SuperUser()
        {
        JARVIS1:
            Console.Write("{0}@HackBookPro~$: ", (Values.username));

            (Values.answer1) = Convert.ToString(Console.ReadLine());

            if ((Values.help1) == (Values.answer1) || (Values.help2) == (Values.answer1))
            {
                Console.WriteLine("\nList of implemented commands in super user mode");
                Console.WriteLine("Exit\t\tLogout\t\tFind a poem\t\tMusic\t\tTell a joke\n");
                goto JARVIS1;
            }
            if ((Values.logout1) == (Values.answer1) || (Values.logout2) == (Values.answer1))
            {
                return;
            }
            if ((Values.answer1) == (Values.poem1) || (Values.answer1) == (Values.poem2))
            {
                Console.Clear();
                Console.WriteLine("Finding a poem...");
                Thread.Sleep(400);
                Console.WriteLine();
                Console.WriteLine("please wait...");
                Process.Start(@"E:\OS poem.txt");
                Console.Clear();
                goto JARVIS1;
            }
            if ((Values.answer1) == (Values.music1) || (Values.answer1) == (Values.music2))
            {
                Console.WriteLine("started music command\nPlease come back later when it's been fully implemented");
                Console.WriteLine();
                Process.Start(@"E:\C#\Musik\Musik\program.cs");
                goto JARVIS1;
            }
            if ((Values.answer1) == (Values.exit1) || (Values.answer1) == (Values.exit2))
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tClosing J.A.R.V.I.S. in");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tClosing J.A.R.V.I.S. in");
                Console.WriteLine("\n\t\t\t\t\t3");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tClosing J.A.R.V.I.S. in");
                Console.WriteLine("\n\t\t\t\t\t2");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tClosing J.A.R.V.I.S. in");
                Console.WriteLine("\n\t\t\t\t\t1");
                Thread.Sleep(500);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect command, please check the spelling and try again!");
                Console.WriteLine("Try typing 'help' for more information");
                Console.WriteLine();
                goto JARVIS1;
            }
        }
    }
}