using System;

namespace SL6
{
    internal class SL6
    {
        static int position = 0;
        static void Main(string[] args)
        {
            int currentpos = 0, startpos = 0, diecnt = 0;
            const int Won = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random random = new Random();
            while (position < Won)
            {
                diecnt++;
                int ran = random.Next(1, 7);
                int opt = random.Next(0, 3);
                switch (opt)
                {
                    case NoPlay:
                        Console.WriteLine("You Got No Play");
                        Console.WriteLine("--------------------------");
                        break;

                    case Ladder:
                        position = currentpos;
                        if (position < Won)
                        {
                            currentpos += ran;
                            Console.WriteLine("Player Climbed Ladder By:" + ran);
                            if (currentpos > Won)
                            {
                                currentpos = position;
                            }
                        }
                        int r = random.Next(1, 7);
                        Console.WriteLine("You're At:" + currentpos);
                        Console.WriteLine("--------------------------");
                        break;

                    case Snake:
                        if (currentpos > 0)
                        {
                            Console.WriteLine("Player Is Bitten By Snake By:" + ran);
                            currentpos -= ran;
                        }
                        else if (currentpos <= 0)
                        {
                            currentpos = startpos;
                            currentpos = position;
                        }
                        Console.WriteLine("You're At:" + currentpos);
                        Console.WriteLine("--------------------------");
                        break;

                    default:
                        Console.WriteLine("You're At:" + position);
                        break;
                }
            }
            Console.WriteLine("Die Was Rolled For "+ diecnt +" Times");
            Console.WriteLine("You're Final Position Is:" + position);
        }
    }
}
