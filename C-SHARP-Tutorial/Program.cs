using System;

namespace C_SHARP_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName + ".");
            Console.WriteLine("He was " + characterAge + " years old.");
            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName + "...");
            Console.WriteLine("...but didn't like being " + characterAge + ".");

            Console.ReadLine();
        }
    }
}
