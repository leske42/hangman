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

            Console.WriteLine("Guess the Word:");
            Console.WriteLine("Your Hearts: " + hearts);

            char guesseLetter = Console.ReadLine().ToLower().TrimStart()[0];
            if (randomWordGen.Contains(guesseLetter))
                hearts--;
            Console.WriteLine("Your Hearts: " + hearts);

        }
    }  
}

