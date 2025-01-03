using System.Text;
using System.Text.RegularExpressions;

namespace _02ReverseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string result = ReverseWords(input);
            Console.WriteLine($"Reversed sentence: {result}");
        }
        static string ReverseWords(string sentence)
        {
            HashSet<char> chars = new HashSet<char> {
                '.',
                ',',
                ':',
                ';',
                '=',
                '(',
                ')',
                '&',
                '[',
                ']',
                '"',
                '\'',
                '\\',
                '/',
                '!',
                '?',
                ' '
            };
            StringBuilder punc = new StringBuilder();
            StringBuilder word = new StringBuilder();
            Stack<string> words = new Stack<string>();
            Queue<string> puncs = new Queue<string>();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (chars.Contains(sentence[i]))
                {
                    if (word.Length > 0)
                    {
                        words.Push(word.ToString());
                        word.Clear();
                    }
                    punc.Append(sentence[i]);
                }
                else
                {
                    if (punc.Length > 0)
                    {
                        puncs.Enqueue(punc.ToString());
                        punc.Clear();
                    }
                    word.Append(sentence[i]);
                }
            }
            if (word.Length > 0)
            {
                words.Push(word.ToString());
            }
            if (punc.Length > 0) 
            { 
                puncs.Enqueue(punc.ToString());
            }
            StringBuilder result = new StringBuilder();
            while (words.Count > 0 && puncs.Count > 0)
            {
                result.Append(words.Pop());
                result.Append(puncs.Dequeue());
            }
            return result.ToString();
        }
    }
}
