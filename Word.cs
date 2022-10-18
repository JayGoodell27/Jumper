
Words WordsTest = new Words();
string word = WordsTest.WordGive();
WordsTest.LetterSeperate(word);


class Words
{
    public string WordGive()
    {
        List<string> wordList = new List<string>();
        wordList.Add("runny");
        wordList.Add("actor");
        wordList.Add("silly");
        Random rnd = new Random();
        int randIndex = rnd.Next(wordList.Count);
        var random = wordList[randIndex];
        return random;   
    }
    public List<string> LetterSeperate(string WordGive)
    {

    List<string> WordSeperated = WordGiven.ToCharArray();
    Console.Write(WordSeperated);
    return WordSeperated;
    }

}
