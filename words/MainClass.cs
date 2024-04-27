using System;
using System.Collections.Generic;

namespace words
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            List<string> engWords = new List<string> { "hello", "world", "cat", "dog", "sun", "moon" };
            List<string> rusWords = new List<string> { "привет", "мир", "кот", "собака", "солнце", "луна" };


            if (engWords.Count != rusWords.Count)
            {
                Console.WriteLine("The lists do not have the same number of words.");
                return;
            }

            while (true)
            {
                Console.WriteLine("Enter a word to translate (type 'exit' to quit):");
                string input = Console.ReadLine().Trim();
                if (input.ToLower() == "exit") break;


                int index = engWords.IndexOf(input);
                if (index != -1)
                {
                    Console.WriteLine("Russian: " + rusWords[index]);
                    continue;
                }


                index = rusWords.IndexOf(input);
                if (index != -1)
                {
                    Console.WriteLine("English: " + engWords[index]);
                    continue;
                }

                Console.WriteLine("Word not found.");
            }
        }
    }
}
