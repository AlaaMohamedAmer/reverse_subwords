using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_subwords
{
    internal class Program
    {
        static void Main()
        {
            string input = "Alaa";
            string reversed = reverse_subwords(input);
            Console.WriteLine(reversed);
            Console.ReadLine();
        }

        static string reverse_subwords(string line)
        {
            string[] words = line.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            string reversedLine = string.Join(" ", words);

            return reversedLine;
        }
    }
}

