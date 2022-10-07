using System;

namespace SL4
{
    internal class SL4
    {
        static int position = 0;
        static void Main(string[] args)
        {
            const int van1 = 1, van2 = 2, van3 = 3, van4 = 4, van5 = 5, van6 = 6;
            //Till The Value Reaches 100 Loop Will Execute Once Reached Then Loop Will Get Exited
            while (position <= 100)
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
                        position += ran;
                        Console.WriteLine("You're At:" + position);
                        Console.WriteLine("------------------------------");
                        break;

                    case van3:
                    case van4:
                    case van5:
                    case van6:
                        //If Random Value Is 3,4,5,6 For Ladder
                        Console.WriteLine("Dice:" + ran);
                        Console.WriteLine("Climbed Ladder By " + ran);
                        position += ran;
                        Console.WriteLine("You're At " + position);
                        Console.WriteLine("------------------------------");
                        break;

                    default:
                        //If Random Value Is 7,8 For Snake 
                        Console.WriteLine("Dice:" + ran);
                        Console.WriteLine("Snakes Eats By " + ran);
                        position -= ran;
                        Console.WriteLine("You're At " + position);
                        Console.WriteLine("------------------------------");
                        break;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("You're At " + position);
        }
    }
}
