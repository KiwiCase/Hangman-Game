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

            wordList[0] = "Trello";
            wordList[1] = "Reverse";
            wordList[2] = "Number";
            wordList[3] = "Google";
            wordList[4] = "Guessing";
            wordList[5] = "Keyboard";
            wordList[6] = "Github";
            wordList[7] = "Data Types";
            wordList[8] = "Floating Point";
            wordList[9] = "Debugger";
            string chosenWord = wordList[new Random().Next(0, wordList.Length - 1)];
            int lives = 5;
            var letters = new List<string>();

            while (lives != 0)
            {
                int lettersLeft = 0;
                foreach (string character in chosenWord)
                {
                    string letter = character.ToString();
                    if (letters.Contains(letter))
                    {
                        Console.WriteLine(letter);
                    }
                    else
                    {
                        Console.WriteLine("_");
                        lettersLeft++;
                    }
                }
            }
        }
    }
}