using System;

namespace UC3
{
    internal class UC3
    {
        static int main = 0;
        static void Main(string[] args)
        {
            const int van1 = 1, van2 = 2, van3 = 3, van4 = 4, van5 = 5, van6 = 6;
            for (int i = 0; i < 100; i++)
            {
                Random r = new Random();
                int ran = r.Next(1, 9);
                //Check Random Value With All Values
                switch (ran)
                {
                    case van1:
                    case van2:
                        //If Random Value Is 1,2
                        Console.WriteLine("Dice:" + ran);
                        Console.WriteLine("Move AHead By " + ran);
                        main += ran;
                        Console.WriteLine("You're At:" + main);
                        Console.WriteLine("------------------------------");
                        break;

                    case van3:
                    case van4:
                    case van5:
                    case van6:
                        //If Random Value Is 3,4,5,6 For Ladder
                        Console.WriteLine("Dice:"+ ran);
                        Console.WriteLine("Climbed Ladder By " + ran);
                        main += ran;
                        Console.WriteLine("You're At " + main);
                        Console.WriteLine("------------------------------");
                        break;

                    default:
                        //If Random Value Is 7,8 For Snake 
                        Console.WriteLine("Dice:" + ran);
                        Console.WriteLine("Snakes Eats By " + ran);
                        main -= ran;
                        Console.WriteLine("You're At " + main);
                        Console.WriteLine("------------------------------");
                        break;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("You're At " + main);
        }
    }
}
