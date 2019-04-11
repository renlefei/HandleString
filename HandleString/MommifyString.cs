namespace HandleString
{
    public static class MommifyString
    {
        public static string Mommify(string word)
        {
            if (word == "a" || word =="e" || word =="i" || word =="o" || word=="u")
                return "mommy";
            return word;
        }
    }
}