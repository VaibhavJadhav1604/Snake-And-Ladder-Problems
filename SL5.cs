using System;

namespace SL5
{
    internal class SL5
    {
        static int position = 0;
        static void Main(string[] args)
        {
            int currentpos = 0, startpos = 0;
            const int Won = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random r = new Random();
            while (position < Won)
            {
                int ran = r.Next(1, 7);
                int opt = r.Next(0, 3);
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
                        break;
                }
            }
            Console.WriteLine("You're Final Position Is:" + position);
        }
    }
}
