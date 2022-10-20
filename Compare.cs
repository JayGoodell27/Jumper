Words GivenWord = new Words();

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
class Compare
{
Words GivenWord = new Words();
char[] wordGiven;

public Compare()
{
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
    
    int NumberCounter = 0;
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
public List<string> CompareGuess(TheGuess)
{
    
}

// private void rewriteGuessLine(guessIsTrue, )
// {
// if (guessIsTrue == true)
// {
//     Display[NumberCounter] = wordForGame[NumberCounter];

//     Console.WriteLine("You Guess Correct!");
//     Console.WriteLine($"Your guess like is {Display}");
// }
// else
// {
//     Console.WriteLine("You Guessed Wrong");
// }
// }


public int wrongAnswer() {
    int tally = 0;
    tally += 1; 
    return tally;
}

}