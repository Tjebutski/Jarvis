﻿using System;
using System.Threading;

namespace JARVIS
{
    class Music
    {
        public static void Play()
        {
            MusicTitle.Title();
            Thread.Sleep(1000);
        start:
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", Values.text1, Values.text2, Values.text3, Values.text4, Values.text5, Values.text6, Values.text7);

            string Mario_theme = "1";
            string Imperial_March = "2";
            string Tetris = "3";
            string stuff = "4";
            string tecno = "5";
            string ninja;
            string exit = "Exit";
            string exit1 = "exit";

            Console.Write("\nCommand: ");
            ninja = Console.ReadLine();
            if (ninja == exit || ninja == exit1)
            {
                Console.Clear();
                Commands.DoingStuff();
            }
            //int.TryParse(Console.ReadLine(), out ninja);
            else
            {
                if (ninja == Mario_theme)
                {
                    Console.Clear();
                    Console.WriteLine("\n\t NOW PLAYING the Mario theme");
                    Console.Beep(659, 125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(523, 125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(375);
                    Console.Beep(392, 125);
                    Thread.Sleep(375);
                    Console.Beep(523, 125);
                    Thread.Sleep(250);
                    Console.Beep(392, 125);
                    Thread.Sleep(250);
                    Console.Beep(330, 125);
                    Thread.Sleep(250);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(466, 125);
                    Thread.Sleep(42);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(392, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(880, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(587, 125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(250);
                    Console.Beep(392, 125);
                    Thread.Sleep(250);
                    Console.Beep(330, 125);
                    Thread.Sleep(250);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(494, 125);
                    Thread.Sleep(125);
                    Console.Beep(466, 125);
                    Thread.Sleep(42);
                    Console.Beep(440, 125);
                    Thread.Sleep(125);
                    Console.Beep(392, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(880, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(784, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(587, 125);
                    Console.Beep(494, 125);
                    Thread.Sleep(375);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(698, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(625);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(622, 125);
                    Thread.Sleep(250);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(523, 125);
                    Thread.Sleep(1125);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(698, 125);
                    Thread.Sleep(125);
                    Console.Beep(698, 125);
                    Console.Beep(698, 125);
                    Console.Beep(784, 125);
                    Console.Beep(740, 125);
                    Console.Beep(698, 125);
                    Thread.Sleep(42);
                    Console.Beep(622, 125);
                    Thread.Sleep(125);
                    Console.Beep(659, 125);
                    Thread.Sleep(167);
                    Console.Beep(415, 125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Thread.Sleep(125);
                    Console.Beep(440, 125);
                    Console.Beep(523, 125);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(622, 125);
                    Thread.Sleep(250);
                    Console.Beep(587, 125);
                    Thread.Sleep(250);
                    Console.Beep(523, 125);
                    Thread.Sleep(625);
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
                    Thread.Sleep(250);
                    Console.Beep(455, 250); Console.Beep(622, 500);
                    Console.Beep(587, 250); Console.Beep(554, 250);
                    Console.Beep(523, 125); Console.Beep(466, 125);
                    Console.Beep(523, 250);
                    Thread.Sleep(250);
                    Console.Beep(349, 125); Console.Beep(415, 500);
                    Console.Beep(349, 375); Console.Beep(440, 125);
                    Console.Beep(523, 500); Console.Beep(440, 375);
                    Console.Beep(523, 125); Console.Beep(659, 1000);
                    Console.Beep(880, 500); Console.Beep(440, 350);
                    Console.Beep(440, 150); Console.Beep(880, 500);
                    Console.Beep(830, 250); Console.Beep(784, 250);
                    Console.Beep(740, 125); Console.Beep(698, 125);
                    Console.Beep(740, 250);
                    Thread.Sleep(250);
                    Console.Beep(455, 250); Console.Beep(622, 500);
                    Console.Beep(587, 250); Console.Beep(554, 250);
                    Console.Beep(523, 125); Console.Beep(466, 125);
                    Console.Beep(523, 250);
                    Thread.Sleep(250);
                    Console.Beep(349, 250); Console.Beep(415, 500);
                    Console.Beep(349, 375); Console.Beep(523, 125);
                    Console.Beep(440, 500); Console.Beep(349, 375);
                    Console.Beep(261, 125); Console.Beep(440, 1000);
                    Thread.Sleep(100);
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
                    Thread.Sleep(250);
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
                    Thread.Sleep(500);
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
                    Thread.Sleep(250);
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
                    Thread.Sleep(500);
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

                    Thread.Sleep(2000);
                    Console.Beep(C, quarter);
                    Console.Beep(D, quarter);
                    Console.Beep(E, quarter);
                    Console.Beep(F, quarter);
                    Console.Beep(G, quarter);
                    Console.Beep(A, quarter);
                    Console.Beep(B, quarter);
                    Console.Beep(C2, half);
                    Thread.Sleep(quarter);
                    Console.Beep(C2, quarter);
                    Console.Beep(B, quarter);
                    Console.Beep(A, quarter);
                    Console.Beep(G, quarter);
                    Console.Beep(F, quarter);
                    Console.Beep(E, quarter);
                    Console.Beep(D, quarter);
                    Console.Beep(C, half);
                    Thread.Sleep(2000);
                    Console.Beep(C, eighth);
                    Thread.Sleep(quarter);
                    Console.Beep(C, eighth);
                    Thread.Sleep(eighth);
                    Console.Beep(D, half);
                    Thread.Sleep(eighth);
                    Console.Beep(C, half);
                    Thread.Sleep(eighth);
                    Console.Beep(F, half);
                    Thread.Sleep(eighth);
                    Console.Beep(E, note);
                    Thread.Sleep(quarter);
                    Console.Beep(C, eighth);
                    Thread.Sleep(quarter);
                    Console.Beep(C, eighth);
                    Thread.Sleep(eighth);
                    Console.Beep(D, half);
                    Thread.Sleep(eighth);
                    Console.Beep(C, half);
                    Thread.Sleep(eighth);
                    Console.Beep(G, half);
                    Thread.Sleep(eighth);
                    Console.Beep(F, note);
                    Thread.Sleep(quarter);
                    Console.Beep(C, eighth);
                    Thread.Sleep(quarter);
                    Console.Beep(C, eighth);
                    Thread.Sleep(eighth);
                    Console.Beep(C2, half);
                    Thread.Sleep(eighth);
                    Console.Beep(A, half);
                    Thread.Sleep(eighth);
                    Console.Beep(F, quarter);
                    Thread.Sleep(eighth);
                    Console.Beep(F, eighth);
                    Thread.Sleep(eighth);
                    Console.Beep(E, half);
                    Thread.Sleep(eighth);
                    Console.Beep(D, note);
                    Thread.Sleep(quarter);
                    Console.Beep(Bb, eighth);
                    Thread.Sleep(quarter);
                    Console.Beep(Bb, eighth);
                    Thread.Sleep(eighth);
                    Console.Beep(A, half);
                    Thread.Sleep(eighth);
                    Console.Beep(F, half);
                    Thread.Sleep(eighth);
                    Console.Beep(G, half);
                    Thread.Sleep(eighth);
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
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto start;
                }
            }
        }
    }
}