using System;

namespace SL6
{
    internal class SL6
    {
        static int position = 0,i=0;
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
                        i++;
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
                        i++;
                        break;

                    default:
                        //If Random Value Is 7,8 For Snake 
                        Console.WriteLine("Dice:" + ran);
                        Console.WriteLine("Snakes Eats By " + ran);
                        position -= ran;
                        Console.WriteLine("You're At " + position);
                        Console.WriteLine("------------------------------");
                        i++;
                        break;
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
            if (position <= 100)
            {
                //If Value is 100
                Console.WriteLine("Dice Value Is:" + position);
                Console.WriteLine("Dice Was Rolled "+ i + "th Times");
            }
            else
            {
                //If Value is Greater Than 100
                Console.WriteLine("Dice Value Exceeds:" + position);
                Console.WriteLine("Dice Was Rolled " + i + "th Times");
            }

        }
    }
}
