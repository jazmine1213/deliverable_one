using System;

namespace PracticeWithConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSpaces = 12;
            int numStudents = 8;

            if (numberOfSpaces < numStudents)
            {
                Console.WriteLine("There is no more space!");
               
            } else if (numberOfSpaces>numStudents)
            {
                Console.WriteLine("Welcome to the class! More spots are available");
            }else if (numberOfSpaces==numStudents)
            {
                Console.WriteLine("Class is full. Try again next semester.");
            }


        }
    }
}
