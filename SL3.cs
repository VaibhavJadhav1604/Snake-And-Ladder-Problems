using System;

namespace SL3
{
    internal class SL3
    {
        static int position = 0;
        static void Main(string[] args)
        {
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
                Random r = new Random();
                int die = r.Next(1, 7);//Random Number Between 1 to 6 Including 6
                int opt = r.Next(1, 3);//Random Number Between 1 to 2 Including 2
                switch (opt)
                {
                    case NoPlay:
                        //If Random Number Is 0
                        Console.WriteLine("You're At:" + position);
                        break;

                    case Ladder:
                        //If Random Number Is 1
                        position += die;
                        Console.WriteLine("You're At:" + position);
                        break;

                    case Snake:
                        //If Random Number Is 2
                        position -= die;
                        if(position < 0)
                        {
                            position = 0;
                        }
                        Console.WriteLine("You're At:" + position);
                        break;
                }
        }
    }
}
