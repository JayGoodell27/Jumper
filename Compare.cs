<<<<<<< HEAD
=======
//Words GivenWord = new Words();

// char[] wordForGame = WordsTest.LetterSeperate();
// List<string> Display = new List<string>();
// Display.Add("*");
// Display.Add("*");
// Display.Add("*");
// Display.Add("*");
// Display.Add("*");

// Console.Write("WORD GAME: Guess letters for a 5 letter word");
// string userInput = Console.ReadLine();
// var charUserInput = userInput.ToCharArray();
// int NumberCounter = -1;
// string StringWord = wordForGame.ToString();
>>>>>>> f3e743bd41c0373508937edbb6a9b4a9235f0cfc
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
<<<<<<< HEAD
public char[] CompareGuess(char TheGuess)
=======
//the main method that will grab info from game.cs
public List<string> CompareGuess(TheGuess)
>>>>>>> f3e743bd41c0373508937edbb6a9b4a9235f0cfc
{
bool guessIsTrue = ReturnIsTrue(wordGiven, TheGuess);
int index = ReturnIndex(wordGiven, TheGuess);
char correctGuess = ReturnGuess(wordGiven, TheGuess);
if (guessIsTrue == true)
    {
        starLine[index] = wordGiven[index];

        // Console.WriteLine($"Your guess line is {starLine}");
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

}