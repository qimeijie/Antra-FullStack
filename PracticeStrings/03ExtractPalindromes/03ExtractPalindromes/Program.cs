using System.Text;

namespace _03ExtractPalindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();

            string[] words = ExtractPalindromes(input);
            string result = string.Join(", ", words);
            Console.WriteLine(result);
        }
        static string[] ExtractPalindromes(string sentence)
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
            StringBuilder word = new StringBuilder();
            List<string> words = new List<string>();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (chars.Contains(sentence[i]))
                {
                    if (word.Length > 0)
                    {
                        if(IsPalindrome(word.ToString()))
                        {
                            words.Add(word.ToString());
                        }
                        word.Clear();
                    }
                }
                else
                {
                    word.Append(sentence[i]);
                }
            }
            if (word.Length > 0 && IsPalindrome(word.ToString()))
            {
                words.Add(word.ToString());
            }
            
            words.Sort();
            return words.ToArray();
        }

        static bool IsPalindrome(string word) 
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            for (int i = 0; i <= word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
