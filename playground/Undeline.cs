using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace playground
{
    public class Underline
    {
        private List<char> guessedLetters = new List<char>();
        private List<char> alreadyUsedLetter = new List<char>();
        public int hearts = 5;

        public bool PrintUnderlines(List<char> randomWordGen, char guessedLetter)
        {
            if (!randomWordGen.Contains(guessedLetter))
                hearts--;
            guessedLetters.Add(guessedLetter);
            bool win = true;
            Console.WriteLine();
            for (int i = 0; i < randomWordGen.Count; i++)
            {
                if (!ContainsLetter(randomWordGen[i]))
                {
                    win = false;
                    Console.Write(" _ ");
                }
                else
                    Console.Write(randomWordGen[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            return (win);
        }
        public bool ContainsLetter(char letter)
        {
            if (guessedLetters.Contains(letter))
            {
                if (!alreadyUsedLetter.Contains(letter))
                {
                    if (hearts < 5)
                        hearts++;
                    alreadyUsedLetter.Add(letter);
                } 
                return (true);
            }
            else
                return (false);
        }
    }
}
