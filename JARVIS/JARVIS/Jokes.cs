using System;

namespace JARVIS
{
    class Jokes
    {
        public static void Fishfingers()
        {
            Random randomJoke = new Random();
            (Values.randomJokeInt) = randomJoke.Next(1, 8);

            while ((Values.randomJokeInt) != 0)
            {
                if ((Values.randomJokeInt) == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(Values.Joke1);
                    Console.WriteLine();
                    (Values.randomJokeInt) = 0;
                }
                else if ((Values.randomJokeInt) == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine(Values.Joke2);
                    Console.WriteLine();
                    (Values.randomJokeInt) = 0;
                }
                else if ((Values.randomJokeInt) == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine(Values.Joke3);
                    Console.WriteLine();
                    (Values.randomJokeInt) = 0;
                }
                else if ((Values.randomJokeInt) == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine(Values.Joke4);
                    Console.WriteLine();
                    (Values.randomJokeInt) = 0;
                }
                else if ((Values.randomJokeInt) == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine(Values.Joke5);
                    Console.WriteLine();
                    (Values.randomJokeInt) = 0;
                }
                else if ((Values.randomJokeInt) == 6)
                {
                    Console.WriteLine();
                    Console.WriteLine(Values.Joke6);
                    Console.WriteLine();
                    (Values.randomJokeInt) = 0;
                }
                else if ((Values.randomJokeInt) == 7)
                {
                    Console.WriteLine();
                    Console.WriteLine(Values.Joke7);
                    Console.WriteLine();
                    (Values.randomJokeInt) = 0;
                }
            }
            Commands.DoingStuff();
        }
    }
}