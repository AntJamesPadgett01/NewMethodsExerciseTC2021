using System;

namespace NewMethodsExerciseTC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. WHat is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! NOw, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}!   Here is your profile");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
        }
    }
}
