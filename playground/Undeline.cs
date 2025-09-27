using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace playground
{
    public class Underline
    {
        List<char> guessedLetters = new List<char>();

        public bool PrintUnderlines(List<char> randomWordGen, char guessedLetter)
        {
            guessedLetters.Add(guessedLetter);
            bool win = true;
            for (int i = 0; i < randomWordGen.Count; i++)
            {
                if (!ContainsLetter(randomWordGen[i]))
                {
                    win = false;
                    Console.Write("_ ");
                }
                else
                    Console.Write(randomWordGen[i]);
            }
            return (win);
        }
        public bool ContainsLetter(char letter)
        {
            if (guessedLetters.Contains(letter))
                return (true);
            else
                return (false);
        }
    }
}
