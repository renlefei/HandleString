using System;
using System.IO;
using System.Linq;

namespace HandleString
{
    public static class MommifyString
    {
        public const string VowelString = "aeiou";
        public static string Mommify(string word)
        {
            var count = CountVowels(word);

            var result = string.Empty;

            if ((count * 1.0) / word.Length >= 0.30)
            {
                result = Replace(word);
            }
            else
            {
                result = word;
            }

            return result;
        }

        private static string Replace(string word)
        {
            var result = string.Empty;
            
            foreach (var letter in word)
            {
                if (VowelString.IndexOf(letter) >= 0)
                {
                    result += "mommy";
                }
                else
                {
                    result += letter;
                }
            }

            return result;
        }

        private static int CountVowels(string word)
        {
            var countVowels = word.Count(t => VowelString.IndexOf(t) >= 0);
            return countVowels;
        }
    }
}