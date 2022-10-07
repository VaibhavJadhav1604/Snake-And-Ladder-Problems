using System;
using System.Xml.Linq;

namespace SL7
{
    internal class SL7
    {
        int position = 0;
        int Dice()
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
                        if (position < Won)
                        {
                            currentpos += r;
                            Console.WriteLine("Player Climbed Ladder By:" + r);
                            if (currentpos > Won)
                            {
                                currentpos = position;
                            }
                        }
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
            Console.WriteLine("Die Was Rolled For " + diecnt + " Times");
            Console.WriteLine("You're Final Position Is:" + position);
            return diecnt;
        }
        static void Main(string[] args)
        {
            SL7 ob1 = new SL7();
            Console.WriteLine("##################################For Player 1##################################");
            int a=ob1.Dice();
             SL7 ob2=new SL7();
            Console.WriteLine("##################################For Player 2##################################");
            int b=ob2.Dice();
            if(b<a)
            {
                Console.WriteLine("Player 2 Has Won");
            }
            else
            {
                Console.WriteLine("Player 1 Has Won");
            }
        }
    }
}
