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
                return word;
            }

            return result;
        }

        private static string Replace(string word)
        {
            string result = String.Empty;
            foreach (var t in word)
            {
                if (VowelString.IndexOf(t) >= 0)
                {
                    result += "mommy";
                }
                else
                {
                    result += t;
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