class Words
{
    public char[] LetterSeperate()
    {
        string WordGive()
            {
            List<string> wordList = new List<string>();
            wordList.Add("chaps");
            wordList.Add("actor");
            wordList.Add("hacky");
            Random rnd = new Random();
            int randIndex = rnd.Next(wordList.Count);
            var random = wordList[randIndex];
            return random;   
            }
    string currentWord = WordGive();
    char[] WordSeperated = currentWord.ToCharArray();
    // Console.Write(WordSeperated[1]);
    return WordSeperated;
    }


}




