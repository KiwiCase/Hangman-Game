
namespace HangmanGame
{
    internal class Program
    {
        private static List<string> letters;

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
            wordList[7] = "data";
            wordList[8] = "floating";
            wordList[9] = "debugger";
            string chosenWord = wordList[new Random().Next(0, wordList.Length - 1)];
            int lives = 5;
            string response;
            letters = new List<string>();

            while (lives != 0)
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
                Console.WriteLine("");

                if (lettersLeft > 0)
                {
                    Console.WriteLine($"There {(lettersLeft == 1 ? "is" : "are")} {lettersLeft} {(lettersLeft == 1 ? "letter" : "letters")} remaining in this word.");
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

                        if (lives == 0)
                        {
                            Console.WriteLine($"Incorrect - You lost! The word was '{chosenWord}'.");
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
                if (lettersLeft == 0)
                {
                    Console.WriteLine($"Correct! You won with {lives} {(lives == 1 ? "life" : "lives")} left!");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Press Y to play again or N to quit.");
                    response = Console.ReadKey().KeyChar.ToString().ToUpper();

                    if (response == "Y")
                    {
                        chosenWord = wordList[new Random().Next(0, wordList.Length - 1)];
                        lives = 5;
                        Console.WriteLine("");
                        Console.WriteLine("Here is your new word:");
                        letters = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("OK then! Get outta here!");
                        break;
                    }

                }


            }

        }

    }
}

