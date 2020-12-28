using System;

namespace PracticeWithALoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<12;i++ )
            {
                Console.WriteLine(i + 1);
                if (i==2)
                {
                    Console.WriteLine("Some additional thing...");
                }if (i==9)
                {
                    Console.WriteLine("Some other thing....");
                }
            }
        }
    }
}
