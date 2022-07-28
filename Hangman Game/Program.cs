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
            wordList[8] = "floating point";
            wordList[9] = "debugger";
            string chosenWord = wordList[new Random().Next(0, wordList.Length - 1)];
            int lives = 5;
            int lettersLeft = 0;
            var letters = new List<string>();

            while (lives != 0)
            {

                foreach (var character in chosenWord)
                {
                    var letter = character.ToString();

                    if (letters.Contains(letter))
                    {
                        Console.Write(letter);
                    }
                    else
                    {
 
                        Console.Write("_ ");

                        lettersLeft++;
                    }
                }
                Console.WriteLine(string.Empty);

                if (lettersLeft > 0)
                {           

                Console.Write("Type in a letter: ");

                string key = Console.ReadKey().Key.ToString().ToLower();
                Console.WriteLine(string.Empty);

                if (letters.Contains(key))
                {
                    Console.WriteLine("You already entered this letter!");
                    continue;
                }

                letters.Add(key);

                if (!chosenWord.Contains(key))
                {
                    lives--;

                    if (lives > 0)
                    {
                        Console.WriteLine($"The letter '{key}' is not in the word. You have {lives} {(lives == 1 ? "try" : "tries")} left.");
                    }
                }
            }
            }

            if (lives > 0)
            {
                Console.WriteLine($"You won with {lives} {(lives == 1 ? "life" : "lives")} left!");
            }
            else
            {
                Console.WriteLine($"You lost! The word was {chosenWord}.");
            }
        }
    }
}