using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARVIS
{
    class Music
    {
        public static void Play()
        {
            Random titelName = new Random();
            int somethingSomethingTitelName = titelName.Next(1, 7);

            

            Console.ForegroundColor = ConsoleColor.Green;
            while (somethingSomethingTitelName != 0)
            {
                if (somethingSomethingTitelName == 1)
                {
                    Console.Title = Values.titel1;
                    somethingSomethingTitelName = 0;
                }
                else if (somethingSomethingTitelName == 2)
                {
                    Console.Title = Values.titel2;
                    somethingSomethingTitelName = 0;
                }
                else if (somethingSomethingTitelName == 3)
                {
                    Console.Title = Values.titel3;
                    somethingSomethingTitelName = 0;
                }
                else if (somethingSomethingTitelName == 4)
                {
                    Console.Title = Values.titel4;
                    somethingSomethingTitelName = 0;
                }
                else if (somethingSomethingTitelName == 5)
                {
                    Console.Title = Values.titel5;
                    somethingSomethingTitelName = 0;
                }
                else if (somethingSomethingTitelName == 6)
                {
                    Console.Title = Values.titel6;
                    somethingSomethingTitelName = 0;
                }
            }
            System.Threading.Thread.Sleep(1000);
        start:
            Console.WriteLine("To choose a song, please write the coresponding number");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n\t1. Mario theme");
            Console.WriteLine("\t2. Imperial March");
            Console.WriteLine("\t3. Tetris theme");
            Console.WriteLine("\t4. Random stuff");
            Console.WriteLine("\t5. TECNO");

            int Mario_theme = 1;
            int Imperial_March = 2;
            int Tetris = 3;
            int stuff = 4;
            int tecno = 5;
            int ninja = 0;

            Console.Write("\nPlease enter the number: ");
            int.TryParse(Console.ReadLine(), out ninja);

            if (ninja == Mario_theme)
            {
                Console.Clear();
                Console.WriteLine("\n\t NOW PLAYING the Mario theme");
                Console.Beep(659, 125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(523, 125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(375);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(375);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(330, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(494, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(466, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(880, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(587, 125);
                Console.Beep(494, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(330, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(494, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(466, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(440, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(392, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(880, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(587, 125);
                Console.Beep(494, 125);
                System.Threading.Thread.Sleep(375);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(625);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(587, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(1125);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(698, 125);
                Console.Beep(698, 125);
                Console.Beep(784, 125);
                Console.Beep(740, 125);
                Console.Beep(698, 125);
                System.Threading.Thread.Sleep(42);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(659, 125);
                System.Threading.Thread.Sleep(167);
                Console.Beep(415, 125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(125);
                Console.Beep(440, 125);
                Console.Beep(523, 125);
                Console.Beep(587, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(622, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(587, 125);
                System.Threading.Thread.Sleep(250);
                Console.Beep(523, 125);
                System.Threading.Thread.Sleep(625);
                Console.Clear();
                goto start;
            }
            else if (ninja == Imperial_March)
            {
                Console.Clear();
                Console.WriteLine("\n\t NOW PLAYING Imperial March");
                Console.Beep(440, 500); Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(349, 350); Console.Beep(523, 150);
                Console.Beep(440, 500); Console.Beep(349, 350);
                Console.Beep(523, 150); Console.Beep(440, 1000);
                Console.Beep(659, 500); Console.Beep(659, 500);
                Console.Beep(659, 500); Console.Beep(698, 350);
                Console.Beep(523, 150);
                Console.Beep(415, 500); Console.Beep(349, 350);
                Console.Beep(523, 150); Console.Beep(440, 1000);
                Console.Beep(880, 500); Console.Beep(440, 350);
                Console.Beep(440, 150); Console.Beep(880, 500);
                Console.Beep(830, 250);
                Console.Beep(784, 250);
                Console.Beep(740, 125); Console.Beep(698, 125);
                Console.Beep(740, 250);
                System.Threading.Thread.Sleep(250);
                Console.Beep(455, 250); Console.Beep(622, 500);
                Console.Beep(587, 250); Console.Beep(554, 250);
                Console.Beep(523, 125); Console.Beep(466, 125);
                Console.Beep(523, 250);
                System.Threading.Thread.Sleep(250);
                Console.Beep(349, 125); Console.Beep(415, 500);
                Console.Beep(349, 375); Console.Beep(440, 125);
                Console.Beep(523, 500); Console.Beep(440, 375);
                Console.Beep(523, 125); Console.Beep(659, 1000);
                Console.Beep(880, 500); Console.Beep(440, 350);
                Console.Beep(440, 150); Console.Beep(880, 500);
                Console.Beep(830, 250); Console.Beep(784, 250);
                Console.Beep(740, 125); Console.Beep(698, 125);
                Console.Beep(740, 250);
                System.Threading.Thread.Sleep(250);
                Console.Beep(455, 250); Console.Beep(622, 500);
                Console.Beep(587, 250); Console.Beep(554, 250);
                Console.Beep(523, 125); Console.Beep(466, 125);
                Console.Beep(523, 250);
                System.Threading.Thread.Sleep(250);
                Console.Beep(349, 250); Console.Beep(415, 500);
                Console.Beep(349, 375); Console.Beep(523, 125);
                Console.Beep(440, 500); Console.Beep(349, 375);
                Console.Beep(261, 125); Console.Beep(440, 1000);
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                goto start;
            }
            else if (ninja == Tetris)
            {
                Console.Clear();
                Console.WriteLine("\n\t NOW PLAYING Tetris theme");
                Console.Beep(658, 125);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                System.Threading.Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                System.Threading.Thread.Sleep(500);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                System.Threading.Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                System.Threading.Thread.Sleep(500);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
                Console.Clear();
                goto start;
            }
            else if (ninja == stuff)
            {
                Console.Clear();
                Console.WriteLine("\n\t NOW PLAYING something random");

                int C = 264;
                int D = 297;
                int E = 330;
                int F = 352;
                int G = 396;
                int A = 440;
                int Bb = 466;
                int B = 495;
                int C2 = 528;

                int note = 1000;
                int half = 1000 / 2;
                int quarter = 1000 / 4;
                int eighth = 1000 / 8;

                System.Threading.Thread.Sleep(2000);
                Console.Beep(C, quarter);
                Console.Beep(D, quarter);
                Console.Beep(E, quarter);
                Console.Beep(F, quarter);
                Console.Beep(G, quarter);
                Console.Beep(A, quarter);
                Console.Beep(B, quarter);
                Console.Beep(C2, half);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(C2, quarter);
                Console.Beep(B, quarter);
                Console.Beep(A, quarter);
                Console.Beep(G, quarter);
                Console.Beep(F, quarter);
                Console.Beep(E, quarter);
                Console.Beep(D, quarter);
                Console.Beep(C, half);
                System.Threading.Thread.Sleep(2000);
                Console.Beep(C, eighth);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(C, eighth);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(D, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(C, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(F, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(E, note);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(C, eighth);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(C, eighth);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(D, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(C, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(G, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(F, note);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(C, eighth);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(C, eighth);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(C2, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(A, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(F, quarter);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(F, eighth);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(E, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(D, note);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(Bb, eighth);
                System.Threading.Thread.Sleep(quarter);
                Console.Beep(Bb, eighth);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(A, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(F, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(G, half);
                System.Threading.Thread.Sleep(eighth);
                Console.Beep(F, note);
                Console.Clear();
                goto start;
            }
            else if (ninja == tecno)
            {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\tNOW PLAYING TECNO\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nTo close the program press ALT+F4");

                    Random randomSounds = new Random();
                    for (int index = 0; index < 100; index++)
                    {
                        Console.Beep(randomSounds.Next(1000) + 100, 100);
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry Dave, but I can't allow you to do that");
            }
            Console.ReadLine();
        }
    }
}
