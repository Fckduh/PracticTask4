using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask4._2
{
    internal class Program
    {
            static void Main(string[] args)
            {
                string inputPhrase = Console.ReadLine();
                string reversedPhrase = ReverseWords(inputPhrase);
                Console.WriteLine("Разделение и обратная последовательность слов: ");
                Console.WriteLine(reversedPhrase);
                Console.ReadKey();
            }
            static string ReverseWords(string inputPhrase)
            {
                string[] words = SplitWords(inputPhrase);

                Array.Reverse(words);

                return string.Join(" ", words);
            }
            static string[] SplitWords(string inputPhrase)
            {
                return inputPhrase.Split(' ');
            }
    }
}
