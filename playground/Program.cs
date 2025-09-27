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
            int hearts = 5;

            List<char> randomWordGen = secretWord.RandomWord().ToList();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Hearts: " + hearts);
                Console.WriteLine();
                Console.Write("Guess the Letter: ");

                char guesseLetter = Console.ReadLine().ToLower().TrimStart()[0];
                bool win = underlie.PrintUnderlines(randomWordGen, guesseLetter);
                if (win)
                    break;
                if (!randomWordGen.Contains(guesseLetter))
                {
                    hearts--;
                    if (hearts == 0)
                    {
                        Console.WriteLine("You Lost! Try again!");
                        break ;
                    }    
                }
            }
        }
    }  
}

