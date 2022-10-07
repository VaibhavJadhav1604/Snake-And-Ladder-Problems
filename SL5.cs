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
            //Repeat Till Exact 100 Position Occurs
            while (position < Won)
            {
                int ran = r.Next(1, 7);
                int opt = r.Next(0, 3);
                switch (opt)
                {
                    case NoPlay:
                        //If Random Number Is 0
                        Console.WriteLine("You Got No Play");
                        Console.WriteLine("--------------------------");
                        break;

                    case Ladder:
                        //If Random Number Is 1
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
                        //If Random Number Is 2
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
