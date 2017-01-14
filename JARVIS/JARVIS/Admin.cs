using System;
using System.Threading;

namespace JARVIS
{
    class Admin
    {
        public static void SuperUser()
        {
        JARVIS1:
            Console.Write("{0}@HackBookPro~$: ", (Values.username));

            (Values.answer1) = Convert.ToString(Console.ReadLine());

            if ((Values.help1) == (Values.answer1) || (Values.help2) == (Values.answer1)) //Help
            {
                Console.WriteLine(Values.helpText);
                goto JARVIS1;
            }
            if ((Values.logout1) == (Values.answer1) || (Values.logout2) == (Values.answer1)) //Logout
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tLogging out in");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tLogging out in");
                Console.WriteLine("\n\t\t\t\t\t3");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tLogging out in");
                Console.WriteLine("\n\t\t\t\t\t2");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\tLogging out in");
                Console.WriteLine("\n\t\t\t\t\t1");
                Thread.Sleep(500);
                Program.Login();
            }
            if ((Values.answer1) == (Values.poem1) || (Values.answer1) == (Values.poem2)) //Poem
            {
                Console.Clear();
                Console.WriteLine("Finding a poem...");
                Thread.Sleep(400);
                Console.WriteLine();
                Console.WriteLine("please wait...");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}\n{12}\n{13}\n{14}\n{15}\n{16}\n{17}\n{18}\n{19}\n{20}\n\n\n",
                    Values.TellPoem1, Values.TellPoem2, Values.TellPoem3,
                    Values.TellPoem4, Values.TellPoem5, Values.TellPoem6,
                    Values.TellPoem7, Values.TellPoem8, Values.TellPoem9,
                    Values.TellPoem10, Values.TellPoem11, Values.TellPoem12,
                    Values.TellPoem13, Values.TellPoem14, Values.TellPoem15,
                    Values.TellPoem16, Values.TellPoem17, Values.TellPoem18,
                    Values.TellPoem19, Values.TellPoem20, Values.TellPoem21);
                goto JARVIS1;
            }
            if ((Values.answer1) == (Values.music1) || (Values.answer1) == (Values.music2)) //Music
            {
                Console.Clear();
                Music.Play();
                goto JARVIS1;
            }
            if ((Values.answer1) == (Values.exit1) || (Values.answer1) == (Values.exit2)) //Exit
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