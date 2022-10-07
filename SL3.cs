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
                int die = r.Next(1, 7);
                int opt = r.Next(1, 3);
                switch (opt)
                {
                    case NoPlay:
                        Console.WriteLine("You're At:" + position);
                        break;

                    case Ladder:
                        position += die;
                        Console.WriteLine("You're At:" + position);
                        break;

                    case Snake:
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
