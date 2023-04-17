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
                string input = Console.ReadLine();
                string reverse = ReverseWords(input);
                Console.WriteLine("Разделение и обратная последовательность слов: ");
                Console.WriteLine(reverse);
                Console.ReadKey();
            }
            static string ReverseWords(string input)
            {
                string[] words = SplitWords(input);

                Array.Reverse(words);

                return string.Join(" ", words);
            }
            static string[] SplitWords(string input)
            {
                return input.Split(' ');
            }
    }
}
