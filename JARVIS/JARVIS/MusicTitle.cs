using System;

namespace JARVIS
{
    class MusicTitle
    {
        public static void Title()
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
            return;
        }
    }
}
