using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = new string[10];

            Console.WriteLine("The Hangman Game");

            wordList[0] = "trello";
            wordList[1] = "reverse";
            wordList[2] = "number";
            wordList[3] = "google";
            wordList[4] = "guessing";
            wordList[5] = "keyboard";
            wordList[6] = "github";
            wordList[7] = "data types";
            wordList[8] = "floating Point";
            wordList[9] = "debugger";
            string chosenWord = wordList[new Random().Next(0, wordList.Length - 1)];
            int lives = 5;
            var letters = new List<string>();

            Console.WriteLine("Enter your 1-letter guess: ");
            string key = Console.ReadKey().Key.ToString().ToLower();
            Console.WriteLine(string.Empty);

            if (letters.Contains(key))
            {
                Console.WriteLine("You've already entered this letter - please enter a different letter: ");
            }

            letters.Add(key);

            if (!chosenWord.Contains(key))
            {
                lives--;

                if (lives > 0)
                {
                    Console.WriteLine($"'{key}' is not in the word. You have {lives} {(lives == 1 ? "try" : "tries")} remaining");
                }
            }

            if (lives > 0)
            {
                Console.WriteLine("You won! Congratulations!");
            }
            else
            {
                Console.WriteLine($"You lost! The word was {chosenWord}.");
            }



        }

    }
}
