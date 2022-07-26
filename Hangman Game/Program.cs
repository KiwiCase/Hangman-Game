﻿
namespace HangmanGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = new string[10] { "trello", "reverse", "number", "google", "guessing", "keyboard", "github", "data", "floating", "debugger" };

            Console.WriteLine("The Hangman Game");

            Random rnd = new Random();
            int rndIndex = rnd.Next();
            string chosenWord = wordList[new Random.(0, wordList.Length)];
            int lives = 5;
            string response;
            char playAgain = 'Y';
            List<string> letters = new List<string>();

            while (playAgain == 'Y')
            {
                while (lives > 0)
                {
                    int lettersLeft = 0;
                    foreach (char character in chosenWord)
                    {
                        var letter = character.ToString();

                        if (letters.Contains(letter))
                        {
                            Console.Write(letter + " ");
                        }
                        else
                        {
                            Console.Write("_ ");

                            lettersLeft++;
                        }
                    }

                    if (lettersLeft > 0)
                    {
                        Console.WriteLine($"\nThere {(lettersLeft == 1 ? "is" : "are")} {lettersLeft} {(lettersLeft == 1 ? "letter" : "letters")} remaining in this word.");
                        Console.WriteLine("Please type a letter: ");

                        string givenLetter = Console.ReadKey().KeyChar.ToString().ToLower();
                        Console.WriteLine("");

                        if (letters.Contains(givenLetter))
                        {
                            Console.WriteLine("You've already entered this letter - please enter a different letter.");
                            continue;
                        }

                        letters.Add(givenLetter);

                        if (!chosenWord.Contains(givenLetter))
                        {
                            lives--;

                            if (lives > 0)
                            {
                                Console.WriteLine($"The letter '{givenLetter}' is not in the word. You have {lives} {(lives == 1 ? "try" : "tries")} left.");
                            }

                            else
                            {
                                Console.WriteLine($"Incorrect - You lost! The word was '{chosenWord}'.");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\nCorrect! You won with {lives} {(lives == 1 ? "life" : "lives")} left!");
                        break;
                    }
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Press Y to play again or N to quit.");
                response = Console.ReadKey().KeyChar.ToString().ToUpper();

                if (response == "Y")
                {
                    chosenWord = wordList[new Random().Next(0, wordList.Length - 1)];
                    lives = 5;
                    Console.WriteLine("\nHere is your new word:");
                    letters = new List<string>();
                }
                else
                {
                    Console.Write("\nOK then! Get outta here!");
                    break;
                }
            }
        }

    }
}

