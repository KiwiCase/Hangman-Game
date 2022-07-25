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
            Random randWord = new Random();
            int wordId = randWord.Next(0, 9);
            string word = wordList[wordId];
            char[] guess = new char[wordList.Length];
            Console.WriteLine("Please enter your guess: ");
        }
    }
}