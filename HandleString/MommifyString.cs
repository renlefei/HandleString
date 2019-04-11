namespace HandleString
{
    public static class MommifyString
    {       
        public static string Mommify(string word)
        {
            var count = 0;

            for (var i = 0; i < word.Length; i++)
            {
                if("aeiou".IndexOf(word[i]) >=0)
                    count+=1;
            }

            var result = string.Empty;

            if ((count * 1.0) / word.Length >= 0.30)
            {
                for (var i = 0; i < word.Length; i++)
                {
                    if ("aeiou".IndexOf(word[i]) >= 0)
                    {
                        result += "mommy";
                    }
                    else
                    {
                        result += word[i];
                    }
                }
            }
            else
            {
                return word;
            }

            return result;
        }
    }
}