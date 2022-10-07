using System;

namespace UC2
{
    internal class UC2
    {
        static void Main(string[] args)
        {
            int ran=0;
            Random r = new Random();
            ran = r.Next(1,7);
            //Get Value Between 1 To 6 Using Random
            Console.WriteLine("You Got:"+ ran);
        }
    }
}
