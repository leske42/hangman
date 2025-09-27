using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace playground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            secretWord secretWord = new secretWord();
            Underline underlie = new Underline();

            List<char> randomWordGen = secretWord.RandomWord().ToList();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Hearts: " + underlie.hearts);
                Console.WriteLine();
                Console.Write("Guess the Letter: ");

                char guesseLetter = Console.ReadLine().ToLower().TrimStart()[0];
                bool win = underlie.PrintUnderlines(randomWordGen, guesseLetter);
                if (win)
                {
                    Console.WriteLine();
                    Console.WriteLine("You Won! Congrats!");
                    break;
                }
                if (!randomWordGen.Contains(guesseLetter))
                {
                    if (underlie.hearts == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Lost! Try again!");
                        break;
                    }
                }
            }
        }
    }  
}

