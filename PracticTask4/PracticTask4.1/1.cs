using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask4
{
    internal class Program
    {

        static string[] SplitText(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }

        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] words = SplitText(input);
            DisplayWords(words);
            Console.ReadKey();

        }
        static void DisplayWords(string[] words)
        {
            Console.WriteLine("Слова в предложении:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

