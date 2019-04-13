using System;
using System.IO;
using System.Linq;

namespace HandleString
{
    public static class ModifyString
    {
        private const string VowelString = "aeiou";
        public static string Modify(string word)
        {           
            var result = ShouldBeModify(word)? Replace(word) : word;

            return result;
        }

        private static bool ShouldBeModify(string word)
        {
            var count = CountVowels(word);

            return (count * 1.0) / word.Length >= 0.30;
        }


        private static string Replace(string word)
        {
            var result = string.Empty;
            
            for (var i =0; i< word.Length; i++)
            {
                if (BeVowel(word[i]))
                {
                    if(i == 0 || !BeVowel(word[i-1]))
                    {
                        result += "mommy";
                    }
                }
                else
                {
                    result += word[i];
                }
            }

            return result;
        }

        private static bool BeVowel(char letter)
        {
            return VowelString.IndexOf(letter) >= 0;
        }

        private static int CountVowels(string word)
        {
            var countVowels = word.Count(t => BeVowel(t) == true);
            return countVowels;
        }
    }
}