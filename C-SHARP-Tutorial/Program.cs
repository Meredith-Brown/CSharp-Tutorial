using System;

namespace C_SHARP_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckNumbers = {2,3,10,29};
            Console.WriteLine(luckNumbers[2]);
            Console.ReadLine();
            luckNumbers[2] = 9;
            Console.WriteLine(luckNumbers[2]);
            Console.ReadLine();
        }
    }
}

//STORY W/ VARIABLES:

//string characterName = "Tom";
//int characterAge;
//characterAge = 25;

//Console.WriteLine("There once was a man named " + characterName + ".");
//Console.WriteLine("He was " + characterAge + " years old.");
//characterName = "Mike";
//Console.WriteLine("He really liked the name " + characterName + "...");
//Console.WriteLine("...but didn't like being " + characterAge + ".");

//Console.ReadLine();

//==================================================

//DATA TYPES:

//string phrase = "Giraffe Academy";
//char grade = 'A';
//int age = 30;
//// float = least accurate
//double gpa = 3.3; // in the middle
//                  // decimal = most accurate
//bool isMale = false;

//Console.WriteLine(30); // 30 is a constant

//Console.ReadLine();

//==================================================

//STRING BASICS:

//string phrase = "Giraffe Academy";
//Console.WriteLine(phrase.Substring(8, 3));
//Console.ReadLine();

//==================================================

//NUMBER BASICS:

//Console.WriteLine(5 + 8);
//Console.WriteLine(5 - 8);
//Console.WriteLine(5 / 8);
//Console.WriteLine(5 * 8);
//Console.WriteLine(5 % 2);
//Console.WriteLine(4 + 2 * 3);
//Console.WriteLine((4 + 2) * 3);
//Console.WriteLine(5.0 + 8.1);
//Console.WriteLine(5 + 8.1);
//Console.WriteLine(5 / 2);
//Console.WriteLine(5 / 2.0);
//int num = 6;
//Console.WriteLine(num);
//num++;
//Console.WriteLine(num);
//Console.WriteLine(Math.Abs(-40));
//Console.WriteLine(Math.Pow(3, 2));
//Console.WriteLine(Math.Pow(3.8, 2));
//Console.WriteLine(Math.Sqrt(36));
//Console.WriteLine(Math.Max(4, 90));
//Console.WriteLine(Math.Min(4, 90));
//Console.WriteLine(Math.Round(4.3));
//Console.WriteLine(Math.Round(4.6));
//Console.ReadLine();

//==================================================

//GET USER INPUT:

//Console.Write("Enter your name: ");
//string name = Console.ReadLine();
//Console.Write("Enter your age: ");
//string age = Console.ReadLine();
//Console.WriteLine("Hello " + name + ". You are " + age + " years old.");
//Console.ReadLine();

//==================================================

//ADDITION ONLY CALCULATOR:

//Console.Write("Enter a number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter another number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(num1 + num2);
//Console.ReadLine();

//==================================================

//MAD LIBS GAME:

//string color, pluralNoun, celebrity;

//Console.Write("Enter a color: ");
//color = Console.ReadLine();

//Console.Write("Enter a plural noun: ");
//pluralNoun = Console.ReadLine();

//Console.Write("Enter a celebrity: ");
//celebrity = Console.ReadLine();

//Console.WriteLine("Roses are " + color + ".");
//Console.WriteLine(pluralNoun + " are blue.");
//Console.WriteLine("I love " + celebrity + ".");

//Console.ReadLine();

//==================================================
