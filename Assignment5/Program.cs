using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.Write("The Longest word is : ");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        public string MyFunctionA(string input)
        {
            string[] words = input.Split(' ');
            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];
            int x = 0;
            foreach (var word in words)
            {
                if (word.Length > x)
                {
                    input = word;
                    x = word.Length;
                }
            }
            string currentWord = words[0];
            string nextWord;
            string longestWord = currentWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
            }
            return input;
        }
    }
}



