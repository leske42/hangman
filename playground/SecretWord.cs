using System;
using System.Collections.Generic;

namespace playground
{
    public class secretWord
    {
        public List<string> words = new List<string>()
        {
            "flower",
            "summer",
            "book",
            "computer",
            "world"
        };
        public void PrintSecretWord()
        {
            foreach (var name in words)
                Console.WriteLine(name);
        }
        public string RandomWord()
        {
            Random random = new Random();
            int index = random.Next(words.Count);
            string randomWord = words[index];
            return randomWord;
        }
    }
}
