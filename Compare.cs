class Compare
{
Words GivenWord = new Words();
char[] wordGiven;
public char[] starLine;

public Compare()
{
    string starLineConvert = ("*****");
    starLine = starLineConvert.ToCharArray();
    wordGiven = GivenWord.LetterSeperate();
}

private bool ReturnIsTrue(char[] wordForGame, char charUserInput)
{
    bool guessIsTrue = false;
    foreach(char c in wordForGame)
    {
         if (charUserInput == c)
         {
            guessIsTrue = true;

         }   
    }
    return guessIsTrue;
}
private int ReturnIndex(char[] wordForGame, char charUserInput)
{
    
    int NumberCounter = -1;
    int NumberIndex = 0;
    foreach(char c in wordForGame)
    {
         NumberCounter = NumberCounter + 1;
         if (charUserInput == c)
         {
            NumberIndex = NumberCounter;
         }   
    }
    return NumberIndex;
}
private char ReturnGuess(char[] wordForGame, char charUserInput)
{
    char correctGuess = '1';
    foreach(char c in wordForGame)
    {
         if (charUserInput == c)
         {
            correctGuess = c;
         }   
    }
    return correctGuess;
}
//the main method that will grab info from game.cs
public char[] CompareGuess(char TheGuess)
{
bool guessIsTrue = ReturnIsTrue(wordGiven, TheGuess);
int index = ReturnIndex(wordGiven, TheGuess);
char correctGuess = ReturnGuess(wordGiven, TheGuess);
if (guessIsTrue == true)
    {
        starLine[index] = wordGiven[index];

        return starLine;
    }
    else
    {
        return starLine;
    }
}

public int wrongAnswer() {
    int tally = 0;
    tally += 1; 
    return tally;
}

public char[] SendLine()
{
    return starLine;
}

}