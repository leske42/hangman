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
            string wordHint = string.Empty;

            string randomWord = secretWord.RandomWord();
            List<char> randomWordGen = randomWord.ToList();

            switch (randomWord)
            {
                case "flower":
                    wordHint = "A plant that blooms";
                    break;
                case "summer":
                    wordHint = "The hottest season";
                    break;
                case "computer":
                    wordHint = "Binary brain";
                    break;
                case "jazz":
                    wordHint = "A genre of music";
                    break;
                case "quiz":
                    wordHint = "A short test of knowledge";
                    break;
            }
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("┌─────────────────────────────────────┐");
                Console.WriteLine("│   ❤️  Hearts: " + underlie.hearts.ToString().PadRight(20) + "   │");
                Console.WriteLine("│   💡 Hint: " + wordHint.PadRight(42 - wordHint.Length) + " ");
                Console.WriteLine("└─────────────────────────────────────┘");
                Console.WriteLine();
                Console.Write("   🔤 Guess the Letter:   ");

                char guesseLetter = Console.ReadLine().ToLower().TrimStart()[0];
                bool win = underlie.PrintUnderlines(randomWordGen, guesseLetter);
                if (win)
                {
                    Console.OutputEncoding = System.Text.Encoding.UTF8;
                    Console.WriteLine();
                    Console.WriteLine("🎉🎉🎉──────────────────────────🎉🎉🎉");
                    Console.WriteLine(".  🏆   YOU WON! CONGRATS!!!   🏆");
                    Console.WriteLine("🎉🎉🎉──────────────────────────🎉🎉🎉");
                    Console.WriteLine();
                    break;
                }
                if (!randomWordGen.Contains(guesseLetter))
                {
                    if (underlie.hearts == 0)
                    {
                        Console.OutputEncoding = System.Text.Encoding.UTF8; 
                        Console.WriteLine();
                        Console.WriteLine("💀💀💀──────────────────────────💀💀💀");
                        Console.WriteLine(".  ❌   GAME OVER! YOU LOST!   ❌");
                        Console.WriteLine("💀💀💀──────────────────────────💀💀💀");
                        Console.WriteLine();
                        break;
                    }
                }
            }
        }
    }  
}

