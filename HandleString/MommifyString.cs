namespace HandleString
{
    public static class MommifyString
    {
        public static string Mommify(string word)
        {
            if ("aeiou".IndexOf(word[0]) >= 0)
                return "mommy";
            return word;
        }
    }
}