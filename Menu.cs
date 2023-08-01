// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace MathsGame
{
    internal class Menu
    {
        GameEngine gamesClass = new();

        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(
                $"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n"
            );
            Console.WriteLine("Press any key to go to the Main Menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(
                    @$"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program"
                );
                Console.WriteLine("---------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gamesClass.AdditionGame("Addition selected");
                        break;
                    case "s":
                        gamesClass.SubtractionGame("Subtraction selected");
                        break;
                    case "m":
                        gamesClass.MultiplicationGame("Multiplication selected");
                        break;
                    case "d":
                        gamesClass.DivisionGame("Division selected");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}
