using System;
using System.Threading;

namespace JARVIS
{
    class Commands
    {
        public static void DoingStuff()
        {
            Console.Title = "J.A.R.V.I.S."; //JARVIS running
            Console.Write("{0}@HackBookPro: ", (Values.username));
            (Values.answer) = Convert.ToString(Console.ReadLine());
            if ((Values.answer) == (Values.masterPassword))
            {
                (Values.login) = true;
            }
            if ((Values.answer) == (Values.help) || (Values.answer) == (Values.help2))                //help
            {
                Console.WriteLine(Values.helpText);
                DoingStuff();
            }
            else if ((Values.answer) == (Values.logout) || (Values.answer) == (Values.logout2))            //logout
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
            else if ((Values.answer) == (Values.exit) || (Values.answer) == (Values.exit2))                  //exit
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
            else if ((Values.answer) == (Values.poem) || (Values.answer) == (Values.poem2))                  //poem
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
                DoingStuff();
            }
            else if ((Values.answer) == (Values.music) || (Values.answer) == (Values.music2))                //music
            {
                Console.Clear();
                Music.Play();
                DoingStuff();
            }
            else if ((Values.answer) == (Values.joke) || (Values.answer) == (Values.joke1))                  //joke
            {
                Jokes.Fishfingers();
            }
            if ((Values.login) == true)
            {
                Admin.SuperUser();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Unknow command");
                Console.WriteLine("Try typing 'help' for a list of commands");
                Console.WriteLine();
                DoingStuff();
            }
        }

    }
}